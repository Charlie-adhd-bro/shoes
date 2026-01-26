using Microsoft.EntityFrameworkCore;
using shoes.Models;
using shoes.Properties;

namespace shoes
{
    public partial class FormOrders : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormOrders(User user, bool guest)
        {
            InitializeComponent();

            // Создаем только текстовые колонки
            var colInfo = new DataGridViewTextBoxColumn
            {
                Name = "colInfo",
                HeaderText = "Информация о заказе",
                FillWeight = 70,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDeliveryDate = new DataGridViewTextBoxColumn
            {
                Name = "colDeliveryDate",
                HeaderText = "Дата доставки",
                Width = 120
            };

            dgvOrders.Columns.Clear();
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colInfo, colDeliveryDate });

            CurrentUser = user;
            IsGuest = guest;
            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using var db = new ShoesBdContext();
                var orders = db.Orders
                    .Include(i => i.Status)
                    .Include(i => i.DeliveryPoint)
                    .Include(i => i.ProductsOrders).ThenInclude(po => po.Product)
                    .ToList();

                // Группируем заказы по коду (Code)
                var ordersByCode = orders.GroupBy(o => o.Code);

                dgvOrders.SuspendLayout();
                dgvOrders.Rows.Clear();

                foreach (var group in ordersByCode)
                {
                    var firstOrder = group.First();
                    // Собираем все артикулы товаров в этом заказе
                    var articles = group.SelectMany(o => o.ProductsOrders)
                                       .Select(po => po.Product.Art)
                                       .Distinct();

                    int rowIndex = dgvOrders.Rows.Add();
                    var row = dgvOrders.Rows[rowIndex];

                    row.Cells["colInfo"].Value = FormatOrderInfo(firstOrder, articles);
                    row.Cells["colDeliveryDate"].Value = firstOrder.DeliveryDate.ToShortDateString();
                }

                dgvOrders.ResumeLayout();
                dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private string FormatOrderInfo(Order order, IEnumerable<string> articleNumbers)
        {
            return $"Артикулы: {string.Join(", ", articleNumbers)}" + Environment.NewLine +
                   $"Статус: {order.Status?.StatusName}" + Environment.NewLine +
                   $"Пункт выдачи: {order.DeliveryPoint?.DeliveryAddress}" + Environment.NewLine +
                   $"Дата заказа: {order.OrderDate.ToShortDateString()}";
        }

        private void BtnLogut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
