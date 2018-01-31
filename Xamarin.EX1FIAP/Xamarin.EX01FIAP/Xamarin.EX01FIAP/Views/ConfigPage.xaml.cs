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
    public partial class ConfigPage : ContentPage
    {
        public ConfigPage()
        {
            InitializeComponent();
        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            if (swRecebeEmail.On)
            {
                txtEmail.IsVisible = true;
                btnSalvar.IsVisible = true;
            }
            else
            {
                txtEmail.IsVisible = false;
                btnSalvar.IsVisible = false;
                txtEmail.Text = null;
            }
        }
    }
}