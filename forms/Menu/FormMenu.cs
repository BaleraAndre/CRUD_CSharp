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
        private entities.Client _cli;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private readonly Access _access;

        public FormMenu(Access access)
        {
            InitializeComponent();
            this._access = access;
            Task.Run(async () =>
            {
                _cli = await DataAccessObject.Client.ClientDAO.GetByAccessIdAsync(_access.Id);
            });
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
            forms.Product.FormBUY form = new Product.FormBUY(_cli);
            form.ShowDialog();
        }

        private void btnmeuperfil_Click(object sender, EventArgs e)
        {
            forms.Client.FormRegClient form = new Client.FormRegClient(_cli);
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            forms.ADM.FormPurchaseListToAprove form = new forms.ADM.FormPurchaseListToAprove(_cli);
            form.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (!_access.IsAdmin)
            {
                btnusuario.Visible = false;
                btnprod.Visible = false;
                btnmeuperfil.Location = btnusuario.Location;
                btncomprar.Location = btnprod.Location;              
                lblmsg.Text = $"Bem vindo, {_access.User} ! (Usuario)";
                
            }
            else
            {
                lblmsg.Text = $"Bem vindo, {_access.User} ! (ADM)";
                btncomprar.Visible = false;
                btnmeuperfil .Visible = false;
                btnminhascompras.Visible = false;

            };

            Task.Run(async () =>
            {
                _cli = await  DataAccessObject.Client.ClientDAO.GetByAccessIdAsync(_access.Id);
            });

            
        }
    }
}

