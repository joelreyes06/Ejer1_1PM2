using Ejer1PM2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejer1PM2
{
    
    public partial class MainPage : ContentPage
    {

        Operaciones operaciones;
        public MainPage()
        {
            InitializeComponent();
            operaciones = new Operaciones();
        }


        private void btnsuma_Clicked(object sender, EventArgs e)
        {
            operaciones.Num1 = double.Parse(n1.Text);
            operaciones.Num2 = double.Parse(n2.Text);


            var resultado = operaciones.Suma();
            Navigation.PushAsync(new Views.Page_Two(resultado.ToString()));
        }

        private void btnresta_Clicked(object sender, EventArgs e)
        {
            operaciones.Num1 = double.Parse(n1.Text);
            operaciones.Num2 = double.Parse(n2.Text);


            var resultado = operaciones.Resta();
            Navigation.PushAsync(new Views.Page_Two(resultado.ToString()));

        }

        private void btndivi_Clicked(object sender, EventArgs e)
        {

            operaciones.Num1 = double.Parse(n1.Text);
            operaciones.Num2 = double.Parse(n2.Text);


            var resultado = operaciones.Division();
            Navigation.PushAsync(new Views.Page_Two(resultado.ToString()));
        }

        private void btnmuti_Clicked(object sender, EventArgs e)
        {
            operaciones.Num1 = double.Parse(n1.Text);
            operaciones.Num2 = double.Parse(n2.Text);


            var resultado = operaciones.Multiplicacion();
            Navigation.PushAsync(new Views.Page_Two(resultado.ToString()));
        }
    }
}
