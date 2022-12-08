using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmFruta : Form
    {
        public frmFruta()
        {
            InitializeComponent();
        }

        private void btbSelecionar_Click(object sender, EventArgs e)
        {
            int operador;
            string frutas = "";

            operador = int.Parse(txtDigiteaFruta.Text);

            switch (operador)
            {
                case 1: frutas = "Banana";
                    break;

                case 2: frutas = "Maça";
                    break;

                case 3:
                    frutas = "Pera";
                    break;
                case 4:
                    frutas = "Melancia";
                    break;
                default: frutas = "Nenhuma fruta selecionada";
                    break;
            }
            txtSelecione.Text = frutas;

            txtDigiteaFruta.Text = "";
            txtDigiteaFruta.Focus();

        }

        private void btbLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        //CRiando o método para limprar os campos
        public void LimparCampos()
        {
            txtDigiteaFruta.Clear();
            ltbFrutas.Items.Clear();

            cbbFrutasListadas.Items.Clear();

            txtSelecione.Text = "";
            cbbFrutasListadas.Text = "";

            txtDigiteaFruta.Focus();

        }
        private void btbInserir_Click(object sender, EventArgs e)
        {
            ltbFrutas.Items.Clear();
            ltbFrutas.Items.Add(txtSelecione.Text);

            cbbFrutasListadas.Items.Clear();
            cbbFrutasListadas.Items.Add(txtSelecione.Text);
           
        }
        private void btbSair_Click(object sender, EventArgs e)
        {
            DialogResult res;

            res = MessageBox.Show("Deseja Sair", "Mensagem do Siatema", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation, 
                MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes)
            {
                Application.Exit(); //Fecha todas as Tarefas
            }
            else
            {
                LimparCampos();
            }

        }

        private void txtDigiteaFruta_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                btbSelecionar.Focus();
            }

        }
    }
}
