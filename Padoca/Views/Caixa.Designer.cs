namespace Padoca.Views
{
    partial class Caixa
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
            this.lblNumeroComanda = new System.Windows.Forms.Label();
            this.txbNumeroComanda = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvFicha = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chbConfirmar = new System.Windows.Forms.CheckBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFicha)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroComanda
            // 
            this.lblNumeroComanda.AutoSize = true;
            this.lblNumeroComanda.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroComanda.Location = new System.Drawing.Point(55, 32);
            this.lblNumeroComanda.Name = "lblNumeroComanda";
            this.lblNumeroComanda.Size = new System.Drawing.Size(112, 23);
            this.lblNumeroComanda.TabIndex = 0;
            this.lblNumeroComanda.Text = "N° Comanda:";
            // 
            // txbNumeroComanda
            // 
            this.txbNumeroComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumeroComanda.Location = new System.Drawing.Point(173, 31);
            this.txbNumeroComanda.Name = "txbNumeroComanda";
            this.txbNumeroComanda.Size = new System.Drawing.Size(100, 26);
            this.txbNumeroComanda.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(279, 31);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 26);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvFicha
            // 
            this.dgvFicha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFicha.Location = new System.Drawing.Point(12, 77);
            this.dgvFicha.Name = "dgvFicha";
            this.dgvFicha.Size = new System.Drawing.Size(403, 204);
            this.dgvFicha.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(275, 302);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 19);
            this.lblTotal.TabIndex = 4;
            // 
            // chbConfirmar
            // 
            this.chbConfirmar.AutoSize = true;
            this.chbConfirmar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbConfirmar.Location = new System.Drawing.Point(279, 365);
            this.chbConfirmar.Name = "chbConfirmar";
            this.chbConfirmar.Size = new System.Drawing.Size(134, 21);
            this.chbConfirmar.TabIndex = 5;
            this.chbConfirmar.Text = "Pagamento Recebido";
            this.chbConfirmar.UseVisualStyleBackColor = true;
            this.chbConfirmar.CheckedChanged += new System.EventHandler(this.chbConfirmar_CheckedChanged);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Location = new System.Drawing.Point(279, 392);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(134, 35);
            this.btnEncerrar.TabIndex = 6;
            this.btnEncerrar.Text = "Encerrar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 365);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 22);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Caixa - Padoca";
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 440);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.chbConfirmar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvFicha);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txbNumeroComanda);
            this.Controls.Add(this.lblNumeroComanda);
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFicha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroComanda;
        private System.Windows.Forms.TextBox txbNumeroComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvFicha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chbConfirmar;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblTitulo;
    }
}