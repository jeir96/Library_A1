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
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

        private void Advanced_Search_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdvancedSearchPage());
        }
        private void Buy_Sell_Clicked(object sender, EventArgs e)
        {   
            Navigation.PushAsync(new Buy_And_SellPage());
        }
    }
}