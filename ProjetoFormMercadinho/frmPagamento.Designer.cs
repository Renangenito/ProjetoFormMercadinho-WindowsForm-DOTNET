namespace ProjetoFormMercadinho
{
    partial class frmPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.lblSaldoDevedor = new System.Windows.Forms.Label();
            this.txtSaldoDevedor = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCompra.Location = new System.Drawing.Point(21, 14);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(123, 20);
            this.lblTotalCompra.TabIndex = 0;
            this.lblTotalCompra.Text = "Total da Compra:";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalCompra.Location = new System.Drawing.Point(21, 37);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(182, 29);
            this.txtTotalCompra.TabIndex = 1;
            this.txtTotalCompra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTroco.Location = new System.Drawing.Point(21, 187);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(182, 29);
            this.txtTroco.TabIndex = 3;
            this.txtTroco.Text = "0,00";
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDinheiro.Location = new System.Drawing.Point(21, 65);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(69, 20);
            this.lblDinheiro.TabIndex = 2;
            this.lblDinheiro.Text = "Dinheiro:";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDinheiro.Location = new System.Drawing.Point(21, 87);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(182, 29);
            this.txtDinheiro.TabIndex = 5;
            this.txtDinheiro.Text = "0,00";
            this.txtDinheiro.TextChanged += new System.EventHandler(this.txtDinheiro_TextChanged);
            // 
            // lblSaldoDevedor
            // 
            this.lblSaldoDevedor.AutoSize = true;
            this.lblSaldoDevedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoDevedor.Location = new System.Drawing.Point(21, 115);
            this.lblSaldoDevedor.Name = "lblSaldoDevedor";
            this.lblSaldoDevedor.Size = new System.Drawing.Size(111, 20);
            this.lblSaldoDevedor.TabIndex = 4;
            this.lblSaldoDevedor.Text = "Saldo Devedor:";
            // 
            // txtSaldoDevedor
            // 
            this.txtSaldoDevedor.Enabled = false;
            this.txtSaldoDevedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaldoDevedor.Location = new System.Drawing.Point(21, 137);
            this.txtSaldoDevedor.Name = "txtSaldoDevedor";
            this.txtSaldoDevedor.Size = new System.Drawing.Size(182, 29);
            this.txtSaldoDevedor.TabIndex = 7;
            this.txtSaldoDevedor.Text = "0,00";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTroco.Location = new System.Drawing.Point(21, 165);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(49, 20);
            this.lblTroco.TabIndex = 6;
            this.lblTroco.Text = "Troco:";
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConcluir.Location = new System.Drawing.Point(21, 227);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(182, 38);
            this.btnConcluir.TabIndex = 8;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(234, 283);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.txtSaldoDevedor);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.lblSaldoDevedor);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.lblDinheiro);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.lblTotalCompra);
            this.Name = "frmPagamento";
            this.Text = "frmPagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label lblSaldoDevedor;
        private System.Windows.Forms.TextBox txtSaldoDevedor;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Button btnConcluir;
    }
}