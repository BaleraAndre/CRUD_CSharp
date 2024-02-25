using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste.forms.Menu
{
    public partial class FormMenu : Form
    {
        private Point _dragStartPoint;
        public FormMenu()
        {
            InitializeComponent();
            InitializeDragForm();
        }

        private void InitializeDragForm()
        {

            this.MouseDown += MainForm_MouseDown;
            this.MouseMove += MainForm_MouseMove;
            this.MouseUp += MainForm_MouseUp;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                _dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                int deltaX = e.X - _dragStartPoint.X;
                int deltaY = e.Y - _dragStartPoint.Y;


                this.Left += deltaX;
                this.Top += deltaY;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {

            _dragStartPoint = Point.Empty;
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
    }
}

