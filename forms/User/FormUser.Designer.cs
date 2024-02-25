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
            dgvUser = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            wallet = new DataGridViewTextBoxColumn();
            TipInv = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnfechar = new Button();
            label7 = new Label();
            btnpesquisar = new Button();
            btnadicionar = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AllowUserToResizeColumns = false;
            dgvUser.AllowUserToResizeRows = false;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Telefone, Email, Sexo, wallet, TipInv });
            dgvUser.Dock = DockStyle.Bottom;
            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.Location = new Point(0, 104);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(800, 346);
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
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnfechar);
            panel2.Controls.Add(label7);
            panel2.Cursor = Cursors.SizeAll;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 44);
            panel2.TabIndex = 31;
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
            btnfechar.Location = new Point(746, 9);
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
            // btnpesquisar
            // 
            btnpesquisar.Location = new Point(319, 61);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(70, 23);
            btnpesquisar.TabIndex = 30;
            btnpesquisar.Text = "Pesquisar";
            btnpesquisar.UseVisualStyleBackColor = true;
            // 
            // btnadicionar
            // 
            btnadicionar.BackColor = Color.FromArgb(255, 192, 128);
            btnadicionar.Cursor = Cursors.Hand;
            btnadicionar.FlatAppearance.BorderSize = 0;
            btnadicionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnadicionar.FlatStyle = FlatStyle.Flat;
            btnadicionar.Location = new Point(675, 61);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(79, 24);
            btnadicionar.TabIndex = 29;
            btnadicionar.Text = "Adicionar";
            btnadicionar.UseVisualStyleBackColor = false;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(31, 62);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 28;
            label2.Text = "Nome:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 23);
            textBox2.TabIndex = 27;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(btnpesquisar);
            Controls.Add(btnadicionar);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(dgvUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Button btnfechar;
        private Label label7;
        private Button btnpesquisar;
        private Button btnadicionar;
        private Label label2;
        private TextBox textBox2;
    }
}