using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula08_Ex02_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //variavel publica global
        public double Num_dig;
        public double acum_total;
        public string ultimo_operador = " ";        
        public double Transf_Num1;
        public double resultado;


        Class_Adicao adicionar = new Class_Adicao();

        private void button1_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;

            if (ultimo_operador != "Igual" || ultimo_operador=="Adicionar")
            {
                                
                num1 = Convert.ToDouble(textBox1.Text);
               Num_dig = num1;
                label1.Text = Convert.ToString(Num_dig);
                ultimo_operador = "Adicionar";
                textBox1.Text = String.Empty;
                textBox1.Focus();
                num2 = Num_dig;
                acum_total = adicionar.somar(acum_total, Num_dig);
                label2.Text = Convert.ToString(acum_total);
                ultimo_operador = "Adicionar";
            }
            else if (ultimo_operador =="Igual")
            {
               
                num1 = Convert.ToDouble(textBox1.Text);
                label1.Text = Convert.ToString(Num_dig);
                Num_dig=num1;
                ultimo_operador = "Igual";
                acum_total = num1;
                label2.Text = Convert.ToString (acum_total);
                textBox1.Focus();
                textBox1.Text = string.Empty;                
                num2 = Num_dig;
                ultimo_operador = "Adicionar";                
            }                   
        }

        Class_Multiplicacao Multiplica = new Class_Multiplicacao();
        private void button3_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;

            if (ultimo_operador != "Igual" || ultimo_operador == "Multiplicar")
            {

                num1 = Convert.ToDouble(textBox1.Text);
                Num_dig = num1;
                label1.Text = Convert.ToString(Num_dig);
                ultimo_operador = "Multiplicar";
                textBox1.Text = String.Empty;
                textBox1.Focus();
                num2 = Num_dig;
                acum_total = Multiplica.multiplicar(acum_total, Num_dig);
                label2.Text = Convert.ToString(acum_total);
                ultimo_operador = "Multiplicar";
            }
            else if (ultimo_operador == "Igual")
            {

                num1 = Convert.ToDouble(textBox1.Text);
                label1.Text = Convert.ToString(Num_dig);
                Num_dig = num1;
                ultimo_operador = "Multiplicar";
                acum_total = num1;
                label2.Text = Convert.ToString(acum_total);
                textBox1.Focus();
                textBox1.Text = string.Empty;
                num2 = Num_dig;
                ultimo_operador = "Multiplicar";
            }

        }

        Class_Divisao divide = new Class_Divisao();
        private void button4_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
           
            if (ultimo_operador != "Igual" || ultimo_operador == "Dividir")
            {

                num1 = Convert.ToDouble(textBox1.Text);
                Num_dig = num1;
                label1.Text = Convert.ToString(Num_dig);
                ultimo_operador = "Dividir";
                textBox1.Text = String.Empty;
                textBox1.Focus();
                num2 = Num_dig;
                acum_total = divide.dividir(acum_total, Num_dig);
                label2.Text = Convert.ToString(acum_total);
                ultimo_operador = "Dividir";
            }
            else if (ultimo_operador == "Igual")
            {

                num1 = Convert.ToDouble(textBox1.Text);
                label1.Text = Convert.ToString(Num_dig);
                Num_dig = num1;
                ultimo_operador = "Igual";
                acum_total = num1;
                label2.Text = Convert.ToString(acum_total);
                textBox1.Focus();
                textBox1.Text = string.Empty;
                num2 = Num_dig;
                ultimo_operador = "Dividir";
            }
        }
            

        Class_Subtracao Subtrai = new Class_Subtracao();
        private void button2_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;

            if (ultimo_operador != "Igual" || ultimo_operador == "Subtrair")
            {

                num1 = Convert.ToDouble(textBox1.Text);
                Num_dig = num1;
                label1.Text = Convert.ToString(Num_dig);
                ultimo_operador = "Subtrair";
                textBox1.Text = String.Empty;
                textBox1.Focus();
                num2 = Num_dig;
                acum_total = Subtrai.subtrair(acum_total, Num_dig);
                label2.Text = Convert.ToString(acum_total);
                ultimo_operador = "Subtrair";
            }
            else if (ultimo_operador == "Igual")
            {

                num1 = Convert.ToDouble(textBox1.Text);
                label1.Text = Convert.ToString(Num_dig);
                Num_dig = num1;
                ultimo_operador = "Igual";
                acum_total = num1;
                label2.Text = Convert.ToString(acum_total);
                textBox1.Focus();
                textBox1.Text = string.Empty;
                num2 = Num_dig;
                ultimo_operador = "Subtrair";
            }

        }

        Class_Igual iguala = new Class_Igual();
        private void button5_Click(object sender, EventArgs e)
        {
            double Result;
            double n1;
            double n2;
            label3.Text = ultimo_operador;            
            if (ultimo_operador == "Adicionar")
            {
                n1 = acum_total;
                n2 = Convert.ToDouble(textBox1.Text);
                Result = adicionar.somar(n1, n2);
                textBox1.Text = Convert.ToString(Result);
                ultimo_operador = "Adicionar";
                
            }
            else if (ultimo_operador == "Multiplicar")
            {
                n1 = acum_total;
                n2 = Convert.ToDouble(textBox1.Text);
                Result = Multiplica.multiplicar(n1, n2);
                textBox1.Text = Convert.ToString(Result);
                ultimo_operador = "Multiplicar";

            }
            else if (ultimo_operador == "Dividir")
            {
                n1 = acum_total;
                n2 = Convert.ToDouble(textBox1.Text);
                Result = divide.dividir(n1, n2);
                textBox1.Text = Convert.ToString(Result);
                ultimo_operador = "Dividir";

            }
            else if (ultimo_operador == "Subtrair")
            {
                n1 = acum_total;
                n2 = Convert.ToDouble(textBox1.Text);
                Result = Subtrai.subtrair(n1, n2);
                textBox1.Text = Convert.ToString(Result);
                ultimo_operador = "Subtrair";

            }
            ultimo_operador = "Igual";
            label3.Text = ultimo_operador;
        }
    }
}
