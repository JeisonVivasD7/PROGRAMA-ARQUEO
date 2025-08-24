using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ARQUEO
{
    /// <summary>
    /// Lógica de interacción para NuevoArqueo.xaml
    /// </summary>
    public partial class NuevoArqueo : UserControl
    {
        public NuevoArqueo()
        {
            InitializeComponent();
        }
        //lista de todos los textbox
        public void Lista(object sender, RoutedEventArgs e)
        {
            List<TextBox> Campos = new List<TextBox>();
            Campos.Add(MASTERCARD);
            Campos.Add(VISA);
            Campos.Add(DINNERS);
            Campos.Add(AMERICAN);
            Campos.Add(QR);
            Campos.Add(EFECTIVO);
            Campos.Add(TOTAL_MONEDAS);
            Campos.Add(TOTAL_BILLETES);
            Campos.Add(TOTAL);
            Campos.Add(TOTAL_SISTEMA);
            Campos.Add(DIFERENCIAS);
            Campos.Add(TOTAL_EFECTIVO);
            Campos.Add(moneda50);
            Campos.Add(moneda100);
            Campos.Add(moneda200);
            Campos.Add(moneda500);
            Campos.Add(moneda1000);
            Campos.Add(billete2000);
            Campos.Add(billete5000);
            Campos.Add(billete10000);
            Campos.Add(billete20000);
            Campos.Add(billete50000);
            Campos.Add(billete100000);
            Campos.Add(moneda50total);
            Campos.Add(moneda100total);
            Campos.Add(moneda200total);
            Campos.Add(moneda500total);
            Campos.Add(moneda1000total);
            Campos.Add(billete2000total);
            Campos.Add(billete5000total);
            Campos.Add(billete10000total);
            Campos.Add(billete20000total);
            Campos.Add(billete50000total);
            Campos.Add(billete100000total);
            Campos.Add(GRANTOTAL);

        }
        //tuve que darle formato asi por ahora a los metodos de pago
        //había errores.
        private void FormatoMoneda(object sender, RoutedEventArgs e)
        {

            foreach (TextBox campo in new List<TextBox>
            {
                MASTERCARD, VISA, DINNERS, AMERICAN, QR, EFECTIVO, TOTAL, TOTAL_SISTEMA, DIFERENCIAS
            })
            {
                if (decimal.TryParse(campo.Text, out decimal valor))

                {
                    campo.Text = valor.ToString("C2");
                }
            }
        }
        private void suma_TextChanged(object sender, EventArgs e)
        {
            //ESTUDIAR ESTA PARTE POR QUE COPILOT LA HIZO Y FUNCIONA PERFECTO PERO NO ENTIENDO BIEN POR QUE
            //ADICIONAL REVISAR EL BOTON EN XAML YA QUE FUE UNA PRUEBA PARA VER SI FUNCIONABA APARTE 
            //POR QUE EL EVENTO TEXTCHANGED DISPARABA ERRORES
            //REVISAR LA POSIBILIDAD DE HACERLO CON UN BOTON
            // FALTA LA LOGICA DE LOS DEMAS TEXTBOX Y DEMAS CAMPOS VACIOS 
            TOTAL.Text = (MASTERCARD.Text == string.Empty ? 0 : decimal.Parse(MASTERCARD.Text, NumberStyles.Currency) +
                      (VISA.Text == string.Empty ? 0 : decimal.Parse(VISA.Text, NumberStyles.Currency)) +
                      (DINNERS.Text == string.Empty ? 0 : decimal.Parse(DINNERS.Text, NumberStyles.Currency)) +
                      (AMERICAN.Text == string.Empty ? 0 : decimal.Parse(AMERICAN.Text, NumberStyles.Currency)) +
                      (QR.Text == string.Empty ? 0 : decimal.Parse(QR.Text, NumberStyles.Currency)) +
                      (EFECTIVO.Text == string.Empty ? 0 : decimal.Parse(EFECTIVO.Text, NumberStyles.Currency))
                      ).ToString();

            decimal total = (TOTAL .Text == string.Empty ? 0 : decimal.Parse (TOTAL.Text, NumberStyles.Currency));
            decimal sistema = (TOTAL_SISTEMA.Text == string.Empty ? 0 : decimal.Parse(TOTAL_SISTEMA.Text, NumberStyles.Currency));
            decimal diferencia = total - sistema;
            DIFERENCIAS.Text = diferencia.ToString();      
            

            decimal totalmonedas50 = (moneda50.Text == string.Empty ? 0 :
            decimal.Parse(moneda50.Text));
            decimal valortotalmonedas50 = totalmonedas50 * 50;
            moneda50total.Text = valortotalmonedas50.ToString("C2");
            decimal totalmonedas100 = (moneda100.Text == string.Empty ? 0 :
                decimal.Parse(moneda100.Text));
            decimal valortotalmonedas100 = totalmonedas100 * 100;
            moneda100total.Text = valortotalmonedas100.ToString("C2");
            decimal totalmonedas200 = (moneda200.Text == string.Empty ? 0 :
                decimal.Parse(moneda200.Text));
            decimal valortotalmonedas200 = totalmonedas200 * 200;
            moneda200total.Text = valortotalmonedas200.ToString("C2");
            decimal totalmonedas500 = (moneda500.Text == string.Empty ? 0 :
                decimal.Parse(moneda500.Text));
            decimal valortotalmonedas500 = totalmonedas500 * 500;
            moneda500total.Text = valortotalmonedas500.ToString("C2");
            decimal totalmonedas1000 = (moneda1000.Text == string.Empty ? 0 :
                decimal.Parse(moneda1000.Text));
            decimal valortotalmonedas1000 = totalmonedas1000 * 1000;
            moneda1000total.Text = valortotalmonedas1000.ToString("C2");
            decimal totalbillete2000 = (billete2000.Text == string.Empty ? 0 :
                decimal.Parse(billete2000.Text));
            decimal valortotalbillete2000 = totalbillete2000 * 2000;
            billete2000total.Text = valortotalbillete2000.ToString("C2");
            decimal totalbillete5000 = (billete5000.Text == string.Empty ? 0 :
                decimal.Parse(billete5000.Text));
            decimal valortotalbillete5000 = totalbillete5000 * 5000;
            billete5000total.Text = valortotalbillete5000.ToString("C2");
            decimal totalbillete10000 = (billete10000.Text == string.Empty ? 0 :
                decimal.Parse(billete10000.Text));
            decimal valortotalbillete10000 = totalbillete10000 * 10000;
            billete10000total.Text = valortotalbillete10000.ToString("C2");
            decimal totalbillete20000 = (billete20000.Text == string.Empty ? 0 :
                decimal.Parse(billete20000.Text));
            decimal valortotalbillete20000 = totalbillete20000 * 20000;
            billete20000total.Text = valortotalbillete20000.ToString("C2");
            decimal totalbillete50000 = (billete50000.Text == string.Empty ? 0 :
                decimal.Parse(billete50000.Text));
            decimal valortotalbillete50000 = totalbillete50000 * 50000;
            billete50000total.Text = valortotalbillete50000.ToString("C2");
            decimal totalbillete100000 = (billete100000.Text == string.Empty ? 0 :
                decimal.Parse(billete100000.Text));
            decimal valortotalbillete100000 = totalbillete100000 * 100000;
            billete100000total.Text = valortotalbillete100000.ToString("C2");

            decimal totalmonedas = totalmonedas50 + 
                totalmonedas100 + totalmonedas200 +
                totalmonedas500 + totalmonedas1000;
             
            TOTAL_MONEDAS.Text = totalmonedas.ToString();
            decimal totalbilletes = totalbillete2000 +
                totalbillete5000 + totalbillete10000 
                + totalbillete20000 + totalbillete50000 + 
                totalbillete100000;
            TOTAL_BILLETES.Text = totalbilletes.ToString();
            

            decimal efectivoTotal = valortotalmonedas50 + valortotalmonedas100 + valortotalmonedas200 +
                valortotalmonedas500 + valortotalmonedas1000 + valortotalbillete2000 +
                valortotalbillete5000 + valortotalbillete10000 + valortotalbillete20000 +
                valortotalbillete50000 + valortotalbillete100000;

            EFECTIVO.Text = efectivoTotal.ToString("C2");
            TOTAL_EFECTIVO.Text = efectivoTotal.ToString("C2");

        }

        private void CalcularArqueo(object sender, RoutedEventArgs e)
        {
            
        }
    }
}