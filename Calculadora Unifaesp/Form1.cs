using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Unifaesp
{
    public partial class Form1 : Form
    {
        //Variáveis globais
        double entrada01;
        double entrada02;
        char operacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "1"; // Concatenar 1
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (visor.Text != "0")
                visor.Text += "0"; // Concatenar 0
        }

        private void button20_Click(object sender, EventArgs e)
        {
            visor.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacao = '+';
            entrada01 = double.Parse(visor.Text);
            visor.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            entrada02 = double.Parse(visor.Text);
            switch(operacao)
            {
                case '+':
                    double soma = entrada01 + entrada02;
                    visor.Text = soma.ToString();
                    break;

                case '-':
                    double subtracao = entrada01 - entrada02;
                    visor.Text = subtracao.ToString();
                    break;

                case 'X':
                    double multiplicacao = entrada01 * entrada02;
                    visor.Text = multiplicacao.ToString();
                    break;

                case '/':
                    double divisao = entrada01 / entrada02;
                    visor.Text = divisao.ToString();
                    break;

                default:
                    break;
                   
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            operacao = '-';
            entrada01 = double.Parse(visor.Text);
            visor.Text = "0";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacao = '/';
            entrada01 = double.Parse(visor.Text);
            visor.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operacao = 'x';
            entrada01 = double.Parse(visor.Text);
            visor.Text = "0";
        }
    }
}
