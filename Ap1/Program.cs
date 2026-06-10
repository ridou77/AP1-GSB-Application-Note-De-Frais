using GSB_demo.Views;

using GSB_demo.Views;

namespace GSB_demo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            while (true)
            {
                using var loginForm = new LoginForm();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    break;
                }

                using var mainForm = new MainForm(loginForm.ConnectedUser);
                mainForm.ShowDialog();

                if (!mainForm.LogoutRequested)
                {
                    break;
                }
            }
        }
    }
}
