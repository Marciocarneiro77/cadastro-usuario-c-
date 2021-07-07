using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace frmCorporation
{
    public partial class frmListagemUsuarios : Form
    {
        public frmListagemUsuarios()
        {
            InitializeComponent();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroDeUsuarios OutroForm = new frmCadastroDeUsuarios();
            OutroForm.ShowDialog();
        }

        private void btnAlterarExcluir_Click(object sender, EventArgs e)
        {
            frmAlterarUsuario outroForm = new frmAlterarUsuario();
            outroForm.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNomeBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_corporation";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                string nomeBuscar = txtNomeBuscar.Text;
                conexao.Open();
                string sqlSelecionar = $"SELECT * FROM tb_usuarios WHERE nome like'%{nomeBuscar}%'";

                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridUsuarios.DataSource = dt;
                conexao.Close();
            }
            catch(MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, "Erro na conexão");
            }
        }

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListagemUsuarios_Load(object sender, EventArgs e)
        {

            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_corporation";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            { 
                conexao.Open();
                string sqlSelecionar = "SELECT * FROM tb_usuarios";

                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridUsuarios.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, "Erro na conexão");
            }
        }
    }
}
