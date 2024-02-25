namespace Teste.forms.Menu
{
    partial class FormMenu
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
            pnlateral = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnusuario = new Button();
            panel2 = new Panel();
            btnFechar = new Button();
            label7 = new Label();
            pnlateral.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlateral
            // 
            pnlateral.BackColor = Color.FromArgb(224, 224, 224);
            pnlateral.Controls.Add(button2);
            pnlateral.Controls.Add(button1);
            pnlateral.Controls.Add(btnusuario);
            pnlateral.Dock = DockStyle.Left;
            pnlateral.Location = new Point(0, 44);
            pnlateral.Name = "pnlateral";
            pnlateral.Size = new Size(160, 406);
            pnlateral.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 74);
            button2.Name = "button2";
            button2.Size = new Size(160, 37);
            button2.TabIndex = 3;
            button2.Text = "Usuarios";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 37);
            button1.Name = "button1";
            button1.Size = new Size(160, 37);
            button1.TabIndex = 2;
            button1.Text = "Produtos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnusuario
            // 
            btnusuario.BackColor = SystemColors.ActiveCaption;
            btnusuario.Cursor = Cursors.Hand;
            btnusuario.Dock = DockStyle.Top;
            btnusuario.Location = new Point(0, 0);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(160, 37);
            btnusuario.TabIndex = 1;
            btnusuario.Text = "Usuarios";
            btnusuario.UseVisualStyleBackColor = false;
            btnusuario.Click += btnusuario_Click;
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
            panel2.Size = new Size(793, 44);
            panel2.TabIndex = 27;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(5, 7);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 25;
            label7.Text = "Menu";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 450);
            Controls.Add(pnlateral);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            pnlateral.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlateral;
        private Button button2;
        private Button button1;
        private Button btnusuario;
        private Panel panel2;
        private Button btnFechar;
        private Label label7;
    }
}