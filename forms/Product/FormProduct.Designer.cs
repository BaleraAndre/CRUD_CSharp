namespace Teste.forms.Product
{
    partial class FormProduct
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
            dgvprod = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            quant = new DataGridViewTextBoxColumn();
            Perfil = new DataGridViewTextBoxColumn();
            btnpesquisar = new Button();
            btnnovo = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnFechar = new Button();
            panel2 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvprod).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvprod
            // 
            dgvprod.AllowUserToAddRows = false;
            dgvprod.AllowUserToDeleteRows = false;
            dgvprod.AllowUserToResizeColumns = false;
            dgvprod.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvprod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvprod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvprod.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Descricao, Valor, quant, Perfil });
            dgvprod.Dock = DockStyle.Bottom;
            dgvprod.Location = new Point(0, 97);
            dgvprod.MultiSelect = false;
            dgvprod.Name = "dgvprod";
            dgvprod.ReadOnly = true;
            dgvprod.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvprod.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvprod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvprod.Size = new Size(800, 353);
            dgvprod.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 30;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descricao.HeaderText = "Descriçao";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // quant
            // 
            quant.HeaderText = "Quantidade";
            quant.Name = "quant";
            quant.ReadOnly = true;
            // 
            // Perfil
            // 
            Perfil.HeaderText = "Perfil";
            Perfil.Name = "Perfil";
            Perfil.ReadOnly = true;
            // 
            // btnpesquisar
            // 
            btnpesquisar.Location = new Point(303, 55);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(70, 23);
            btnpesquisar.TabIndex = 21;
            btnpesquisar.Text = "Pesquisar";
            btnpesquisar.UseVisualStyleBackColor = true;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.FromArgb(255, 192, 128);
            btnnovo.Cursor = Cursors.Hand;
            btnnovo.FlatAppearance.BorderSize = 0;
            btnnovo.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnnovo.FlatStyle = FlatStyle.Flat;
            btnnovo.Location = new Point(659, 55);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(79, 24);
            btnnovo.TabIndex = 20;
            btnnovo.Text = "Adicionar";
            btnnovo.UseVisualStyleBackColor = false;
            btnnovo.Click += btnnovo_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(15, 56);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 19;
            label1.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 18;
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
            btnFechar.Location = new Point(746, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(29, 23);
            btnFechar.TabIndex = 25;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click_2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnFechar);
            panel2.Controls.Add(label7);
            panel2.Cursor = Cursors.SizeAll;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 44);
            panel2.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(4, 9);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 25;
            label7.Text = "Produtos";
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(btnpesquisar);
            Controls.Add(btnnovo);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dgvprod);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)dgvprod).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvprod;
        private Button btnpesquisar;
        private Button btnnovo;
        private Label label1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn quant;
        private DataGridViewTextBoxColumn Perfil;
        private Button btnFechar;
        private Panel panel2;
        private Label label7;
    }
}