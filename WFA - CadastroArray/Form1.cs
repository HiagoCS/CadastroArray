using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA___CadastroArray
{
    public partial class frmPrincipal : Form
    {
        public struct User
        {
            public int code;
            public string name;
            public string level;
            public string login;
            public string password;
        }
        public struct Client
        {
            public int code;
            public string name;
            public int cpf;
            public string email;
            public int tel;
            public string street;
            public int strNum;
            public string district;
            public string city;
            public string state;
            public int cep;
        }
        static public User[] users = new User[10];
        static public Client[] clients = new Client[10];
        static public int cadastrados = 0;
        static public int cadastradosCli = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser form = new frmUser();
            form.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient form = new frmClient();
            form.ShowDialog();
        }
    }
}
