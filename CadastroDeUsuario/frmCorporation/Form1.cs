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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*string de conexão*/
            string bancoDeDados = "server= localhost;user id=root;password=;database=bd_corporation";
            
            /* objeto de conexão*/
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            /*tratamento de exeção*/
            try
            {
                /* abertura da conexão*/
                conexao.Open();
                
                //objeto que vai armazenar um comando sql e vai executar
                MySqlCommand cmd = new MySqlCommand();

                //informa o objeto de conexão para o cmd
                cmd.Connection = conexao;

                //informar o sql que será executado
                cmd.CommandText = $"insert into tb_usuarios(nome , sobrenome , telefone , email) values ('{txtNome.Text}','{txtSobreNome.Text}','{txtTelefone.Text}','{txtEmail.Text}')";

                //executar o sql
                cmd.ExecuteNonQuery();

                //fechar a conexão
                conexao.Close();
                MessageBox.Show("Usuario cadastrado com sucesso!");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
