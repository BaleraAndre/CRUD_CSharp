namespace Teste.forms.Product
{
    partial class FormRegProduct
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
            panel1 = new Panel();
            txtquant = new NumericUpDown();
            label4 = new Label();
            label12 = new Label();
            cbType = new ComboBox();
            txtvalor = new NumericUpDown();
            label11 = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            txtdescricao = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label7 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            btnok = new Button();
            btndeletar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtquant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtvalor).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtquant);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(cbType);
            panel1.Controls.Add(txtvalor);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtdescricao);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 299);
            panel1.TabIndex = 25;
            // 
            // txtquant
            // 
            txtquant.Location = new Point(373, 147);
            txtquant.Name = "txtquant";
            txtquant.Size = new Size(107, 23);
            txtquant.TabIndex = 33;
            txtquant.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(274, 150);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 32;
            label4.Text = "Quantidade:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label12.Location = new Point(61, 206);
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
            cbType.Location = new Point(118, 205);
            cbType.Name = "cbType";
            cbType.Size = new Size(126, 23);
            cbType.TabIndex = 28;
            // 
            // txtvalor
            // 
            txtvalor.DecimalPlaces = 2;
            txtvalor.Location = new Point(118, 147);
            txtvalor.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(126, 23);
            txtvalor.TabIndex = 27;
            txtvalor.ThousandsSeparator = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label11.Location = new Point(54, 150);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 26;
            label11.Text = "Valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(47, 47);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 13;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(118, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(362, 23);
            txtNome.TabIndex = 18;
            // 
            // txtdescricao
            // 
            txtdescricao.BorderStyle = BorderStyle.FixedSingle;
            txtdescricao.Location = new Point(116, 94);
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(364, 23);
            txtdescricao.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(31, 94);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 14;
            label2.Text = "Descrição:";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(718, 9);
            button2.Name = "button2";
            button2.Size = new Size(29, 23);
            button2.TabIndex = 25;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(4, 9);
            label7.Name = "label7";
            label7.Size = new Size(188, 25);
            label7.TabIndex = 25;
            label7.Text = "Cadastro de produto";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label7);
            panel2.Cursor = Cursors.SizeAll;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 44);
            panel2.TabIndex = 28;
            // 
            // button3
            // 
            button3.BackColor = Color.Salmon;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(624, 349);
            button3.Name = "button3";
            button3.Size = new Size(142, 37);
            button3.TabIndex = 31;
            button3.Text = "Voltar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            btnok.Location = new Point(476, 349);
            btnok.Name = "btnok";
            btnok.Size = new Size(142, 37);
            btnok.TabIndex = 29;
            btnok.Text = "Salvar";
            btnok.UseVisualStyleBackColor = false;
            btnok.Click += btnok_Click_1;
            // 
            // btndeletar
            // 
            btndeletar.BackColor = Color.Goldenrod;
            btndeletar.Cursor = Cursors.Hand;
            btndeletar.FlatAppearance.BorderSize = 0;
            btndeletar.FlatStyle = FlatStyle.Flat;
            btndeletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndeletar.ForeColor = SystemColors.ButtonFace;
            btndeletar.ImageAlign = ContentAlignment.MiddleLeft;
            btndeletar.Location = new Point(328, 349);
            btndeletar.Name = "btndeletar";
            btndeletar.Size = new Size(142, 37);
            btndeletar.TabIndex = 32;
            btndeletar.Text = "Deletar";
            btndeletar.UseVisualStyleBackColor = false;
            btndeletar.Click += btndeletar_Click;
            // 
            // FormRegProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(772, 396);
            Controls.Add(btndeletar);
            Controls.Add(button3);
            Controls.Add(btnok);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegProduct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtquant).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtvalor).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label12;
        private ComboBox cbType;
        private NumericUpDown txtvalor;
        private Label label11;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtdescricao;
        private Label label2;
        private NumericUpDown txtquant;
        private Label label4;
        private Button button2;
        private Label label7;
        private Panel panel2;
        private Button button3;
        private Button btnok;
        private Button btndeletar;
    }
}