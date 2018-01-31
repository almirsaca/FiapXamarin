using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.EX01FIAP.ViewModel;

namespace Xamarin.EX01FIAP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {

        

        public HomeView()
        {
            InitializeComponent();
        }

        private void btnConfig_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.ConfigPage());
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {

        }
    }
}