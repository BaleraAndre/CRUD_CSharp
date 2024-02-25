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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEntrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 40);
            label2.Name = "label2";
            label2.Size = new Size(353, 21);
            label2.TabIndex = 1;
            label2.Text = "_________________________________________________";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 23);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 297);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 71);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(299, 20);
            button1.Name = "button1";
            button1.Size = new Size(129, 38);
            button1.TabIndex = 8;
            button1.Text = "Cadastra-se";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(147, 27);
            label5.Name = "label5";
            label5.Size = new Size(146, 21);
            label5.TabIndex = 0;
            label5.Text = "Não possui cadastro?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(61, 88);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(61, 150);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.DodgerBlue;
            btnEntrar.FlatAppearance.BorderColor = Color.Black;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonFace;
            btnEntrar.Location = new Point(61, 225);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(305, 37);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Logar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 368);
            Controls.Add(btnEntrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seja bem vindo !";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Button btnEntrar;
        private Button button1;
        private Label label5;
    }
}
