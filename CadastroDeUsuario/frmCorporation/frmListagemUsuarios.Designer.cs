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
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtNomeBuscar = new System.Windows.Forms.TextBox();
            this.nomeBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNovoUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(153, 23);
            this.btnNovoUsuario.TabIndex = 0;
            this.btnNovoUsuario.Text = "NOVO USUÁRIO";
            this.btnNovoUsuario.UseVisualStyleBackColor = false;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnAlterarExcluir
            // 
            this.btnAlterarExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlterarExcluir.Location = new System.Drawing.Point(182, 12);
            this.btnAlterarExcluir.Name = "btnAlterarExcluir";
            this.btnAlterarExcluir.Size = new System.Drawing.Size(167, 23);
            this.btnAlterarExcluir.TabIndex = 1;
            this.btnAlterarExcluir.Text = "ALTERAR / EXCLUIR";
            this.btnAlterarExcluir.UseVisualStyleBackColor = false;
            this.btnAlterarExcluir.Click += new System.EventHandler(this.btnAlterarExcluir_Click);
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Location = new System.Drawing.Point(12, 70);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.Size = new System.Drawing.Size(426, 129);
            this.gridUsuarios.TabIndex = 2;
            this.gridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsuarios_CellContentClick);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.Location = new System.Drawing.Point(12, 221);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtNomeBuscar
            // 
            this.txtNomeBuscar.Location = new System.Drawing.Point(56, 41);
            this.txtNomeBuscar.Name = "txtNomeBuscar";
            this.txtNomeBuscar.Size = new System.Drawing.Size(279, 20);
            this.txtNomeBuscar.TabIndex = 4;
            this.txtNomeBuscar.TextChanged += new System.EventHandler(this.txtNomeBuscar_TextChanged);
            // 
            // nomeBuscar
            // 
            this.nomeBuscar.AutoSize = true;
            this.nomeBuscar.Location = new System.Drawing.Point(12, 44);
            this.nomeBuscar.Name = "nomeBuscar";
            this.nomeBuscar.Size = new System.Drawing.Size(38, 13);
            this.nomeBuscar.TabIndex = 5;
            this.nomeBuscar.Text = "Nome:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(342, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmListagemUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 246);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.nomeBuscar);
            this.Controls.Add(this.txtNomeBuscar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.btnAlterarExcluir);
            this.Controls.Add(this.btnNovoUsuario);
            this.Name = "frmListagemUsuarios";
            this.Text = "ListagemUsuarios";
            this.Load += new System.EventHandler(this.frmListagemUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnAlterarExcluir;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtNomeBuscar;
        private System.Windows.Forms.Label nomeBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}