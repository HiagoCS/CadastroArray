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
    public partial class frmClient : Form
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
            frmPrincipal.clients[frmPrincipal.cadastradosCli].code = code.Text == "" ? 0 : int.Parse(code.Text);
            frmPrincipal.clients[frmPrincipal.cadastradosCli].name = name.Text;
            frmPrincipal.clients[frmPrincipal.cadastradosCli].email = email.Text;
            frmPrincipal.clients[frmPrincipal.cadastradosCli].street = street.Text;
            frmPrincipal.clients[frmPrincipal.cadastradosCli].district = district.Text;
            frmPrincipal.clients[frmPrincipal.cadastradosCli].city = city.Text;
            frmPrincipal.clients[frmPrincipal.cadastradosCli].state = state.Text;
            frmPrincipal.clients[frmPrincipal.cadastradosCli].cpf = cpf.Text == "" ? 0 : int.Parse(cpf.Text);
            frmPrincipal.clients[frmPrincipal.cadastradosCli].tel = tel.Text == "" ? 0 : int.Parse(tel.Text);
            frmPrincipal.clients[frmPrincipal.cadastradosCli].strNum = strNum.Text == "" ? 0 : int.Parse(strNum.Text);
            frmPrincipal.clients[frmPrincipal.cadastradosCli].cep = cep.Text == "" ? 0 : int.Parse(cep.Text);
        }
        private void ShowTb()
        {
            code.Text = frmPrincipal.clients[atual].code == 0 ? "" : Convert.ToString(frmPrincipal.clients[atual].code);
            name.Text = frmPrincipal.clients[atual].name;
            email.Text = frmPrincipal.clients[atual].email;
            street.Text = frmPrincipal.clients[atual].street;
            district.Text = frmPrincipal.clients[atual].district;
            city.Text = frmPrincipal.clients[atual].city;
            state.Text = frmPrincipal.clients[atual].state;
            cpf.Text = frmPrincipal.clients[atual].cpf == 0 ? "" : Convert.ToString(frmPrincipal.clients[atual].cpf);
            tel.Text = frmPrincipal.clients[atual].tel == 0 ? "" : Convert.ToString(frmPrincipal.clients[atual].tel);
            strNum.Text = frmPrincipal.clients[atual].strNum == 0 ? "" : Convert.ToString(frmPrincipal.clients[atual].strNum);
            cep.Text = frmPrincipal.clients[atual].cep == 0 ? "" : Convert.ToString(frmPrincipal.clients[atual].cep);
        }
        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            ShowTb();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.cadastradosCli == 10)
            {
                MessageBox.Show("Limite de usuários atingido");
                return;
            }
            Clean(this.Controls);
            Enabling(this.Controls, false);
            code.Text = Convert.ToString(frmPrincipal.cadastradosCli + 1);
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
                frmPrincipal.cadastradosCli++;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Enabling(this.Controls, true);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                ShowTb();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (atual < frmPrincipal.cadastradosCli - 1)
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
                frmPrincipal.clients[atual].name = "";
                frmPrincipal.clients[atual].email = "";
                frmPrincipal.clients[atual].street = "";
                frmPrincipal.clients[atual].district = "";
                frmPrincipal.clients[atual].city = "";
                frmPrincipal.clients[atual].state = "";
                frmPrincipal.clients[atual].cpf = 0;
                frmPrincipal.clients[atual].tel = 0;
                frmPrincipal.clients[atual].strNum = 0;
                frmPrincipal.clients[atual].cep = 0;
                frmPrincipal.cadastradosCli--;
                ShowTb();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = true;
        }

        private void confirmPesquisa_Click(object sender, EventArgs e)
        {
            int x;
            if(nmPesquisa.Text != "")
            {
                for (x = 0; x < 10; x++)
                {
                    if(frmPrincipal.clients[x].name == nmPesquisa.Text)
                    {
                        atual = x;
                        ShowTb();
                        break;
                    }
                }
                if(x == 10)
                {
                    MessageBox.Show("Nome não encontrado!!");
                }
            }
            else
            {
                MessageBox.Show("Digite um nome para pesquisa!!");
                nmPesquisa.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = false;
            nmPesquisa.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;
            strDados = "Ficha de Cliente\n\n";
            strDados += "Código: " + code.Text;
            strDados += "\n\nNome: " + name.Text;
            strDados += "\n\nCPF: " + cpf.Text;
            strDados += "\n\nE-mail: " + email.Text;
            strDados += "\n\nTelefone: " + tel.Text;
            strDados += "\n\nEndereço: " + street.Text;
            strDados += ", " + strNum.Text;
            strDados += ", " + district.Text;
            strDados += ", " + city.Text;
            strDados += ", " + state.Text;
            strDados += "\n\nCEP: " + cep.Text;
            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
