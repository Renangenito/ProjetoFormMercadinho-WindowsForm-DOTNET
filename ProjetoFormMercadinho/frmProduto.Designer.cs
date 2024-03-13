namespace ProjetoFormMercadinho
{
    partial class frmProduto
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lblDataInclusao = new System.Windows.Forms.Label();
            this.lblDataAlteracao = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbbAtivo = new System.Windows.Forms.ComboBox();
            this.mskDataInclusao = new System.Windows.Forms.MaskedTextBox();
            this.mskDataAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(39, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 21);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.Location = new System.Drawing.Point(281, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 21);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorUnitario.Location = new System.Drawing.Point(39, 106);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(109, 21);
            this.lblValorUnitario.TabIndex = 3;
            this.lblValorUnitario.Text = "Valor Unitário:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(513, 26);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 21);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAtivo.Location = new System.Drawing.Point(39, 192);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(49, 21);
            this.lblAtivo.TabIndex = 6;
            this.lblAtivo.Text = "Ativo:";
            // 
            // lblDataInclusao
            // 
            this.lblDataInclusao.AutoSize = true;
            this.lblDataInclusao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataInclusao.Location = new System.Drawing.Point(281, 106);
            this.lblDataInclusao.Name = "lblDataInclusao";
            this.lblDataInclusao.Size = new System.Drawing.Size(106, 21);
            this.lblDataInclusao.TabIndex = 4;
            this.lblDataInclusao.Text = "Data Inclusão:";
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataAlteracao.Location = new System.Drawing.Point(513, 106);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(114, 21);
            this.lblDataAlteracao.TabIndex = 5;
            this.lblDataAlteracao.Text = "Data Alteração:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(39, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(195, 29);
            this.txtId.TabIndex = 7;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorUnitario.Location = new System.Drawing.Point(39, 130);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(195, 29);
            this.txtValorUnitario.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(281, 49);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(195, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.Location = new System.Drawing.Point(513, 49);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(195, 29);
            this.txtDescricao.TabIndex = 12;
            // 
            // cbbAtivo
            // 
            this.cbbAtivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbAtivo.FormattingEnabled = true;
            this.cbbAtivo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbbAtivo.Location = new System.Drawing.Point(39, 217);
            this.cbbAtivo.Name = "cbbAtivo";
            this.cbbAtivo.Size = new System.Drawing.Size(195, 29);
            this.cbbAtivo.TabIndex = 13;
            this.cbbAtivo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mskDataInclusao
            // 
            this.mskDataInclusao.Enabled = false;
            this.mskDataInclusao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskDataInclusao.Location = new System.Drawing.Point(281, 130);
            this.mskDataInclusao.Mask = "00/00/0000 90:00:00";
            this.mskDataInclusao.Name = "mskDataInclusao";
            this.mskDataInclusao.Size = new System.Drawing.Size(193, 29);
            this.mskDataInclusao.TabIndex = 14;
            this.mskDataInclusao.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataAlteracao
            // 
            this.mskDataAlteracao.Enabled = false;
            this.mskDataAlteracao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskDataAlteracao.Location = new System.Drawing.Point(513, 130);
            this.mskDataAlteracao.Mask = "00/00/0000 90:00:00";
            this.mskDataAlteracao.Name = "mskDataAlteracao";
            this.mskDataAlteracao.Size = new System.Drawing.Size(193, 29);
            this.mskDataAlteracao.TabIndex = 15;
            this.mskDataAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(279, 192);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(427, 54);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(780, 279);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mskDataAlteracao);
            this.Controls.Add(this.mskDataInclusao);
            this.Controls.Add(this.cbbAtivo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblDataAlteracao);
            this.Controls.Add(this.lblDataInclusao);
            this.Controls.Add(this.lblAtivo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Label lblDataInclusao;
        private System.Windows.Forms.Label lblDataAlteracao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbbAtivo;
        private System.Windows.Forms.MaskedTextBox mskDataInclusao;
        private System.Windows.Forms.MaskedTextBox mskDataAlteracao;
        private System.Windows.Forms.Button btnSalvar;
    }
}