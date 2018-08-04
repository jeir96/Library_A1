using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Library_A1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LogIn_Clicked(object sender, EventArgs e)
        {
            bool isUserNameEmpty = string.IsNullOrEmpty(username_login.Text);
            bool isPassWordEmpty = string.IsNullOrEmpty(password_login.Text);
            if (isUserNameEmpty || isPassWordEmpty)
            {
                DisplayAlert("Alert", "Enter Yor UserName and Yor Password Or Signup", "OK");
            }
            else {
                Navigation.PushAsync(new HomePage());
            }
        }

        private void SignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}
