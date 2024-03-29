﻿namespace Teste.forms.Client
{
    partial class FormRegClient
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
            pnlinfo = new Panel();
            label12 = new Label();
            cbType = new ComboBox();
            txtcarteira = new NumericUpDown();
            label11 = new Label();
            pnlaccess = new Panel();
            cbadm = new CheckBox();
            label10 = new Label();
            txtsenha = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtconfirmarsenha = new TextBox();
            txtusuario = new TextBox();
            panel3 = new Panel();
            rboutro = new RadioButton();
            rbfem = new RadioButton();
            rbmasc = new RadioButton();
            txttelefone = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtcpf = new MaskedTextBox();
            txtNome = new TextBox();
            txtemail = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            pnlsup = new Panel();
            btnFechar = new Button();
            label7 = new Label();
            btnok = new Button();
            button1 = new Button();
            btndeletar = new Button();
            pnldepositar = new Panel();
            btndepositar = new Button();
            label13 = new Label();
            nuddepositar = new NumericUpDown();
            pnlinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtcarteira).BeginInit();
            pnlaccess.SuspendLayout();
            panel3.SuspendLayout();
            pnlsup.SuspendLayout();
            pnldepositar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuddepositar).BeginInit();
            SuspendLayout();
            // 
            // pnlinfo
            // 
            pnlinfo.BackColor = SystemColors.ButtonHighlight;
            pnlinfo.Controls.Add(label12);
            pnlinfo.Controls.Add(cbType);
            pnlinfo.Controls.Add(txtcarteira);
            pnlinfo.Controls.Add(label11);
            pnlinfo.Controls.Add(pnlaccess);
            pnlinfo.Controls.Add(panel3);
            pnlinfo.Controls.Add(txttelefone);
            pnlinfo.Controls.Add(label6);
            pnlinfo.Controls.Add(label5);
            pnlinfo.Controls.Add(label1);
            pnlinfo.Controls.Add(txtcpf);
            pnlinfo.Controls.Add(txtNome);
            pnlinfo.Controls.Add(txtemail);
            pnlinfo.Controls.Add(label2);
            pnlinfo.Controls.Add(label4);
            pnlinfo.Controls.Add(label3);
            pnlinfo.Location = new Point(5, 65);
            pnlinfo.Name = "pnlinfo";
            pnlinfo.Size = new Size(728, 267);
            pnlinfo.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label12.Location = new Point(246, 150);
            label12.Name = "label12";
            label12.Size = new Size(48, 20);
            label12.TabIndex = 29;
            label12.Text = "Perfil:";
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Conservador", "Moderado", "Agressivo" });
            cbType.Location = new Point(303, 149);
            cbType.Name = "cbType";
            cbType.Size = new Size(126, 23);
            cbType.TabIndex = 28;
            // 
            // txtcarteira
            // 
            txtcarteira.DecimalPlaces = 2;
            txtcarteira.Location = new Point(303, 106);
            txtcarteira.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            txtcarteira.Name = "txtcarteira";
            txtcarteira.Size = new Size(126, 23);
            txtcarteira.TabIndex = 27;
            txtcarteira.ThousandsSeparator = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label11.Location = new Point(232, 107);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 26;
            label11.Text = "Carteira:";
            // 
            // pnlaccess
            // 
            pnlaccess.BackColor = SystemColors.ButtonHighlight;
            pnlaccess.Controls.Add(cbadm);
            pnlaccess.Controls.Add(label10);
            pnlaccess.Controls.Add(txtsenha);
            pnlaccess.Controls.Add(label9);
            pnlaccess.Controls.Add(label8);
            pnlaccess.Controls.Add(txtconfirmarsenha);
            pnlaccess.Controls.Add(txtusuario);
            pnlaccess.Location = new Point(457, 6);
            pnlaccess.Name = "pnlaccess";
            pnlaccess.Size = new Size(266, 254);
            pnlaccess.TabIndex = 25;
            // 
            // cbadm
            // 
            cbadm.AutoSize = true;
            cbadm.Location = new Point(38, 221);
            cbadm.Name = "cbadm";
            cbadm.Size = new Size(52, 19);
            cbadm.TabIndex = 30;
            cbadm.Text = "Adm";
            cbadm.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label10.Location = new Point(23, 87);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 29;
            label10.Text = "Senha:";
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(36, 114);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(210, 23);
            txtsenha.TabIndex = 28;
            txtsenha.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label9.Location = new Point(22, 152);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 27;
            label9.Text = "Confirmar senha:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label8.Location = new Point(23, 26);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 26;
            label8.Text = "Usuario:";
            // 
            // txtconfirmarsenha
            // 
            txtconfirmarsenha.Location = new Point(37, 180);
            txtconfirmarsenha.Name = "txtconfirmarsenha";
            txtconfirmarsenha.Size = new Size(210, 23);
            txtconfirmarsenha.TabIndex = 1;
            txtconfirmarsenha.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(38, 54);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(210, 23);
            txtusuario.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(rboutro);
            panel3.Controls.Add(rbfem);
            panel3.Controls.Add(rbmasc);
            panel3.Location = new Point(88, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(341, 46);
            panel3.TabIndex = 21;
            // 
            // rboutro
            // 
            rboutro.AutoSize = true;
            rboutro.Location = new Point(281, 12);
            rboutro.Name = "rboutro";
            rboutro.Size = new Size(56, 19);
            rboutro.TabIndex = 2;
            rboutro.TabStop = true;
            rboutro.Text = "Outro";
            rboutro.UseVisualStyleBackColor = true;
            // 
            // rbfem
            // 
            rbfem.AutoSize = true;
            rbfem.Location = new Point(147, 12);
            rbfem.Name = "rbfem";
            rbfem.Size = new Size(75, 19);
            rbfem.TabIndex = 1;
            rbfem.TabStop = true;
            rbfem.Text = "Feminino";
            rbfem.UseVisualStyleBackColor = true;
            // 
            // rbmasc
            // 
            rbmasc.AutoSize = true;
            rbmasc.Location = new Point(9, 12);
            rbmasc.Name = "rbmasc";
            rbmasc.Size = new Size(80, 19);
            rbmasc.TabIndex = 0;
            rbmasc.TabStop = true;
            rbmasc.Text = "Masculino";
            rbmasc.UseVisualStyleBackColor = true;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(88, 106);
            txttelefone.Mask = "(00)00000-9999";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(139, 23);
            txttelefone.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(36, 150);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 22;
            label6.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(33, 194);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 17;
            label5.Text = "Sexo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 13;
            label1.Text = "Nome:";
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(88, 149);
            txtcpf.Mask = "111111111-11";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(139, 23);
            txtcpf.TabIndex = 20;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(90, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(339, 23);
            txtNome.TabIndex = 18;
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Location = new Point(88, 69);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(341, 23);
            txtemail.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(27, 70);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 14;
            label2.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(2, 107);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 16;
            label4.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(17, 162);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 15;
            // 
            // pnlsup
            // 
            pnlsup.BackColor = Color.Navy;
            pnlsup.BorderStyle = BorderStyle.FixedSingle;
            pnlsup.Controls.Add(btnFechar);
            pnlsup.Controls.Add(label7);
            pnlsup.Cursor = Cursors.SizeAll;
            pnlsup.Dock = DockStyle.Top;
            pnlsup.Location = new Point(0, 0);
            pnlsup.Name = "pnlsup";
            pnlsup.Size = new Size(736, 44);
            pnlsup.TabIndex = 24;
            pnlsup.MouseDown += pnlsup_MouseDown;
            pnlsup.MouseMove += pnlsup_MouseMove;
            pnlsup.MouseUp += pnlsup_MouseUp;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.DarkBlue;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.ButtonFace;
            btnFechar.Location = new Point(700, 8);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(29, 23);
            btnFechar.TabIndex = 25;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(4, 9);
            label7.Name = "label7";
            label7.Size = new Size(176, 25);
            label7.TabIndex = 25;
            label7.Text = "Cadastro de cliente";
            // 
            // btnok
            // 
            btnok.BackColor = Color.DodgerBlue;
            btnok.Cursor = Cursors.Hand;
            btnok.FlatAppearance.BorderSize = 0;
            btnok.FlatStyle = FlatStyle.Flat;
            btnok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnok.ForeColor = SystemColors.ButtonFace;
            btnok.ImageAlign = ContentAlignment.MiddleLeft;
            btnok.Location = new Point(433, 373);
            btnok.Name = "btnok";
            btnok.Size = new Size(142, 37);
            btnok.TabIndex = 15;
            btnok.Text = "Salvar";
            btnok.UseVisualStyleBackColor = false;
            btnok.Click += btnok_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(581, 373);
            button1.Name = "button1";
            button1.Size = new Size(142, 37);
            button1.TabIndex = 25;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btndeletar
            // 
            btndeletar.BackColor = Color.DarkOrange;
            btndeletar.Cursor = Cursors.Hand;
            btndeletar.FlatAppearance.BorderSize = 0;
            btndeletar.FlatStyle = FlatStyle.Flat;
            btndeletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndeletar.ForeColor = SystemColors.ButtonFace;
            btndeletar.ImageAlign = ContentAlignment.MiddleLeft;
            btndeletar.Location = new Point(285, 373);
            btndeletar.Name = "btndeletar";
            btndeletar.Size = new Size(142, 37);
            btndeletar.TabIndex = 26;
            btndeletar.Text = "Deletar";
            btndeletar.UseVisualStyleBackColor = false;
            btndeletar.Click += btndeletar_Click;
            // 
            // pnldepositar
            // 
            pnldepositar.BackColor = SystemColors.ButtonHighlight;
            pnldepositar.Controls.Add(btndepositar);
            pnldepositar.Controls.Add(label13);
            pnldepositar.Controls.Add(nuddepositar);
            pnldepositar.Location = new Point(5, 338);
            pnldepositar.Name = "pnldepositar";
            pnldepositar.Size = new Size(274, 77);
            pnldepositar.TabIndex = 30;
            // 
            // btndepositar
            // 
            btndepositar.BackColor = Color.GreenYellow;
            btndepositar.Cursor = Cursors.Hand;
            btndepositar.FlatAppearance.BorderSize = 0;
            btndepositar.FlatStyle = FlatStyle.Flat;
            btndepositar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndepositar.ForeColor = SystemColors.ButtonFace;
            btndepositar.ImageAlign = ContentAlignment.MiddleLeft;
            btndepositar.Location = new Point(100, 34);
            btndepositar.Name = "btndepositar";
            btndepositar.Size = new Size(142, 37);
            btndepositar.TabIndex = 31;
            btndepositar.Text = "Depositar";
            btndepositar.UseVisualStyleBackColor = false;
            btndepositar.Click += btndepositar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label13.Location = new Point(7, 6);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 30;
            label13.Text = "Depositar:";
            // 
            // nuddepositar
            // 
            nuddepositar.DecimalPlaces = 2;
            nuddepositar.Location = new Point(97, 3);
            nuddepositar.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nuddepositar.Name = "nuddepositar";
            nuddepositar.Size = new Size(160, 23);
            nuddepositar.TabIndex = 30;
            nuddepositar.ThousandsSeparator = true;
            // 
            // FormRegClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(736, 416);
            Controls.Add(pnldepositar);
            Controls.Add(btndeletar);
            Controls.Add(button1);
            Controls.Add(btnok);
            Controls.Add(pnlinfo);
            Controls.Add(pnlsup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            pnlinfo.ResumeLayout(false);
            pnlinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtcarteira).EndInit();
            pnlaccess.ResumeLayout(false);
            pnlaccess.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlsup.ResumeLayout(false);
            pnlsup.PerformLayout();
            pnldepositar.ResumeLayout(false);
            pnldepositar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuddepositar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlinfo;
        private Panel panel3;
        private RadioButton rboutro;
        private RadioButton rbfem;
        private RadioButton rbmasc;
        private MaskedTextBox txttelefone;
        private Label label6;
        private Label label5;
        private Label label1;
        private MaskedTextBox txtcpf;
        private TextBox txtNome;
        private TextBox txtemail;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button btnok;
        private Panel pnlsup;
        private Button btnFechar;
        private Label label7;
        private Panel pnlaccess;
        private TextBox txtconfirmarsenha;
        private TextBox txtusuario;
        private Label label10;
        private TextBox txtsenha;
        private Label label9;
        private Label label8;
        private NumericUpDown txtcarteira;
        private Label label11;
        private Label label12;
        private ComboBox cbType;
        private CheckBox cbadm;
        private Button button1;
        private Button btndeletar;
        private Panel pnldepositar;
        private Label label13;
        private NumericUpDown nuddepositar;
        private Button btndepositar;
    }
}