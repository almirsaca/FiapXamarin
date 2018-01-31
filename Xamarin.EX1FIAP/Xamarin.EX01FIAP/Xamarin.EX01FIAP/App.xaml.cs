using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.EX01FIAP.ViewModel;
using Xamarin.Forms;

namespace Xamarin.EX01FIAP
{
    public partial class App : Application
    {
        public static ConfigViewModel ConfigVM { get; set; }

        public App()
        {
            InitializeComponent();
            InitializeApplication();

            MainPage = new NavigationPage(new Xamarin.EX01FIAP.Views.HomeView() { BindingContext = App.ConfigVM });
        }

        private void InitializeApplication()
        {
            if (ConfigVM == null) ConfigVM = new ConfigViewModel();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
