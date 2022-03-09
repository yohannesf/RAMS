using RAMSDB_WinForms.ViewModels.LoginViewModel;
using System;
using System.Windows.Forms;

namespace RAMSDB_WinForms
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        LoginViewModel vm = new LoginViewModel();

        public Login()
        {
            InitializeComponent();

            loginViewModelBindingSource.DataSource = vm;





            //--------------UNCOMMENT THE BELOW LINE FOR LOGIN
            vm.HasLoggedIn += Vm_HasLoggedIn;

        }

        private void Vm_HasLoggedIn(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void Login_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            //this.Close();

            //if (tUserNameTextEdit == null || PasswordTextEdit == null) return;
            ////{
            ////    MessageBox.Show("Please enter user name and password");
            ////    return;
            ////}


            //REAL CODE IS HERE --- FOR TESTING, USE THE ABOVE CODE
            var loginStatus = vm.Login();


            if (!loginStatus)
            {


                tUserNameTextEdit.EditValue = "";
               // PasswordTextEdit.EditValue = "";
            }
        }
    }
}