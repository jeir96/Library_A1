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
	public partial class AdvancedSearchPage : ContentPage
	{
		public AdvancedSearchPage ()
		{
			InitializeComponent ();
		}

        private void Borrow_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BorrowPage());
        }

        private void Buy_Clicked(object sender ,EventArgs e)
        {

        }

    }
}