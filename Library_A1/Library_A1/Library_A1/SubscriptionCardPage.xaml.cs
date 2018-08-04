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
	public partial class SubscriptionCardPage : ContentPage
	{
		public SubscriptionCardPage ()
		{
			InitializeComponent ();
		}

        private void New_Subscription_Card_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewSubscriptionCardPage());
        }
        private void I_Lose_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewSubscriptionCardPage());
        }
    }
}