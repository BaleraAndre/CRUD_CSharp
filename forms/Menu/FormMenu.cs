using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.entities;

namespace Teste.forms.Menu
{
    public partial class FormMenu : Form
    {
        private entities.Client cli;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public FormMenu(Access access)
        {
            InitializeComponent();
            if (!access.IsAdmin)
            {
                btnusuario.Visible = false;
                btnprod.Visible = false;
                lblmsg.Text = $"Bem vindo, ${access.User} ! (Usuario)";
            }
            else
            {
                lblmsg.Text = $"Bem vindo, ${access.User} ! (ADM)";
                btncomprar.Visible = false;
            };

            cli = DataAccessObject.Client.ClientDAO.GetByAccessIdAsync(access.Id).Result;

        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            forms.User.FormUser form = new User.FormUser();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forms.Product.FormProduct form = new Product.FormProduct();
            form.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlsup_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlsup_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlsup_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btncomprar_Click_1(object sender, EventArgs e)
        {
            forms.Product.FormBUY form = new Product.FormBUY(cli);
            form.ShowDialog();
        }

        private void btnmeuperfil_Click(object sender, EventArgs e)
        {
            forms.Client.FormRegClient form = new Client.FormRegClient(cli);
            form.ShowDialog();
        }
    }
}

