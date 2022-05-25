using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.TableControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Table : ContentPage
    {
        public Table()
        {
            InitializeComponent();
        }

        private void TextCell_Tapped(object sender, EventArgs e)
        {
            ((TextCell)sender).Text += "(Clicado!)";
        }
    }
}