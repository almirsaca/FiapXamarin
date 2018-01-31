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
    public partial class NovoProfessorView : ContentPage
    {
        private int professorId = 0;
        public NovoProfessorView()
        {
            InitializeComponent();
        }
        public NovoProfessorView(int Id)
        {
            //InitializeComponent();
            //var aluno = App.ProfessorModel..get.GetAluno(Id);
            //txtNome.Text = aluno.Nome;
            //txtRM.Text = aluno.RM;
            //txtEmail.Text = aluno.Email;
            //IsAprovado.IsToggled = aluno.Aprovado;
            //alunoId = aluno.Id;
        }
        public void OnSalvar(object sender, EventArgs args)
        {
            EX4FIAP.API.Model.Professor professor = new EX4FIAP.API.Model.Professor()
            {
                Nome = txtNome.Text,
                Titulo = txtTitulo.Text,
                Id = professorId.ToString()
            };
            Limpar();

            //App.AlunoModel.SalvarAluno(professor);
            Navigation.PopAsync();
        }
        public void OnCancelar(object sender, EventArgs args)
        {
            Limpar();
            Navigation.PopAsync();
        }
        private void Limpar()
        {
            txtNome.Text = string.Empty;
            txtTitulo.Text = string.Empty;
        }
    }
}