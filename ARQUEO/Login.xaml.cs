using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ARQUEO
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
               
        private void ButtonLogin(object sender, RoutedEventArgs e)
        {
            //Estoy validando que los campos no estén vacíos y que el ID sea un numero entero
            //y estoy dejando el texto en mayúsculas y sin espacios al inicio ni al final            
            string Nombre = NombreArqueo.Text.ToUpper().Trim();
            string IDtexto = IDarqueador.Text.Trim();
            int ID;
            //Aquí estoy validando que Nombre no sea NULL o Vacio, y que ID si sea un numero entero
            if (string.IsNullOrEmpty(Nombre) || !int.TryParse(IDtexto, out ID) && (ID >= 6 || ID <= 11))
            {
                MessageBox.Show("Por favor, complete todos los campos\n" +
                    "y verifique los datos ingresados.");

            }
            //Aquí invoco a mainwindow que sera nuestra ventana principal, y a su vez cierro login
            else
            {
                MessageBox.Show($"Encargado: {Nombre}\nID: {ID}");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }                
        }
       
    }  

       
}

      