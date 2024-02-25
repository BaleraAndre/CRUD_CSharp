using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste.forms.Product
{
    public partial class FormProduct : Form
    {
        private Point _dragStartPoint;
        public FormProduct()
        {
            InitializeComponent();
            InitializeDragForm();
            gridload();
        }

        private async void gridload()
        {
            List<entities.Product> products = await DataAccessObject.Product.ProductDAO.GetAllAsync();
            foreach (entities.Product product in products)
            {
                dgvprod.Rows.Add(product.Id, product.Name, product.Description, product.Price, product.Quant, product.Invtype);
            }
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
        private void InitializeDragForm()
        {
            this.MouseDown += MainForm_MouseDown;
            this.MouseMove += MainForm_MouseMove;
            this.MouseUp += MainForm_MouseUp;
        }
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {

            _dragStartPoint = Point.Empty;
        }


        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            forms.Client.FormRegClient form = new Client.FormRegClient();
            form.ShowDialog();
        }

        private void btnfechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnovo_Click_1(object sender, EventArgs e)
        {
            forms.Product.FormRegProduct form = new forms.Product.FormRegProduct();
            form.Show();
            dgvprod.Rows.Clear();
            gridload();
        }

        private void btnFechar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
