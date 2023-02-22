using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejer1PM2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Two : ContentPage
    {
        public Page_Two()
        {
        }

        public Page_Two(string resultado)
        {
            InitializeComponent();
            lblResultado.Text = "El resultado es:"+ resultado;
        }
    }
}