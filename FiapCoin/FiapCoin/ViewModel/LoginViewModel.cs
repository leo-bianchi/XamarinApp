using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace FiapCoin.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        public ICommand BotaoEntrarCommand { get; set; }

        public ICommand BotaoSairCommand { get; set; }

        public LoginViewModel()
        {
            BotaoEntrarCommand = new Command( () => {
                MessagingCenter.Send<String>("", "LoginSucesso");
            });

            BotaoSairCommand = new Command(() => {
                App.Current.MainPage.DisplayAlert("Teste", "Saindo...", "OK");
            });
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set
            {
                if (usuario != value)
                {
                    usuario = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string senha;
        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                if (senha != value)
                {
                    senha = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
