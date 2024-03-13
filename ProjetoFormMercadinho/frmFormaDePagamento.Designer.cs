namespace ProjetoFormMercadinho
{
    partial class frmFormaDePagamento
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
            this.cbbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbFormaPagamento
            // 
            this.cbbFormaPagamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbFormaPagamento.FormattingEnabled = true;
            this.cbbFormaPagamento.Items.AddRange(new object[] {
            "Credito",
            "Debito",
            "Dinheiro",
            "PIX"});
            this.cbbFormaPagamento.Location = new System.Drawing.Point(39, 53);
            this.cbbFormaPagamento.Name = "cbbFormaPagamento";
            this.cbbFormaPagamento.Size = new System.Drawing.Size(179, 29);
            this.cbbFormaPagamento.TabIndex = 0;
            this.cbbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbbFormaPagamento_SelectedIndexChanged);
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormaPagamento.Location = new System.Drawing.Point(39, 31);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(154, 20);
            this.lblFormaPagamento.TabIndex = 1;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // frmFormaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(269, 208);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.cbbFormaPagamento);
            this.Name = "frmFormaDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFormaDePagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbFormaPagamento;
        private System.Windows.Forms.Label lblFormaPagamento;
    }
}