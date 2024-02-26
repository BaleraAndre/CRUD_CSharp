namespace Teste.forms.ADM
{
    partial class FormPurchaseListToAprove
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
            dgvlistadecompra = new DataGridView();
            btnFechar = new Button();
            panel2 = new Panel();
            label7 = new Label();
            btnok = new Button();
            label2 = new Label();
            nudsaldodocliente = new NumericUpDown();
            label1 = new Label();
            txtnomedocliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvlistadecompra).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudsaldodocliente).BeginInit();
            SuspendLayout();
            // 
            // dgvlistadecompra
            // 
            dgvlistadecompra.AllowUserToAddRows = false;
            dgvlistadecompra.AllowUserToDeleteRows = false;
            dgvlistadecompra.AllowUserToResizeColumns = false;
            dgvlistadecompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvlistadecompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvlistadecompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistadecompra.Location = new Point(5, 97);
            dgvlistadecompra.MultiSelect = false;
            dgvlistadecompra.Name = "dgvlistadecompra";
            dgvlistadecompra.ReadOnly = true;
            dgvlistadecompra.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvlistadecompra.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvlistadecompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlistadecompra.Size = new Size(783, 341);
            dgvlistadecompra.TabIndex = 36;
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
            panel2.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(4, 9);
            label7.Name = "label7";
            label7.Size = new Size(248, 25);
            label7.TabIndex = 25;
            label7.Text = "Lista de compras em espera";
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
            btnok.TabIndex = 40;
            btnok.Text = "Aprovar";
            btnok.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 39;
            label2.Text = "Saldo do cliente:";
            // 
            // nudsaldodocliente
            // 
            nudsaldodocliente.DecimalPlaces = 2;
            nudsaldodocliente.Location = new Point(140, 59);
            nudsaldodocliente.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudsaldodocliente.Name = "nudsaldodocliente";
            nudsaldodocliente.ReadOnly = true;
            nudsaldodocliente.Size = new Size(120, 23);
            nudsaldodocliente.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(276, 60);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 41;
            label1.Text = "Nome do cliente:";
            // 
            // txtnomedocliente
            // 
            txtnomedocliente.Location = new Point(408, 59);
            txtnomedocliente.Name = "txtnomedocliente";
            txtnomedocliente.ReadOnly = true;
            txtnomedocliente.Size = new Size(180, 23);
            txtnomedocliente.TabIndex = 42;
            // 
            // FormPurchaseListToAprove
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnomedocliente);
            Controls.Add(label1);
            Controls.Add(dgvlistadecompra);
            Controls.Add(panel2);
            Controls.Add(btnok);
            Controls.Add(label2);
            Controls.Add(nudsaldodocliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPurchaseListToAprove";
            Text = "FormPurchaseListToAprove";
            ((System.ComponentModel.ISupportInitialize)dgvlistadecompra).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudsaldodocliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvlistadecompra;
        private Button btnFechar;
        private Panel panel2;
        private Label label7;
        private Button btnok;
        private Label label2;
        private NumericUpDown nudsaldodocliente;
        private Label label1;
        private TextBox txtnomedocliente;
    }
}