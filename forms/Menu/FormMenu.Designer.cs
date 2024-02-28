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
            btnminhascompras = new Button();
            btnmeuperfil = new Button();
            btncomprar = new Button();
            btnprod = new Button();
            btnusuario = new Button();
            pnlsup = new Panel();
            btnFechar = new Button();
            label7 = new Label();
            panel1 = new Panel();
            lblmsg = new Label();
            pnlateral.SuspendLayout();
            pnlsup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlateral
            // 
            pnlateral.BackColor = Color.FromArgb(224, 224, 224);
            pnlateral.Controls.Add(btnminhascompras);
            pnlateral.Controls.Add(btnmeuperfil);
            pnlateral.Controls.Add(btncomprar);
            pnlateral.Controls.Add(btnprod);
            pnlateral.Controls.Add(btnusuario);
            pnlateral.Dock = DockStyle.Left;
            pnlateral.Location = new Point(0, 44);
            pnlateral.Name = "pnlateral";
            pnlateral.Padding = new Padding(2);
            pnlateral.Size = new Size(206, 370);
            pnlateral.TabIndex = 0;
            // 
            // btnminhascompras
            // 
            btnminhascompras.BackColor = Color.Goldenrod;
            btnminhascompras.Cursor = Cursors.Hand;
            btnminhascompras.FlatAppearance.BorderSize = 0;
            btnminhascompras.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnminhascompras.FlatStyle = FlatStyle.Flat;
            btnminhascompras.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnminhascompras.ForeColor = SystemColors.ButtonFace;
            btnminhascompras.Location = new Point(6, 176);
            btnminhascompras.Margin = new Padding(5);
            btnminhascompras.Name = "btnminhascompras";
            btnminhascompras.Size = new Size(193, 37);
            btnminhascompras.TabIndex = 5;
            btnminhascompras.Text = "Minhas compras";
            btnminhascompras.UseVisualStyleBackColor = false;
            btnminhascompras.Click += button1_Click_1;
            // 
            // btnmeuperfil
            // 
            btnmeuperfil.BackColor = Color.Goldenrod;
            btnmeuperfil.Cursor = Cursors.Hand;
            btnmeuperfil.FlatAppearance.BorderSize = 0;
            btnmeuperfil.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnmeuperfil.FlatStyle = FlatStyle.Flat;
            btnmeuperfil.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnmeuperfil.ForeColor = SystemColors.ButtonFace;
            btnmeuperfil.Location = new Point(6, 133);
            btnmeuperfil.Margin = new Padding(5);
            btnmeuperfil.Name = "btnmeuperfil";
            btnmeuperfil.Size = new Size(193, 37);
            btnmeuperfil.TabIndex = 4;
            btnmeuperfil.Text = "Minha carteira";
            btnmeuperfil.UseVisualStyleBackColor = false;
            btnmeuperfil.Click += btnmeuperfil_Click;
            // 
            // btncomprar
            // 
            btncomprar.BackColor = Color.Goldenrod;
            btncomprar.Cursor = Cursors.Hand;
            btncomprar.FlatAppearance.BorderSize = 0;
            btncomprar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btncomprar.FlatStyle = FlatStyle.Flat;
            btncomprar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btncomprar.ForeColor = SystemColors.ButtonFace;
            btncomprar.Location = new Point(6, 90);
            btncomprar.Margin = new Padding(5);
            btncomprar.Name = "btncomprar";
            btncomprar.Size = new Size(193, 37);
            btncomprar.TabIndex = 3;
            btncomprar.Text = "Comprar";
            btncomprar.UseVisualStyleBackColor = false;
            btncomprar.Click += btncomprar_Click_1;
            // 
            // btnprod
            // 
            btnprod.BackColor = Color.Goldenrod;
            btnprod.Cursor = Cursors.Hand;
            btnprod.FlatAppearance.BorderSize = 0;
            btnprod.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnprod.FlatStyle = FlatStyle.Flat;
            btnprod.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnprod.ForeColor = SystemColors.ButtonFace;
            btnprod.Location = new Point(6, 48);
            btnprod.Margin = new Padding(5);
            btnprod.Name = "btnprod";
            btnprod.Size = new Size(193, 37);
            btnprod.TabIndex = 2;
            btnprod.Text = "Produtos";
            btnprod.UseVisualStyleBackColor = false;
            btnprod.Click += button1_Click;
            // 
            // btnusuario
            // 
            btnusuario.BackColor = Color.Goldenrod;
            btnusuario.Cursor = Cursors.Hand;
            btnusuario.FlatAppearance.BorderSize = 0;
            btnusuario.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnusuario.FlatStyle = FlatStyle.Flat;
            btnusuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnusuario.ForeColor = SystemColors.ButtonFace;
            btnusuario.Location = new Point(6, 7);
            btnusuario.Margin = new Padding(5);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(193, 37);
            btnusuario.TabIndex = 1;
            btnusuario.Text = "Usuarios";
            btnusuario.UseVisualStyleBackColor = false;
            btnusuario.Click += btnusuario_Click;
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
            pnlsup.Size = new Size(793, 44);
            pnlsup.TabIndex = 27;
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
            btnFechar.Location = new Point(754, 9);
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblmsg);
            panel1.Dock = DockStyle.Bottom;
            panel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 36);
            panel1.TabIndex = 28;
            // 
            // lblmsg
            // 
            lblmsg.AutoSize = true;
            lblmsg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmsg.ForeColor = SystemColors.ActiveCaptionText;
            lblmsg.Location = new Point(8, 11);
            lblmsg.Name = "lblmsg";
            lblmsg.Size = new Size(193, 15);
            lblmsg.TabIndex = 26;
            lblmsg.Text = "Usuario: Andre Marino Balera (Dev)";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 450);
            Controls.Add(pnlateral);
            Controls.Add(pnlsup);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += FormMenu_Load;
         
            pnlateral.ResumeLayout(false);
            pnlsup.ResumeLayout(false);
            pnlsup.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlateral;
        private Button btnprod;
        private Button btnusuario;
        private Panel pnlsup;
        private Button btnFechar;
        private Label label7;
        private Panel panel1;
        private Label lblmsg;
        private Button btncomprar;
        private Button btnmeuperfil;
        private Button btnminhascompras;
    }
}