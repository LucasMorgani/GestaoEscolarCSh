using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidade;
using CapaDeNegocio;

namespace ProjetoEscolar
{
    public partial class Form1 : Form
    {
        ClasseNegocio clsuser = new ClasseNegocio();
        ClasseEntidade clsent = new ClasseEntidade();
        public static string usuario_nome;
        public static string id_tipo;
        public static string usuario_geral;
        public static string usuario_Codigo;

        FrmPrincipal f = new FrmPrincipal();

        public Form1()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            clsuser.usuario = txtLogin.Text;
            clsuser.senha = txtSenha.Text;

            dt = clsent.N_Login(clsuser);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bem Vindo!" + dt.Rows[0][0].ToString(),"Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nome = dt.Rows[0][0].ToString();
                id_tipo = dt.Rows[0][1].ToString();
                usuario_geral = dt.Rows[0][2].ToString();
                usuario_Codigo = dt.Rows[0][3].ToString();
                this.Hide();
                f.ShowDialog();
                Limpar();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta.." , "Mensagem" , 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
        }
    }
}
