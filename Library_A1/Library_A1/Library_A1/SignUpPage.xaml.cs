using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Library_A1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void Signup_Clicked(object sender, EventArgs e)
        {
            bool a = Make_SSC.IsToggled;
            if (a == true)
            { Navigation.PushAsync(new SubscriptionCardPage()); }
        }
    }
}