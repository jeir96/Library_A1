using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using Microsoft;
using System.Net;
using System.Net.Http;


namespace Library_A1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

    


        async Task<string> test()
        {
            var client = new HttpClient();
            string response = await client.GetStringAsync("http://192.168.1.126/Login.php");
            DisplayAlert("Alert", "f", "OK");
            string stringToDisplayInList = response.ToString();
            DisplayAlert("Alert", stringToDisplayInList, "OK");
            return stringToDisplayInList;

        }
        
        async Task<string> GetTextAsync()
        {
            // Check to see if a task was canceled; if so throw a canceled exception.
            // Good to check at several points, including just prior to returning the string.
          
           
             var client = new HttpClient();
            string response = await client.GetStringAsync("http://192.168.1.126:8080/Login.php");
            string stringToDisplayInList = response.ToString();
            return stringToDisplayInList;
        }



        public class UserDetails
        {
            public string first { get; set; }
            public string second { get; set; }
        }

        public async Task<UserDetails> Login()
        {

            string user = username_login.Text;
            string pass = password_login.Text;

            var postData = new List<KeyValuePair<string, string>>(); //prepare $_POST data to send to Login.php file on the pc server(wamp)
            postData.Add(new KeyValuePair<string, string>("username", user));
            postData.Add(new KeyValuePair<string, string>("pass", pass));

            var content = new FormUrlEncodedContent(postData); //make content and load it with $_POST data

            HttpClient client = new HttpClient(); //prepare new web Service to connect to php file
            
            var response = await client.PostAsync("http://192.168.1.60:8080/Login.php" ,content); // connect to Login.php and send $_POST data with it

            var result = response.Content.ReadAsStringAsync().Result; //the result of the Login.php File on the server(wamp)
            var Items = JsonConvert.DeserializeObject<UserDetails>(result); // convert to json format and load it into new UserDetails Object(Items)
            DisplayAlert("Alert",Items.first, "OK");
            if(Items.first == "besher")
                Navigation.PushAsync(new SignUpPage());

            return Items;
        }



        private void LogIn_Clicked(object sender, EventArgs e)
        {
            Login();
        }

        private void SignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}
