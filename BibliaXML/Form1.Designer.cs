namespace BibliaXML
{
    partial class Form1
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
            this.tbcBiblia = new System.Windows.Forms.TabControl();
            this.tbpEncontrar = new System.Windows.Forms.TabPage();
            this.tbpComentarios = new System.Windows.Forms.TabPage();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbcBiblia.SuspendLayout();
            this.tbpEncontrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcBiblia
            // 
            this.tbcBiblia.AccessibleName = "";
            this.tbcBiblia.Controls.Add(this.tbpEncontrar);
            this.tbcBiblia.Controls.Add(this.tbpComentarios);
            this.tbcBiblia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbcBiblia.Location = new System.Drawing.Point(12, 12);
            this.tbcBiblia.Name = "tbcBiblia";
            this.tbcBiblia.SelectedIndex = 0;
            this.tbcBiblia.Size = new System.Drawing.Size(260, 237);
            this.tbcBiblia.TabIndex = 0;
            // 
            // tbpEncontrar
            // 
            this.tbpEncontrar.Controls.Add(this.textBox3);
            this.tbpEncontrar.Controls.Add(this.textBox2);
            this.tbpEncontrar.Controls.Add(this.textBox1);
            this.tbpEncontrar.Controls.Add(this.label2);
            this.tbpEncontrar.Controls.Add(this.label1);
            this.tbpEncontrar.Controls.Add(this.lblLivro);
            this.tbpEncontrar.Controls.Add(this.lbTitulo);
            this.tbpEncontrar.Location = new System.Drawing.Point(4, 22);
            this.tbpEncontrar.Name = "tbpEncontrar";
            this.tbpEncontrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEncontrar.Size = new System.Drawing.Size(252, 211);
            this.tbpEncontrar.TabIndex = 0;
            this.tbpEncontrar.Text = "Encontrar";
            this.tbpEncontrar.UseVisualStyleBackColor = true;
            // 
            // tbpComentarios
            // 
            this.tbpComentarios.Location = new System.Drawing.Point(4, 22);
            this.tbpComentarios.Name = "tbpComentarios";
            this.tbpComentarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpComentarios.Size = new System.Drawing.Size(252, 211);
            this.tbpComentarios.TabIndex = 1;
            this.tbpComentarios.Text = "Comentarios";
            this.tbpComentarios.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTitulo.Location = new System.Drawing.Point(31, 3);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(186, 20);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Encontre aqui o versículo";
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLivro.Location = new System.Drawing.Point(6, 40);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(110, 17);
            this.lblLivro.TabIndex = 1;
            this.lblLivro.Text = "Informe o Livro: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe o Capitulo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informe o Versiculo: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbcBiblia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbcBiblia.ResumeLayout(false);
            this.tbpEncontrar.ResumeLayout(false);
            this.tbpEncontrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcBiblia;
        private System.Windows.Forms.TabPage tbpEncontrar;
        private System.Windows.Forms.TabPage tbpComentarios;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

