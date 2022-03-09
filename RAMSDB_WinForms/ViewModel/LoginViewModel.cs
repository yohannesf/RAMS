using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Linq;
using System.Windows;
using static RAMSDB.Data.RAMSDBDataLoader;

namespace RAMSDB_WinForms.ViewModels.LoginViewModel
{
    public class LoginViewModel
    {
        private RAMSDBEntities _context = new RAMSDBEntities();


        public virtual string tUserName { get; set; }
        public virtual string Password { get; set; }
        public event EventHandler HasLoggedIn;


        public bool Login()
        {
            UserRepository userRepository = new UserRepository(_context);
            // ICollection<Users> u = new List<Users>();
            //u = tc.GetByUserName(tUserName);//.GetAll();


            //REAL CODE
                var user = _context.User.Where(t => t.UserName == tUserName).FirstOrDefault();






           // var user = _context.User.Where(c => c.UserName == "Amhara").FirstOrDefault();

            // var user = _context.User.Where(c => c.UserName == "Abeshege").FirstOrDefault();

            //var user = _context.User.Where(c => c.UserName == "snnp").FirstOrDefault();

         //  var user = _context.User.Where(c => c.UserName == "Meskan").FirstOrDefault();




            //var user = _context.User.Where(c => c.UserName == "Cheha").FirstOrDefault();
            // var user = _context.User.Where(c => c.UserName == "Enidguagn").FirstOrDefault();
            //tc.GetByUserName("Abeshege");




            if (user != null && user.IsActive)
            {
                tUserName = user.UserName;

                HasLoggedIn(this, new EventArgs());


                LoginInfo.GetLoggedInUser = user;
                //LoginInfo.GetLoggedInUser = 

                //Application.Current.Resources.Add("UserID", user.UserID);

                return true;


                //Password ="123"  ; //user.Password;

                //if (user.Password == Password)
                //{

                //    HasLoggedIn(this, new EventArgs());


                //    LoginInfo.GetLoggedInUser = user;
                //    //LoginInfo.GetLoggedInUser = 

                //    //Application.Current.Resources.Add("UserID", user.UserID);

                //    return true;

                //}
                //else
                //{
                //    MessageBox.Show("Please Enter the correct User Name and Password", "Incorrect User Name and/or Password", MessageBoxButton.OK, MessageBoxImage.Error);


                //    return false;
                //}
            }
            else
            {
                MessageBox.Show("Please Enter the correct User Name", "Incorrect User Name", MessageBoxButton.OK, MessageBoxImage.Error);

                return false;
            }
            //var user = Users conn.Table<User>().Where(u => u.Username == User.Username).FirstOrDefault();

            //if (user.Password == User.Password)
            //{
            //    App.UserId = user.Id.ToString();
            //    HasLoggedIn(this, new EventArgs());
            //}
            //    }
        }
    }
}
