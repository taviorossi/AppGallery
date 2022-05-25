﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controle.SelecaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Selecao : ContentPage
    {
        public Selecao()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInformativo.Text = ((Picker)sender).SelectedIndex + " - " + ((Picker)sender).SelectedItem;
        }

        private void LimparPickerMarca(object sender, EventArgs e)
        {
            PickerMarca.SelectedIndex = -1;
        }
    }
}