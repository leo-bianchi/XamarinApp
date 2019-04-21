using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FiapCoin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPage : MasterDetailPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Abrindo tela de Contato
            MessagingCenter.Subscribe<ContatoPage>(this, 
                    "ContatoPageAbrir",
                    (sender) =>
                    {
                        this.Detail = new NavigationPage(new ContatoPage());
                        this.IsPresented = false;
                    });


            // Abrindo tela de QuemSomos
            MessagingCenter.Subscribe<QuemSomosPage>(this, "QuemSomosPageAbrir",
                (sender) =>
                {
                    this.Detail = new NavigationPage(new QuemSomosPage());
                    this.IsPresented = false;
                });
        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<ContatoPage>(this, "ContatoPageAbrir");
            MessagingCenter.Unsubscribe<QuemSomosPage>(this, "ContatoPageAbrir");
        }
    }
}