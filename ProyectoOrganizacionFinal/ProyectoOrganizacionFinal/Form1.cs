using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOrganizacionFinal.Classes;

namespace ProyectoOrganizacionFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resetGame();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetGame();
        }

        public void resetGame()
        {
            sumaResultado.Text = String.Format("");
            convertToBin.Text = String.Format("");
            convertToC2.Text = String.Format("");
            C2ToDecimal.Text = String.Format("");
            BoothTable.DataSource = null;
            input1.Clear();
            input2.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AlgoritmoBooth algoritmobooth = new AlgoritmoBooth();
                //Classes

                //Inputs
                int dec1 = Convert.ToInt32(int.Parse(input1.Text));
                int dec2 = Convert.ToInt32(int.Parse(input2.Text));

                string bin1 = DecimalToBinary.Dec_to_bin(dec1);
                string bin2 = DecimalToBinary.Dec_to_bin(dec2);

                int l1 = bin1.Length, l2 = bin2.Length;

                if (bin1.Length > bin2.Length)
                {
                    for (int i = 1; i <= l1 - l2; i++)
                        bin2 = (bin2[0] == '+') ? bin2.Remove(0, 1).Insert(0, "+0") : bin2.Remove(0, 1).Insert(0, "-0");
                }

                if (bin2.Length > bin1.Length)
                {
                    for (int i = 1; i <= l2 - l1; i++)
                        bin1 = (bin1[0] == '+') ? bin1.Remove(0, 1).Insert(0, "+0") : bin1.Remove(0, 1).Insert(0, "-0");
                }

                sumaResultado.Text = String.Format("La multiplicación de {0} y {1} es = {2}", dec1, dec2, (dec1 * dec2));
                convertToBin.Text = String.Format("Los numeros convertidos a binario son:  {0} y {1}", bin1, bin2);
                convertToC2.Text = String.Format("Los numeros convertidos a Complemento a 2 son:  {0} y {1}", Complement2.Bin_to_C2(bin1), Complement2.Bin_to_C2(bin2));

                string a = algoritmobooth.Booth(bin1, bin2);

                BoothTable.DataSource = algoritmobooth.BoothTable;

                C2ToDecimal.Text = String.Format("El resultado en Decimal es: {0}", Complement2.C2_to_dec(a));
            }
            catch(System.OverflowException)
            {
                MessageBox.Show("El valor es demasiado alto");
                resetGame();
            }
            catch(FormatException)
            {
                MessageBox.Show("El formato introducido no es valido");
                resetGame();
            }
           
     
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}
