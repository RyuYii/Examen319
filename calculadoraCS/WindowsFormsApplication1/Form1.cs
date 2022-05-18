using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double aux1, aux2;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }
        classes.ClaseOperaciones operacion = new classes.ClaseOperaciones();
        private void restart()
        {
            T1.Text = "0";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            T1.Text = "0";
            operation.Text = "";
        }
        private void btnPor_Click(object sender, EventArgs e)
        {
            operador = "*";
            operation.Text = "PROD";
            aux1 = double.Parse(T1.Text);
            T1.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            operation.Text = "RESTA";
            aux1 = double.Parse(T1.Text);
            T1.Clear();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operador = "+";
            operation.Text = "SUMA";
            aux1 = double.Parse(T1.Text);
            T1.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            operation.Text = "DIV";
            aux1 = double.Parse(T1.Text);
            T1.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            aux2 = double.Parse(T1.Text);
            operation.Text = "RESULTADO";
            double OPSuma;
            switch (operador)
            {
                case "+":
                    OPSuma = operacion.Sumas(aux1, aux2);
                    T1.Text = OPSuma.ToString();
                    break;
                case "-":
                    OPSuma = operacion.Restas(aux1, aux2);
                    T1.Text = OPSuma.ToString();
                    break;
                case "/":
                    OPSuma = operacion.Division(aux1, aux2);
                    T1.Text = OPSuma.ToString();
                    break;
                case "*":
                    OPSuma = operacion.Multiplicacion(aux1, aux2);
                    T1.Text = OPSuma.ToString();
                    break;
                case "**":
                    OPSuma = operacion.Cuadrado(double.Parse(T1.Text));
                    T1.Text = OPSuma.ToString();
                    break;
                case "*/":
                    OPSuma = operacion.Raiz(double.Parse(T1.Text));
                    T1.Text = OPSuma.ToString();
                    break;
                case "1/":
                    OPSuma = operacion.inversoMultiplicativo(double.Parse(T1.Text));
                    T1.Text = OPSuma.ToString();
                    break;
                case "%":
                    OPSuma = operacion.Modulo(double.Parse(T1.Text));
                    T1.Text = OPSuma.ToString();
                    break;
                default:
                    return;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (T1.Text.Equals("0")) T1.Text = "";
            T1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (T1.Text.Equals("0")) T1.Text = "";
            T1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (T1.Text.Equals("0")) T1.Text = "";
            T1.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (T1.Text.Equals("0")) T1.Text = "";
            T1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (T1.Text.Equals("0")) T1.Text = "";
            T1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (T1.Text.Equals("0")) T1.Text = "";
            T1.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (T1.Text.Equals("0")) T1.Text = "";
            T1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (T1.Text.Equals("0")) T1.Text = "";
            T1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (T1.Text.Equals("0")) T1.Text = "";
            T1.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (T1.Text.Equals("0")) T1.Text = "";
            T1.Text += "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!T1.Text.Contains(".")) {
                T1.Text += ".";
            }
        }

        private void btnCambioSigno_Click(object sender, EventArgs e)
        {
            if (T1.Text[0] == '-')
            {
                T1.Text = T1.Text.Replace("-", "");
            }
            else {
                T1.Text = "-" + T1.Text;
            }
        }



        private void button18_Click(object sender, EventArgs e)
        {
            operation.Text = "";
            T1.Text = "0";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            operation.Text = "CUADRADO";
            operador = "**";
            if (T1.Text.Equals("0")) T1.Text = "0";
            else
            {
                T1.Text = operacion.Cuadrado(double.Parse(T1.Text)).ToString();
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operation.Text = "RAIZ";
            operador = "*/";
            if (T1.Text.Equals("0")) T1.Text = "0";
            else
            {
                T1.Text = operacion.Raiz(double.Parse(T1.Text)).ToString();
            }
        }

        private void btnInverso_Click(object sender, EventArgs e)
        {
            operation.Text = "INVERSO";
            operador = "1/";
            if (T1.Text.Equals("0")) T1.Text = "0";
            else
            {
                T1.Text = operacion.inversoMultiplicativo(double.Parse(T1.Text)).ToString();
            }
        }

        private void btnporc_Click(object sender, EventArgs e)
        {
            operation.Text = "%";
            operador = "%";
            if (T1.Text.Equals("0")) T1.Text = "0";
            else
            {
                T1.Text = operacion.Modulo(double.Parse(T1.Text)).ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (T1.Text.Length < 2) { T1.Text = ""; return; }
            T1.Text = T1.Text.Substring(0, T1.Text.Length - 1);
            if (T1.Text.Length < 2) {  return; }
            if (T1.Text[T1.Text.Length - 1] == '.')
            {
                T1.Text = T1.Text.Substring(0, T1.Text.Length - 1);
            }
        }
    }
}
