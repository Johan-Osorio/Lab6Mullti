using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCode : ContentPage
    {
        public ListViewCode()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            listview.ItemsSource = new string[]
            {
                "Angola",
                "Arabia Saudí",
                "Argentina",
                "Alemania",
                "Australia",
                "Argelia",
                "Albania",
                "Águila",
                "Armadillo",
            };
        }
    }
}