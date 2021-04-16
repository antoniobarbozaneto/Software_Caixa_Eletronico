using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa_Exercicio_2
{
    public partial class Form1 : Form
    {
        Conta c1;
        public Form1()
        {
            c1 = new Conta();
            
            InitializeComponent();
            txb_Limite.Text = Convert.ToString(100);
            c1.Set_Limite(Convert.ToDouble(txb_Limite.Text));
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            c1.Set_Nome(txb_Nome.Text);
            c1.Set_Cpf(txb_Cpf.Text);
            c1.Set_NumC(Convert.ToInt32(txb_Num.Text));
            c1.Set_NumA(Convert.ToInt32(txb_Agencia.Text));           
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txb_Nome.Text = "";
            txb_Cpf.Text = "";
            txb_Num.Text = "";
            txb_Agencia.Text = "";
            txb_Saldo.Text = "";
        }

        private void btn_Ler_Click(object sender, EventArgs e)
        {
            txb_Nome.Text = c1.Get_Nome();
            txb_Cpf.Text = c1.Get_Cpf();
            txb_Num.Text = Convert.ToString(c1.Get_NumC());
            txb_Agencia.Text = Convert.ToString(c1.Get_NumA());
            txb_Saldo.Text = Convert.ToString(c1.Get_Saldo());
            txb_Limite.Text = Convert.ToString(c1.Get_Limite());
        }

        private void btn_Dep_Click(object sender, EventArgs e)
        {
            c1.Dep(Convert.ToDouble(txb_Valor.Text));
        }

        private void btn_Saq_Click(object sender, EventArgs e)
        {
            c1.Saq(Convert.ToDouble(txb_Valor.Text));
        }
    }
}