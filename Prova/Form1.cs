using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova

{
    public partial class Form1 : Form

    {
        double Totall;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvmercado.RowCount = 0;

            lblvenda.Text = dgvmercado.RowCount.ToString();

            lblTotal.Text = dgvmercado.RowCount.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(txtAlterar.Text != "")
            {
                dgvmercado.CurrentRow.Cells[0].Value = txtAlterar.Text;

                MessageBox.Show("Quantidade do produto alterado com sucesso", "Exclusão",
                                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                  
            }
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            if (dgvmercado.RowCount > 0)
            {
                dgvmercado.Rows.RemoveAt(dgvmercado.CurrentCell.RowIndex);

                MessageBox.Show("Produto excluído com sucesso!", "Exclusão",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                lblTotal.Text=dgvmercado.RowCount.ToString();   
            }
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            double quantidade = double.Parse(txtquant.Text);
            double valor = double.Parse(txtvalor.Text);
            dgvmercado.Rows.Add(txtproduto.Text, txtquant.Text, txtvalor.Text);
           
            Totall += quantidade * valor;
            lblTotal.Text = Totall.ToString("C");

            dgvmercado.Rows.Add(txtproduto.Text, txtquant.Text, txtvalor.Text);
            txtproduto.Clear();
            txtquant.Clear();
            txtvalor.Clear();

            MessageBox.Show("Produto cadastrado com sucesso !", "Inclusão",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            lblvenda.Text = dgvmercado.RowCount.ToString();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            dgvmercado.RowCount = 0;
            lblTotal.Text = dgvmercado.RowCount.ToString();
        }

        private void lblvenda_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
           
        }
    }
}
