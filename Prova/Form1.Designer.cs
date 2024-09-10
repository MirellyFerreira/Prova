namespace Prova
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.lblvenda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnremover = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.dgvmercado = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtAlterar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmercado)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(112, 33);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Venda:";
            // 
            // lblvenda
            // 
            this.lblvenda.AutoSize = true;
            this.lblvenda.Location = new System.Drawing.Point(188, 33);
            this.lblvenda.Name = "lblvenda";
            this.lblvenda.Size = new System.Drawing.Size(13, 13);
            this.lblvenda.TabIndex = 1;
            this.lblvenda.Text = "0";
            this.lblvenda.Click += new System.EventHandler(this.lblvenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produto:";
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(191, 74);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(329, 20);
            this.txtproduto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor unitário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // txtquant
            // 
            this.txtquant.Location = new System.Drawing.Point(191, 115);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(100, 20);
            this.txtquant.TabIndex = 7;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(191, 157);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 8;
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(440, 115);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(91, 62);
            this.btnremover.TabIndex = 9;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(332, 115);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(92, 62);
            this.btninserir.TabIndex = 10;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // dgvmercado
            // 
            this.dgvmercado.AllowUserToAddRows = false;
            this.dgvmercado.AllowUserToDeleteRows = false;
            this.dgvmercado.AllowUserToOrderColumns = true;
            this.dgvmercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmercado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.VUnitario});
            this.dgvmercado.Location = new System.Drawing.Point(118, 215);
            this.dgvmercado.Name = "dgvmercado";
            this.dgvmercado.ReadOnly = true;
            this.dgvmercado.Size = new System.Drawing.Size(413, 158);
            this.dgvmercado.TabIndex = 11;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // VUnitario
            // 
            this.VUnitario.HeaderText = "V.Unitário";
            this.VUnitario.Name = "VUnitario";
            this.VUnitario.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total da venda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Alterar quantidade do item selecionado:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(214, 459);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(422, 532);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(82, 44);
            this.btnFinalizar.TabIndex = 15;
            this.btnFinalizar.Text = "Finalizar sistema";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(320, 532);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 44);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar venda";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(217, 532);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(88, 44);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "Gravar venda";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(456, 404);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 34);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar quantidade";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtAlterar
            // 
            this.txtAlterar.Location = new System.Drawing.Point(320, 411);
            this.txtAlterar.Name = "txtAlterar";
            this.txtAlterar.Size = new System.Drawing.Size(130, 20);
            this.txtAlterar.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.txtAlterar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvmercado);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblvenda);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmercado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblvenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.DataGridView dgvmercado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn VUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtAlterar;
    }
}

