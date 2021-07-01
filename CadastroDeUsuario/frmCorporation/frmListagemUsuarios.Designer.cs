namespace frmCorporation
{
    partial class frmListagemUsuarios
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
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnAlterarExcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNovoUsuario.Location = new System.Drawing.Point(57, 39);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(153, 23);
            this.btnNovoUsuario.TabIndex = 0;
            this.btnNovoUsuario.Text = "NOVO USUÁRIO";
            this.btnNovoUsuario.UseVisualStyleBackColor = false;
            // 
            // btnAlterarExcluir
            // 
            this.btnAlterarExcluir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAlterarExcluir.Location = new System.Drawing.Point(297, 39);
            this.btnAlterarExcluir.Name = "btnAlterarExcluir";
            this.btnAlterarExcluir.Size = new System.Drawing.Size(167, 23);
            this.btnAlterarExcluir.TabIndex = 1;
            this.btnAlterarExcluir.Text = "ALTERAR / EXCLUIR";
            this.btnAlterarExcluir.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 259);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmListagemUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAlterarExcluir);
            this.Controls.Add(this.btnNovoUsuario);
            this.Name = "frmListagemUsuarios";
            this.Text = "ListagemUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnAlterarExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}