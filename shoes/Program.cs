using static shoes.FormSelection;

namespace shoes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            while (true) // Цикл авторизации
            {
                using var formLogin = new FormMain();
                if (formLogin.ShowDialog() != DialogResult.OK) break;

                bool logout = false;
                while (!logout) // Цикл внутри аккаунта
                {
                    using var formSelect = new FormSelection(formLogin.CurrentUser, formLogin.IsGuest);
                    var result = formSelect.ShowDialog();

                    if (result == DialogResult.Cancel) // Нажали "Сменить пользователя"
                    {
                        logout = true;
                        continue;
                    }

                    if (result != DialogResult.OK) return; // Закрыли крестиком — выход из программы

                    // Открываем выбранную форму
                    Form nextForm = formSelect.SelectedSection == UserChoice.Products
                        ? new FormProducts(formLogin.CurrentUser, formLogin.IsGuest)
                        : new FormOrders(formLogin.CurrentUser, formLogin.IsGuest);

                    using (nextForm)
                    {
                        // Если в форме товаров/заказов нажали "Назад" (DialogResult.Cancel)
                        if (nextForm.ShowDialog() != DialogResult.Cancel)
                        {
                            return; // Если закрыли совсем — выходим из программы
                        }
                    }
                }
            }


        }
    }
}