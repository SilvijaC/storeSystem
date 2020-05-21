using System.Windows.Forms;

namespace storeSystem
{
    public class StoreApplicationContext : ApplicationContext
    {

        public StoreApplicationContext() : base() {
            LoadInitialForm();
        }

        private void LoadInitialForm()
        {
            var loginForm = new LoginForm();
            loginForm.OnUserLogin += LoginForm_OnUserLogin;
            loginForm.OnUserClose += LoginForm_OnUserClose;
            loginForm.Show();
        }

        private void LoginForm_OnUserClose(bool shouldExitApp)
        {
            if (shouldExitApp) ExitThread();
        }

        private void LoadStoreForm()
        {
            var storeForm = new StoreForm();
            storeForm.FormClosed += StoreForm_FormClosed;
            storeForm.Show();
        }

        private void LoginForm_OnUserLogin()
        {
            LoadStoreForm();
        }

        private void StoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitThread();
        }
    }
}
