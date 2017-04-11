using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xam.Test.View
{
    public partial class MainMenuView : ContentPage
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private async void BtnXamTest1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamTest1View());
        }
    }
}
