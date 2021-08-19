using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Completa
{
    
    public partial class Form1 : Form
    {
        Calculadora calc = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calc.atualizarDisplay(button_6.Text);
            TextDown.Text = calc.resultado;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calc.atualizarDisplay(button_4.Text);
            TextDown.Text = calc.resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calc.atualizarDisplay(button_2.Text);
            TextDown.Text = calc.resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc.atualizarDisplay(button_1.Text);
            TextDown.Text = calc.resultado;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calc.atualizarDisplay(button_8.Text);
            TextDown.Text = calc.resultado;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calc.atualizarDisplay(button_7.Text);
            TextDown.Text = calc.resultado;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calc.atualizarDisplay(button_5.Text);
            TextDown.Text = calc.resultado;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calc.atualizarDisplay(button_9.Text);
            TextDown.Text = calc.resultado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_7.BackColor = Color.FromArgb(1, 28, 75, 120);
            button_8.BackColor = Color.FromArgb(0, 28, 75, 120);
            button_9.BackColor = Color.FromArgb(0, 28, 75, 120);
            button_4.BackColor = Color.FromArgb(0, 28, 75, 120);
            button_5.BackColor = Color.FromArgb(0, 28, 75, 120);
            button_6.BackColor = Color.FromArgb(0, 28, 75, 120);
            button_1.BackColor = Color.FromArgb(0, 28, 75, 120);
            button_2.BackColor = Color.FromArgb(0, 28, 75, 120);
            button_3.BackColor = Color.FromArgb(0, 28, 75, 120);
            button_zero.BackColor = Color.FromArgb(0, 28, 75, 120);
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            calc.atualizarDisplay(button_3.Text);
            TextDown.Text = calc.resultado;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            calc.atualizarDisplay(button_zero.Text);
            TextDown.Text = calc.resultado;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            calc.operacaoAri(button_ADD.Text);
            TextUp.Text = calc.TextUp;
            TextDown.Text = calc.TextDown;
            labelOperation.Text = calc.operacao;
        }

        private void buttonSUB_Click(object sender, EventArgs e)
        {
            calc.operacaoAri(button_SUB.Text);
            TextUp.Text = calc.TextUp;
            TextDown.Text = calc.TextDown;
            labelOperation.Text = calc.operacao;
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            calc.operacaoAri(button_DIV.Text);
            TextUp.Text = calc.TextUp;
            TextDown.Text = calc.TextDown;
            labelOperation.Text = calc.operacao;
        }

        private void buttonMUL_Click(object sender, EventArgs e)
        {
            calc.operacaoAri(button_MUL.Text);
            TextUp.Text = calc.TextUp;
            TextDown.Text = calc.TextDown;
            labelOperation.Text = calc.operacao;
        }

        private void buttonEqual_CLICK(object sender, EventArgs e)
        {
            calc.computador();
            TextDown.Text = calc.TextUp;
            TextUp.Text = "0";
            labelOperation.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            calc.Limpar();
            TextDown.Text = calc.TextDown;
            TextUp.Text = calc.TextUp;
            labelOperation.Text = "";
        }
    }
}
