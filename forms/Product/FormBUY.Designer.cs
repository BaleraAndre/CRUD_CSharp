namespace Teste.forms.Product
{
    partial class FormBUY
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
            btnFechar = new Button();
            panel2 = new Panel();
            label7 = new Label();
            nudquant = new NumericUpDown();
            label2 = new Label();
            btnok = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvprod).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudquant).BeginInit();
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(5);
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
            dgvprod.TabIndex = 27;
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
            btnFechar.Click += btnFechar_Click;
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
            panel2.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(4, 9);
            label7.Name = "label7";
            label7.Size = new Size(174, 25);
            label7.TabIndex = 25;
            label7.Text = "Selecionar Produto";
            // 
            // nudquant
            // 
            nudquant.Location = new Point(125, 59);
            nudquant.Name = "nudquant";
            nudquant.Size = new Size(120, 23);
            nudquant.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 34;
            label2.Text = "Quantidade:";
            // 
            // btnok
            // 
            btnok.BackColor = Color.DarkOrange;
            btnok.Cursor = Cursors.Hand;
            btnok.FlatAppearance.BorderSize = 0;
            btnok.FlatStyle = FlatStyle.Flat;
            btnok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnok.ForeColor = SystemColors.ButtonFace;
            btnok.ImageAlign = ContentAlignment.MiddleLeft;
            btnok.Location = new Point(646, 51);
            btnok.Name = "btnok";
            btnok.Size = new Size(142, 37);
            btnok.TabIndex = 35;
            btnok.Text = "Comprar";
            btnok.UseVisualStyleBackColor = false;
            btnok.Click += btnok_Click;
            // 
            // FormBUY
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnok);
            Controls.Add(label2);
            Controls.Add(nudquant);
            Controls.Add(dgvprod);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBUY";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBUY";
            ((System.ComponentModel.ISupportInitialize)dgvprod).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudquant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvprod;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn quant;
        private DataGridViewTextBoxColumn Perfil;
        private Button btnFechar;
        private Panel panel2;
        private Label label7;
        private NumericUpDown nudquant;
        private Label label2;
        private Button btnok;
    }
}