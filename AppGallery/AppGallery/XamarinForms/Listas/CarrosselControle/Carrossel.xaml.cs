using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.CarrosselControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrossel : ContentPage
    {
        private ObservableCollection<Colaborador> colaboradores { get; set; }
        public Carrossel()
        {
            InitializeComponent();

            colaboradores = GetColaboradores();
            Carrossel01.ItemsSource = colaboradores;
        }

        private ObservableCollection<Colaborador> GetColaboradores()
        {
            return new ObservableCollection<Colaborador>()
            {
                new Colaborador(){ Nome = "João Ribeio", Cargo = "WebDesigner", Descricao = "Sou Web Designer desde de 2010. Conheço CSS, HTML, Photoshop, AdobeXD, Adobe Illustrator e 3D MAX" },
                new Colaborador(){ Nome = "Felipe Rodrigues", Cargo = "Programador", Descricao = "Sou programador java desde de 2010. Trabalhei com JSF, JSP, Java EE, HTML e CSS." },
                new Colaborador(){ Nome = "José Ribeio", Cargo = "Programador Web", Descricao = "Sou programador web desde de 2010. Conheço PHP, Frameworks como Laravel, Codeignite e Zend Framework." },
                new Colaborador(){ Nome = "Marcos Ribeio", Cargo = "Programador PHP", Descricao = "Sou programador web desde de 2010. Conheço PHP, Frameworks como Laravel, Codeignite e Zend Framework." },
            };
        }

        private void Carrossel01_RemainingItemsThresholdReached(object sender, EventArgs e)
        {

            colaboradores.Add(new Colaborador() { Nome = "Emanuel Strongarm", Cargo = "WebDesigner", Descricao = "Sou Web Designer desde de 2010. Conheço CSS, HTML, Photoshop, AdobeXD, Adobe Illustrator e 3D MAX" });
            colaboradores.Add(new Colaborador() { Nome = "Madalena aushwitz", Cargo = "WebDesigner", Descricao = "Sou Web Designer desde de 2010. Conheço CSS, HTML, Photoshop, AdobeXD, Adobe Illustrator e 3D MAX" });
            colaboradores.Add(new Colaborador() { Nome = "sun tzu", Cargo = "WebDesigner", Descricao = "Sou Web Designer desde de 2010. Conheço CSS, HTML, Photoshop, AdobeXD, Adobe Illustrator e 3D MAX" });

            Carrossel01.RemainingItemsThreshold = -1;
        }

        private void Carrossel01_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            var colaborador = (Colaborador)e.CurrentItem;
            lblItem.Text = "Nome: " + colaborador.Nome;
        }

        private void Carrossel01_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            lblPosition.Text = "Posição" + e.CurrentPosition + " - Posição anterior: " + e.PreviousPosition;
        }

        private void Carrossel01_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            lblScroll.Text = "ScrollX: " + e.HorizontalOffset;
        }
    }

    public class Colaborador
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }
    }
}