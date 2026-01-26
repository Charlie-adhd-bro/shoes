using Microsoft.EntityFrameworkCore;
using shoes.Models;
using shoes.Properties;
using System.IO;

namespace shoes
{
    public partial class FormProducts : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormProducts(User user, bool guest)
        {
            InitializeComponent();

            // Настройка колонок программно
            dgvProducts.Columns.Clear();

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.HeaderText = "Фото";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 150;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.HeaderText = "Описание товара";
            colInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "colDiscount";
            colDiscount.HeaderText = "Скидка";
            colDiscount.Width = 80;
            colDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colPhoto, colInfo, colDiscount });

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                using var db = new ShoesBdContext();
                var products = db.Products
                    .Include(i => i.Category)
                    .Include(i => i.Manufacturer)
                    .Include(i => i.Supplier)
                    .Include(i => i.Measure)
                    .Include(i => i.ProductType)
                    .ToList();

                dgvProducts.SuspendLayout();
                dgvProducts.Rows.Clear();

                foreach (var product in products)
                {
                    int rowIndex = dgvProducts.Rows.Add();
                    var row = dgvProducts.Rows[rowIndex];

                    row.Cells["colPhoto"].Value = LoadProductImage(product.PhotoUrl);
                    //MessageBox.Show($"product.PhotoUrl: {product.PhotoUrl}", "product.PhotoUrl",
                    //MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Заполняем информацию
                    row.Cells["colInfo"].Value = FormatProductInfo(product);

                    // Заполняем скидку
                    row.Cells["colDiscount"].Value = $"{product.Discount}%";

                    ApplyRowStyles(row, product);
                }

                dgvProducts.ResumeLayout();
                dgvProducts.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyRowStyles(DataGridViewRow row, Product product)
        {
            // Если скидка > 15%, выделяем цветом (Hex #2E8B57 - SeaGreen)
            if (product.Discount > 15)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");
                row.DefaultCellStyle.ForeColor = Color.White;
            }

            // Если товара нет на складе
            if (product.CointInStock <= 0)
            {
                row.DefaultCellStyle.BackColor = Color.LightGray;
            }

            if (product.Discount > 0)
            {
                row.Cells["colDiscount"].Style.ForeColor = Color.Red;
                row.Cells["colDiscount"].Style.Font = new Font("Arial", 10, FontStyle.Bold);
            }
        }

        private static string FormatProductInfo(Product product)
        {
            string priceText;
            if (product.Discount > 0)
            {
                decimal finalPrice = product.Price * (100 - product.Discount) / 100;
                priceText = $"{product.Price:N2} руб. -> {finalPrice:N2} руб.";
            }
            else
            {
                priceText = $"{product.Price:N2} руб.";
            }

            return $"{product.Category?.CategoryName} | {product.ProductType?.ProdType}" + Environment.NewLine +
                   $"Производитель: {product.Manufacturer?.ManufacturerName}" + Environment.NewLine +
                   $"Описание: {product.Description}" + Environment.NewLine +
                   $"Цена: {priceText}" + Environment.NewLine +
                   $"На складе: {product.CointInStock} {product.Measure?.MeasureName}";
        }


        private static Image LoadProductImage(string photoName)
        {
            if (string.IsNullOrWhiteSpace(photoName))
            {
                return Resources.picture; // Изображение по умолчанию
            }

            try
            {
                // 1. Убираем расширение (например, .jpg), так как в ресурсах имена хранятся без них
                string resourceName = Path.GetFileNameWithoutExtension(photoName.Trim());

                // 2. Достаем объект из менеджера ресурсов по имени
                object obj = Resources.ResourceManager.GetObject(resourceName);

                // 3. Проверяем, нашлось ли изображение и того ли оно типа
                if (obj is Image image)
                {
                    return image;
                }
            }
            catch
            {
                // В случае ошибки возвращаем картинку по умолчанию
            }

            return Resources.picture;
        }


        private void BtnLogut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
