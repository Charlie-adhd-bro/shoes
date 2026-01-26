using shoes.Models;

namespace shoes
{
    // Выносим Enum за пределы класса для удобного доступа
    public enum UserChoice { Products, Orders }

    public partial class FormSelection : Form
    {
        // Свойства для хранения данных
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public UserChoice SelectedSection { get; private set; }

        // ОСТАВЛЯЕМ ТОЛЬКО ОДИН КОНСТРУКТОР
        public FormSelection(User user, bool isGuest)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.IsGuest = isGuest;

            if (isGuest)
            {
                btnOrders.Enabled = false;
                btnOrders.Text += " (недоступно)";
            }
            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            SelectedSection = UserChoice.Products;
            this.DialogResult = DialogResult.OK;
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            SelectedSection = UserChoice.Orders;
            this.DialogResult = DialogResult.OK;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
