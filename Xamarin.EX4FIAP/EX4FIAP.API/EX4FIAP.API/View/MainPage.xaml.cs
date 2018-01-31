using EX4FIAP.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EX4FIAP.API.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        ProfessorViewModel vmProfessor;
        public MainPage()
        {
            vmProfessor = new ProfessorViewModel();
            BindingContext = vmProfessor;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            vmProfessor = new ProfessorViewModel();
            BindingContext = vmProfessor;
            base.OnAppearing();
        }
        private void OnNovo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovoProfessorView());
        }
        private void OnAlunoTapped(object sender, ItemTappedEventArgs args)
        {
            var selecionado = args.Item as EX4FIAP.API.Model.Professor;
            DisplayAlert("Professor selecionado", "Aluno: " + selecionado.Id, "OK");
        }
    }
}