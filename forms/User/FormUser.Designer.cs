namespace Teste.forms.User
{
    partial class FormUser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvUser = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            wallet = new DataGridViewTextBoxColumn();
            TipInv = new DataGridViewTextBoxColumn();
            pnlsup = new Panel();
            btnfechar = new Button();
            label7 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            btnok = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            pnlsup.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AllowUserToResizeColumns = false;
            dgvUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Telefone, Email, Sexo, wallet, TipInv });
            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.Location = new Point(12, 96);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.PapayaWhip;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(776, 342);
            dgvUser.TabIndex = 0;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 30;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Telefone
            // 
            Telefone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.Width = 120;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Sexo
            // 
            Sexo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.Width = 120;
            // 
            // wallet
            // 
            wallet.HeaderText = "Carteira";
            wallet.Name = "wallet";
            // 
            // TipInv
            // 
            TipInv.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TipInv.HeaderText = "Perfil ";
            TipInv.Name = "TipInv";
            TipInv.Width = 120;
            // 
            // pnlsup
            // 
            pnlsup.BackColor = Color.Navy;
            pnlsup.BorderStyle = BorderStyle.FixedSingle;
            pnlsup.Controls.Add(btnfechar);
            pnlsup.Controls.Add(label7);
            pnlsup.Cursor = Cursors.SizeAll;
            pnlsup.Dock = DockStyle.Top;
            pnlsup.Location = new Point(0, 0);
            pnlsup.Name = "pnlsup";
            pnlsup.Size = new Size(800, 44);
            pnlsup.TabIndex = 31;
            pnlsup.MouseDown += pnlsup_MouseDown;
            pnlsup.MouseMove += pnlsup_MouseMove;
            pnlsup.MouseUp += pnlsup_MouseUp;
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.DarkBlue;
            btnfechar.Cursor = Cursors.Hand;
            btnfechar.FlatAppearance.BorderSize = 0;
            btnfechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnfechar.FlatStyle = FlatStyle.Flat;
            btnfechar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnfechar.ForeColor = SystemColors.ButtonFace;
            btnfechar.Location = new Point(766, 9);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(29, 23);
            btnfechar.TabIndex = 25;
            btnfechar.Text = "X";
            btnfechar.UseVisualStyleBackColor = false;
            btnfechar.Click += btnfechar_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(4, 9);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 25;
            label7.Text = "Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(14, 62);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 28;
            label2.Text = "Nome:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(73, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 23);
            textBox2.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(307, 59);
            button1.Name = "button1";
            button1.Size = new Size(116, 27);
            button1.TabIndex = 39;
            button1.Text = "Pesquisar";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnok
            // 
            btnok.BackColor = Color.YellowGreen;
            btnok.Cursor = Cursors.Hand;
            btnok.FlatAppearance.BorderSize = 0;
            btnok.FlatStyle = FlatStyle.Flat;
            btnok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnok.ForeColor = SystemColors.ButtonFace;
            btnok.ImageAlign = ContentAlignment.MiddleLeft;
            btnok.Location = new Point(646, 53);
            btnok.Name = "btnok";
            btnok.Size = new Size(142, 37);
            btnok.TabIndex = 38;
            btnok.Text = "Novo";
            btnok.UseVisualStyleBackColor = false;
            btnok.Click += btnok_Click;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnok);
            Controls.Add(pnlsup);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(dgvUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            pnlsup.ResumeLayout(false);
            pnlsup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUser;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn wallet;
        private DataGridViewTextBoxColumn TipInv;
        private Panel pnlsup;
        private Button btnfechar;
        private Label label7;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button btnok;
    }
}