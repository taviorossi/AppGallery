using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controle.campoDeEntradaMultilineControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampoDeEntradaMultiline : ContentPage
    {
        public CampoDeEntradaMultiline()
        {
            InitializeComponent();
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            lblFocus.Text = "Campo focado!";
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            lblUnfocus.Text = "Foco removido do campo";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTextchange.Text = e.NewTextValue + " - " + e.NewTextValue.Length;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            lblComplete.Text = "Preenchimento finalizado!";
        }
    }
}