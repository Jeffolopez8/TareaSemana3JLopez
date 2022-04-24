using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculodeNotas : ContentView
    {
        public CalculodeNotas()
        {
            InitializeComponent();
        }


        private void txtDatoUno_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDatoDos_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDatoTres_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDatoCuatro_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnResultado_Clicked(object sender, EventArgs e)
        {

        }

        public static implicit operator Page(CalculodeNotas v)
        {
            throw new NotImplementedException();
        }
    }
}