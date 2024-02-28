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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgvprod = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            quant = new DataGridViewTextBoxColumn();
            Perfil = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtnome = new TextBox();
            btnFechar = new Button();
            pnlsup = new Panel();
            label7 = new Label();
            btnok = new Button();
            btnpesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvprod).BeginInit();
            pnlsup.SuspendLayout();
            SuspendLayout();
            // 
            // dgvprod
            // 
            dgvprod.AllowUserToAddRows = false;
            dgvprod.AllowUserToDeleteRows = false;
            dgvprod.AllowUserToResizeColumns = false;
            dgvprod.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.PapayaWhip;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvprod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvprod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvprod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvprod.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Descricao, Valor, quant, Perfil });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvprod.DefaultCellStyle = dataGridViewCellStyle7;
            dgvprod.Location = new Point(12, 93);
            dgvprod.MultiSelect = false;
            dgvprod.Name = "dgvprod";
            dgvprod.ReadOnly = true;
            dgvprod.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvprod.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvprod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvprod.Size = new Size(776, 345);
            dgvprod.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 35;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(15, 60);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 19;
            label1.Text = "Nome:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(74, 59);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(223, 23);
            txtnome.TabIndex = 18;
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
            btnFechar.Location = new Point(765, 8);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(29, 23);
            btnFechar.TabIndex = 25;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click_2;
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
            pnlsup.Size = new Size(800, 44);
            pnlsup.TabIndex = 26;
            pnlsup.MouseDown += pnlsup_MouseDown;
            pnlsup.MouseMove += pnlsup_MouseMove;
            pnlsup.MouseUp += pnlsup_MouseUp;
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
            // btnok
            // 
            btnok.BackColor = Color.YellowGreen;
            btnok.Cursor = Cursors.Hand;
            btnok.FlatAppearance.BorderSize = 0;
            btnok.FlatStyle = FlatStyle.Flat;
            btnok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnok.ForeColor = SystemColors.ButtonFace;
            btnok.ImageAlign = ContentAlignment.MiddleLeft;
            btnok.Location = new Point(646, 52);
            btnok.Name = "btnok";
            btnok.Size = new Size(142, 37);
            btnok.TabIndex = 36;
            btnok.Text = "Novo";
            btnok.UseVisualStyleBackColor = false;
            btnok.Click += btnNovo_Click;
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.DodgerBlue;
            btnpesquisar.Cursor = Cursors.Hand;
            btnpesquisar.FlatAppearance.BorderSize = 0;
            btnpesquisar.FlatStyle = FlatStyle.Flat;
            btnpesquisar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpesquisar.ForeColor = SystemColors.ButtonFace;
            btnpesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnpesquisar.Location = new Point(303, 57);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(116, 27);
            btnpesquisar.TabIndex = 37;
            btnpesquisar.Text = "Pesquisar";
            btnpesquisar.TextAlign = ContentAlignment.TopCenter;
            btnpesquisar.UseVisualStyleBackColor = false;
            btnpesquisar.Click += btnpesquisar_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnpesquisar);
            Controls.Add(btnok);
            Controls.Add(pnlsup);
            Controls.Add(label1);
            Controls.Add(txtnome);
            Controls.Add(dgvprod);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)dgvprod).EndInit();
            pnlsup.ResumeLayout(false);
            pnlsup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvprod;
        private Label label1;
        private TextBox txtnome;
        private Button btnFechar;
        private Panel pnlsup;
        private Label label7;
        private Button btnok;
        private Button btnpesquisar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn quant;
        private DataGridViewTextBoxColumn Perfil;
    }
}