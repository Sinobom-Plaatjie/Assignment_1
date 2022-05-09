using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Whatsapp : ContentPage
    {
        public Whatsapp()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(5000);

            Navigation.PushAsync(new InsideWhatsapp());
        }

    }
}