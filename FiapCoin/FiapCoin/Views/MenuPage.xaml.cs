using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FiapCoin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}


        public void ContatoClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<ContatoPage>(new ContatoPage(), "ContatoPageAbrir");
        }

        public void QuemSomosClicked(object o, EventArgs e)
        {
            MessagingCenter.
                Send<QuemSomosPage>(
                    new QuemSomosPage(), 
                    "QuemSomosPageAbrir");
        }


    }
}