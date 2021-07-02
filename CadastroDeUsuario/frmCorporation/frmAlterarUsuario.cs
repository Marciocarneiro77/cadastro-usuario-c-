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
    public partial class frmAlterarUsuario : Form
    {
        public frmAlterarUsuario()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            /*string de conexão*/
            string bancoDeDados = "server= localhost;user id=root;password=;database=bd_corporation";
            string idUsuario = txtID.Text;

            /* objeto de conexão*/
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            /*tratamento de exeção*/
            try
            {
                /* abertura da conexão*/
                conexao.Open();
                string sqlExcluir = $"DELETE FROM tb_usuarios WHERE id={idUsuario}";

                //objeto que vai armazenar um comando sql e vai executar
                MySqlCommand cmd = new MySqlCommand();

                //informa o objeto de conexão para o cmd
                cmd.Connection = conexao;

                //informar o sql que será executado
                cmd.CommandText = sqlExcluir;

                //executar o sql
                cmd.ExecuteNonQuery();

                //fechar a conexão
                conexao.Close();
                MessageBox.Show("Usuario excluido com sucesso!");
                txtID.Clear();
                txtNome.Clear();
                txtSobreNome.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possivel conectar com o banco de dados:" + erro.Message);

            }
        }

        private void frmAlterarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
