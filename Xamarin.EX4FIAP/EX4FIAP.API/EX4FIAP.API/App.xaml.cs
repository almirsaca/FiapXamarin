using EX4FIAP.API.Model;
using EX4FIAP.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;


namespace EX4FIAP.API
{
    public partial class App : Application
    {
        #region ViewModels
        public static ProfessorViewModel ProfessorVM { get; set; }

        #endregion

        public App()
        {
            InitializeComponent();
            InitializeApplication();

            MainPage = new NavigationPage(new View.MainPage() { BindingContext = App.ProfessorVM });
        }

        private void InitializeApplication()
        {
            if (ProfessorVM == null) ProfessorVM = new ProfessorViewModel();
        }
    }
}
