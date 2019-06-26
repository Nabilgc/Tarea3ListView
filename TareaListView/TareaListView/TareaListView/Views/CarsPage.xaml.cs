using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaListView.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaListView.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarsPage : ContentPage
    {

        public CarsPage()
        {

            InitializeComponent();

            // Connecting context of this page to the our View Model class
            BindingContext = new CarsViewModel();
        }
    }
}