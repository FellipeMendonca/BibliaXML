namespace BibliaXML
{
    partial class Resultado
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txbComentario = new System.Windows.Forms.TextBox();
            this.lblVersiculo = new System.Windows.Forms.Label();
            this.txbVersiculo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVoltar.Location = new System.Drawing.Point(163, 226);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Location = new System.Drawing.Point(43, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblComentario.Location = new System.Drawing.Point(9, 113);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(149, 17);
            this.lblComentario.TabIndex = 3;
            this.lblComentario.Text = "Insira seu Comentário:";
            this.lblComentario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbComentario
            // 
            this.txbComentario.Location = new System.Drawing.Point(12, 133);
            this.txbComentario.MinimumSize = new System.Drawing.Size(200, 50);
            this.txbComentario.Multiline = true;
            this.txbComentario.Name = "txbComentario";
            this.txbComentario.Size = new System.Drawing.Size(260, 87);
            this.txbComentario.TabIndex = 4;
            // 
            // lblVersiculo
            // 
            this.lblVersiculo.AutoSize = true;
            this.lblVersiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVersiculo.Location = new System.Drawing.Point(9, 9);
            this.lblVersiculo.Name = "lblVersiculo";
            this.lblVersiculo.Size = new System.Drawing.Size(74, 17);
            this.lblVersiculo.TabIndex = 5;
            this.lblVersiculo.Text = "Versiculo: ";
            // 
            // txbVersiculo
            // 
            this.txbVersiculo.Enabled = false;
            this.txbVersiculo.Location = new System.Drawing.Point(9, 29);
            this.txbVersiculo.Multiline = true;
            this.txbVersiculo.Name = "txbVersiculo";
            this.txbVersiculo.Size = new System.Drawing.Size(260, 81);
            this.txbVersiculo.TabIndex = 6;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txbVersiculo);
            this.Controls.Add(this.lblVersiculo);
            this.Controls.Add(this.txbComentario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txbComentario;
        private System.Windows.Forms.Label lblVersiculo;
        private System.Windows.Forms.TextBox txbVersiculo;
    }
}