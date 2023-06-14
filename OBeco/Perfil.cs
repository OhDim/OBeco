using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBeco
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            txtNome.Text = "" + globals.nome_login;
            if (globals.funcionario)
            {
                labelCargo.Text = "Número do ID";
                txtMatricula.Text = "" + globals.numeroID_login;
            }
            else
            {
                txtMatricula.Text = "" + globals.matricula_login;
            }
            txtEndereco.Text = "" + globals.endereco_login;
            txtTelefone.Text = globals.telefone_login;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
