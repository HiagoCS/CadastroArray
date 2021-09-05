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
    public partial class frmUser : Form
    {
        public int atual = 0;
        public string tipo;
        private void Enabling(Control.ControlCollection controles, bool op)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is Button)
                {
                    ((Button)(ctrl)).Enabled = op;
                }
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Enabled = !op;
                }
            }
            btnSave.Enabled = !op;
            btnCancel.Enabled = !op;
        }
        private void Clean(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox && ctrl.Name != "code")
                {
                    ((TextBox)(ctrl)).Text = null;
                }
            }
        }
        private void Save()
        {
            frmPrincipal.users[frmPrincipal.cadastrados].code = code.Text == "" ? 0 : int.Parse(code.Text);
            frmPrincipal.users[frmPrincipal.cadastrados].level = level.Text;
            frmPrincipal.users[frmPrincipal.cadastrados].name = name.Text;
            frmPrincipal.users[frmPrincipal.cadastrados].login = login.Text;
            frmPrincipal.users[frmPrincipal.cadastrados].password = password.Text;
        }
        private void ShowTb()
        {
            code.Text = frmPrincipal.users[atual].code == 0 ? "" : Convert.ToString(frmPrincipal.users[atual].code);
            level.Text = frmPrincipal.users[atual].level;
            name.Text = frmPrincipal.users[atual].name;
            login.Text = frmPrincipal.users[atual].login;
            password.Text = frmPrincipal.users[atual].password;
        }
        public frmUser()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.cadastrados == 10)
            {
                MessageBox.Show("Limite de usuários atingido");
                return;
            }
            Clean(this.Controls);
            Enabling(this.Controls, false);
            code.Text = Convert.ToString(frmPrincipal.cadastrados + 1);
            tipo = "new";
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            Enabling(this.Controls, false);
            tipo = "alt";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Enabling(this.Controls, true);
            Save();
            if (tipo == "new")
                frmPrincipal.cadastrados++;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Enabling(this.Controls, true);
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            ShowTb();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                ShowTb();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (atual < frmPrincipal.cadastrados - 1)
            {
                atual++;
                ShowTb();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do registro?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmPrincipal.users[atual].name = "";
                frmPrincipal.users[atual].level = "";
                frmPrincipal.users[atual].login = "";
                frmPrincipal.users[atual].password = "";
                frmPrincipal.cadastrados--;
                ShowTb();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = true;
        }

        private void confirmPesquisa_Click(object sender, EventArgs e)
        {
            int x;
            if (nmPesquisa.Text != "")
            {
                for (x = 0; x < 10; x++)
                {
                    if (frmPrincipal.users[x].name == nmPesquisa.Text)
                    {
                        atual = x;
                        ShowTb();
                        break;
                    }
                }
                if (x == 10)
                {
                    MessageBox.Show("Nome não encontrado!!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = false;
            nmPesquisa.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;
            strDados = "Ficha de Usuário\n\n";
            strDados += "Código: " + code.Text;
            strDados += "\n\nNome: " + name.Text;
            strDados += "\n\nNível: " + level.Text;
            strDados += "\n\nLogin: " + login.Text;
            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
        }
    }
}
