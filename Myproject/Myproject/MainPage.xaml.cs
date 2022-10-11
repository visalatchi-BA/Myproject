using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Myproject
{
    public partial class MainPage : TabbedPage
    {
        public IList<product> Ilist { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Ilist = new List<product>();
            Ilist.Add(new product { productName = "Saree", Description = "Women's Banarasi Art Silk Saree", ImageURL = "picture.jpg", cart="Add to cart"});
            Ilist.Add(new product { productName = "Lehenga", Description = "Floral Print Semi Stitched Lehenga ", ImageURL = "lehenga.jpg", cart = "Add to cart" });
            Ilist.Add(new product { productName = "Women Kurta", Description = "Women Kurta and Dupatta Set Crepe ", ImageURL = "kurta.jpg", cart = "Add to cart" });
            Ilist.Add(new product { productName = "Women T-shirt", Description = "Color Block Women Round Neck Black T-Shirt", ImageURL = "shirt.jpg", cart = "Add to card" });
            Ilist.Add(new product { productName = "Rain Coat", Description = "Graphic Print Girls Raincoat", ImageURL = "coat.jpg", cart = "Add to card" });
            BindingContext = this;

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (textUsername.Text== "visalatchi" & textpassword.Text == "123")
            {
                Navigation.PushAsync(new ContentPage());
            }
            else
            {
                DisplayAlert("oops", "login failed", "OK");
            }

        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchresult = Ilist.Where(c => c.productName.ToLower().Contains(Bar.Text.ToLower()));
            visa.ItemsSource = searchresult;
                
            
        }
        public class product
        {

            public string productName { get; set; }
            public string Description { get; set; }
            public string ImageURL { get; set; }
            public string cart { get; set; }
          
        }

    }
}
