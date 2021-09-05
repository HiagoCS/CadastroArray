
namespace WFA___CadastroArray
{
    partial class frmClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.name = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cpf = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.district = new System.Windows.Forms.TextBox();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.strNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.confirmPesquisa = new System.Windows.Forms.Button();
            this.nmPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(12, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(139, 20);
            this.name.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 18);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Nome";
            // 
            // code
            // 
            this.code.Enabled = false;
            this.code.Location = new System.Drawing.Point(15, 30);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(65, 20);
            this.code.TabIndex = 1;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(12, 9);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(68, 18);
            this.labelCode.TabIndex = 5;
            this.labelCode.Text = "Código";
            // 
            // btnAlt
            // 
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlt.Location = new System.Drawing.Point(460, 55);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 15;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(541, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(460, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(460, 12);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 12;
            this.btnPrev.Text = "Anterior";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(541, 55);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Excluir";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(541, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Próximo";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(541, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(622, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(622, 101);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(622, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cpf
            // 
            this.cpf.Enabled = false;
            this.cpf.Location = new System.Drawing.Point(156, 74);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(139, 20);
            this.cpf.TabIndex = 3;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpf.Location = new System.Drawing.Point(156, 53);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(42, 18);
            this.labelCpf.TabIndex = 27;
            this.labelCpf.Text = "CPF";
            // 
            // street
            // 
            this.street.Enabled = false;
            this.street.Location = new System.Drawing.Point(12, 162);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(139, 20);
            this.street.TabIndex = 6;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreet.Location = new System.Drawing.Point(12, 141);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(43, 18);
            this.labelStreet.TabIndex = 31;
            this.labelStreet.Text = "Rua";
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(12, 118);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(139, 20);
            this.email.TabIndex = 4;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(12, 97);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(62, 18);
            this.labelemail.TabIndex = 29;
            this.labelemail.Text = "E-mail";
            // 
            // state
            // 
            this.state.Enabled = false;
            this.state.Location = new System.Drawing.Point(12, 250);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(139, 20);
            this.state.TabIndex = 10;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(12, 229);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(68, 18);
            this.labelState.TabIndex = 37;
            this.labelState.Text = "Estado";
            // 
            // city
            // 
            this.city.Enabled = false;
            this.city.Location = new System.Drawing.Point(157, 206);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(139, 20);
            this.city.TabIndex = 9;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(157, 185);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(68, 18);
            this.labelCity.TabIndex = 35;
            this.labelCity.Text = "Cidade";
            // 
            // district
            // 
            this.district.Enabled = false;
            this.district.Location = new System.Drawing.Point(12, 206);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(139, 20);
            this.district.TabIndex = 8;
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistrict.Location = new System.Drawing.Point(12, 185);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(62, 18);
            this.labelDistrict.TabIndex = 33;
            this.labelDistrict.Text = "Bairro";
            // 
            // strNum
            // 
            this.strNum.Enabled = false;
            this.strNum.Location = new System.Drawing.Point(157, 162);
            this.strNum.Name = "strNum";
            this.strNum.Size = new System.Drawing.Size(75, 20);
            this.strNum.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Número";
            // 
            // cep
            // 
            this.cep.Enabled = false;
            this.cep.Location = new System.Drawing.Point(157, 250);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(139, 20);
            this.cep.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "CEP";
            // 
            // tel
            // 
            this.tel.Enabled = false;
            this.tel.Location = new System.Drawing.Point(156, 118);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(139, 20);
            this.tel.TabIndex = 5;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(156, 97);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(86, 18);
            this.labelTel.TabIndex = 43;
            this.labelTel.Text = "Telefone";
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPesquisa.Controls.Add(this.button1);
            this.pnlPesquisa.Controls.Add(this.confirmPesquisa);
            this.pnlPesquisa.Controls.Add(this.nmPesquisa);
            this.pnlPesquisa.Controls.Add(this.label2);
            this.pnlPesquisa.Location = new System.Drawing.Point(460, 172);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(237, 229);
            this.pnlPesquisa.TabIndex = 44;
            this.pnlPesquisa.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmPesquisa
            // 
            this.confirmPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPesquisa.Location = new System.Drawing.Point(15, 60);
            this.confirmPesquisa.Name = "confirmPesquisa";
            this.confirmPesquisa.Size = new System.Drawing.Size(75, 23);
            this.confirmPesquisa.TabIndex = 23;
            this.confirmPesquisa.Text = "Ok";
            this.confirmPesquisa.UseVisualStyleBackColor = true;
            this.confirmPesquisa.Click += new System.EventHandler(this.confirmPesquisa_Click);
            // 
            // nmPesquisa
            // 
            this.nmPesquisa.Location = new System.Drawing.Point(15, 34);
            this.nmPesquisa.Name = "nmPesquisa";
            this.nmPesquisa.Size = new System.Drawing.Size(180, 20);
            this.nmPesquisa.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nome";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.state);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.city);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.district);
            this.Controls.Add(this.labelDistrict);
            this.Controls.Add(this.street);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.email);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.name);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.code);
            this.Controls.Add(this.labelCode);
            this.Name = "frmClient";
            this.Text = "frmClient";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.TextBox strNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Button confirmPesquisa;
        private System.Windows.Forms.TextBox nmPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}