namespace Teste
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pnlsup = new Panel();
            btnFechar = new Button();
            label7 = new Label();
            btnentrar = new Button();
            label1 = new Label();
            pnlsup.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 76);
            label2.Name = "label2";
            label2.Size = new Size(353, 21);
            label2.TabIndex = 1;
            label2.Text = "_________________________________________________";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(45, 150);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(305, 23);
            txtuser.TabIndex = 2;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(45, 212);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(305, 23);
            txtpass.TabIndex = 3;
            txtpass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(45, 132);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(45, 194);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Senha";
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
            pnlsup.Size = new Size(406, 44);
            pnlsup.TabIndex = 37;
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
            btnFechar.Location = new Point(364, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(29, 23);
            btnFechar.TabIndex = 25;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(4, 9);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 25;
            label7.Text = "BEM VINDO";
            // 
            // btnentrar
            // 
            btnentrar.BackColor = Color.YellowGreen;
            btnentrar.Cursor = Cursors.Hand;
            btnentrar.FlatAppearance.BorderSize = 0;
            btnentrar.FlatStyle = FlatStyle.Flat;
            btnentrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnentrar.ForeColor = SystemColors.ButtonFace;
            btnentrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnentrar.Location = new Point(45, 272);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(305, 37);
            btnentrar.TabIndex = 38;
            btnentrar.Text = "Entrar";
            btnentrar.UseVisualStyleBackColor = false;
            btnentrar.Click += btnentrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(163, 62);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 26;
            label1.Text = "Login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 368);
            Controls.Add(label1);
            Controls.Add(pnlsup);
            Controls.Add(btnentrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seja bem vindo !";
            pnlsup.ResumeLayout(false);
            pnlsup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtuser;
        private TextBox txtpass;
        private Label label3;
        private Label label4;
        private Panel pnlsup;
        private Button btnFechar;
        private Label label7;
        private Button btnentrar;
        private Label label1;
    }
}
