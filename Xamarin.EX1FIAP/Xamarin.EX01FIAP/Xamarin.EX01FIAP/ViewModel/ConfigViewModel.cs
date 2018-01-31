using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using Xamarin.EX01FIAP.Views;

namespace Xamarin.EX01FIAP.ViewModel
{
    public class ConfigViewModel : INotifyPropertyChanged
    {
        #region Propriedades
        public Model.Model ConfigModel { get; set; }
        public Model.Model Config { get; set; } = new Model.Model();

        public OnAdicionarEmailCMD OnAdicionarEmailCMD { get; }
        public OnVerificarEmailCMD OnVerificarEmailCMD { get; }
        public ICommand OnNovoCMD { get; private set; }
        public ICommand OnSairCMD { get; private set; }
        #endregion


        public ConfigViewModel()
        {
            ConfigModel = new Model.Model();
            OnAdicionarEmailCMD = new OnAdicionarEmailCMD(this);
            OnVerificarEmailCMD = new OnVerificarEmailCMD(this);
            OnSairCMD = new Command(OnSair);
            OnNovoCMD = new Command(OnNovo);
        }

        public void AdicionarEmail(Model.Model paramModel)
        {
            try
            {
                Config = paramModel;
                App.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception)
            {
                App.Current.MainPage.DisplayAlert("Falhou", "Desculpe, ocorreu um erro inesperado =(", "OK");
            }
        }

        public void VerificaEmailAdd(Model.Model paramModel)
        {
            try
            {
                if (paramModel.Email == null)
                    App.Current.MainPage.DisplayAlert("Mensagem", "E-mail não autorizado", "OK");
                else
                    App.Current.MainPage.DisplayAlert("Mensagem", $"E-mail enviado para {paramModel.Email}", "OK");

            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Falhou", "Desculpe, ocorreu um erro inesperado =(", "OK");

            }
        }

        private async void OnSair()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }

        private async void OnNovo()
        {
            await App.Current.MainPage.Navigation.PushAsync(new ConfigPage() { BindingContext = App.ConfigVM });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void EventPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class OnAdicionarEmailCMD : ICommand
    {
        private ConfigViewModel configVM;
        public OnAdicionarEmailCMD(ConfigViewModel paramVM)
        {
            configVM = paramVM;
        }
        public event EventHandler CanExecuteChanged;
        public void DeleteCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            configVM.AdicionarEmail(parameter as Model.Model);
        }

    }

    public class OnVerificarEmailCMD : ICommand
    {
        private ConfigViewModel configVM;
        public OnVerificarEmailCMD(ConfigViewModel paramVM)
        {
            configVM = paramVM;
        }
        public event EventHandler CanExecuteChanged;
        public void DeleteCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public bool CanExecute(object parameter)
        {
            if (parameter != null) return true;

            return false;
        }
        public void Execute(object parameter)
        {
            configVM.VerificaEmailAdd(parameter as Model.Model);
        }
    }
}

