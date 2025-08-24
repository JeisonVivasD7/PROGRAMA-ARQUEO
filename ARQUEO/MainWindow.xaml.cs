using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ARQUEO;


namespace ARQUEO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CambiarColorContenidoYActivarBotones(object sender,EventArgs e)
        {
            Contenido.Background = new SolidColorBrush(Colors.White);
            BotonImprimir.IsEnabled = true;
            botonGuardar.IsEnabled = true;
        }
        private void CrearPlantillaArqueo(object sender, RoutedEventArgs e)
        {
            Contenido.Children.Clear();
            var nuevoArqueo = new NuevoArqueo();
            Contenido.Children.Add(nuevoArqueo);
            MessageBox.Show("Plantilla de arqueo creada.");
        }







    }
}