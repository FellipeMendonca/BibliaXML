namespace BibliaXML
{
    partial class frmPrincipal
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
            this.btnEncontrar = new System.Windows.Forms.Button();
            this.txbVersiculo = new System.Windows.Forms.TextBox();
            this.txbCapitulo = new System.Windows.Forms.TextBox();
            this.txbLivro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tbpComentarios = new System.Windows.Forms.TabPage();
            this.dgvAnotações = new System.Windows.Forms.DataGridView();
            this.btnExcluirAnotação = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbcBiblia.SuspendLayout();
            this.tbpEncontrar.SuspendLayout();
            this.tbpComentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnotações)).BeginInit();
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
            this.tbcBiblia.Click += new System.EventHandler(this.tbcBiblia_Click);
            // 
            // tbpEncontrar
            // 
            this.tbpEncontrar.Controls.Add(this.btnEncontrar);
            this.tbpEncontrar.Controls.Add(this.txbVersiculo);
            this.tbpEncontrar.Controls.Add(this.txbCapitulo);
            this.tbpEncontrar.Controls.Add(this.txbLivro);
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
            // btnEncontrar
            // 
            this.btnEncontrar.Location = new System.Drawing.Point(85, 161);
            this.btnEncontrar.Name = "btnEncontrar";
            this.btnEncontrar.Size = new System.Drawing.Size(75, 23);
            this.btnEncontrar.TabIndex = 7;
            this.btnEncontrar.Text = "Encontre!";
            this.btnEncontrar.UseVisualStyleBackColor = true;
            this.btnEncontrar.Click += new System.EventHandler(this.btnEncontrar_Click);
            // 
            // txbVersiculo
            // 
            this.txbVersiculo.Location = new System.Drawing.Point(146, 104);
            this.txbVersiculo.Name = "txbVersiculo";
            this.txbVersiculo.Size = new System.Drawing.Size(97, 20);
            this.txbVersiculo.TabIndex = 6;
            // 
            // txbCapitulo
            // 
            this.txbCapitulo.Location = new System.Drawing.Point(142, 73);
            this.txbCapitulo.Name = "txbCapitulo";
            this.txbCapitulo.Size = new System.Drawing.Size(104, 20);
            this.txbCapitulo.TabIndex = 5;
            // 
            // txbLivro
            // 
            this.txbLivro.Location = new System.Drawing.Point(117, 39);
            this.txbLivro.Name = "txbLivro";
            this.txbLivro.Size = new System.Drawing.Size(129, 20);
            this.txbLivro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informe o Versiculo: ";
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
            // tbpComentarios
            // 
            this.tbpComentarios.Controls.Add(this.btnEditar);
            this.tbpComentarios.Controls.Add(this.btnExcluirAnotação);
            this.tbpComentarios.Controls.Add(this.dgvAnotações);
            this.tbpComentarios.Location = new System.Drawing.Point(4, 22);
            this.tbpComentarios.Name = "tbpComentarios";
            this.tbpComentarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpComentarios.Size = new System.Drawing.Size(252, 211);
            this.tbpComentarios.TabIndex = 1;
            this.tbpComentarios.Text = "Notas";
            this.tbpComentarios.UseVisualStyleBackColor = true;
            // 
            // dgvAnotações
            // 
            this.dgvAnotações.AllowUserToAddRows = false;
            this.dgvAnotações.AllowUserToDeleteRows = false;
            this.dgvAnotações.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAnotações.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnotações.Location = new System.Drawing.Point(0, 0);
            this.dgvAnotações.Name = "dgvAnotações";
            this.dgvAnotações.ReadOnly = true;
            this.dgvAnotações.Size = new System.Drawing.Size(252, 176);
            this.dgvAnotações.TabIndex = 0;
            // 
            // btnExcluirAnotação
            // 
            this.btnExcluirAnotação.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluirAnotação.Location = new System.Drawing.Point(6, 182);
            this.btnExcluirAnotação.Name = "btnExcluirAnotação";
            this.btnExcluirAnotação.Size = new System.Drawing.Size(108, 23);
            this.btnExcluirAnotação.TabIndex = 1;
            this.btnExcluirAnotação.Text = "Excluir Nota";
            this.btnExcluirAnotação.UseVisualStyleBackColor = true;
            this.btnExcluirAnotação.Click += new System.EventHandler(this.btnExcluirAnotação_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditar.Location = new System.Drawing.Point(138, 182);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar Nota";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbcBiblia);
            this.Name = "frmPrincipal";
            this.Text = "Encontre seu Palavra";
            this.tbcBiblia.ResumeLayout(false);
            this.tbpEncontrar.ResumeLayout(false);
            this.tbpEncontrar.PerformLayout();
            this.tbpComentarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnotações)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcBiblia;
        private System.Windows.Forms.TabPage tbpEncontrar;
        private System.Windows.Forms.TabPage tbpComentarios;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txbVersiculo;
        private System.Windows.Forms.TextBox txbCapitulo;
        private System.Windows.Forms.TextBox txbLivro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncontrar;
        private System.Windows.Forms.DataGridView dgvAnotações;
        private System.Windows.Forms.Button btnExcluirAnotação;
        private System.Windows.Forms.Button btnEditar;
    }
}

