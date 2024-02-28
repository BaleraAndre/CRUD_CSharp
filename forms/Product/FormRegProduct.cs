using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.entities;

namespace Teste.forms.Product
{
    public partial class FormRegProduct : Form
    {
        private Point _dragStartPoint;
        private int _prodid;
        private entities.Product _product;
        public FormRegProduct(entities.Product product)
        {
            _product = product;
            InitializeComponent();
            InitializeDragForm();
            if (product != null)
            {
                txtdescricao.Text = product.Description;
                txtNome.Text = product.Name;
                txtquant.Value = product.Quant;
                txtvalor.Value = (decimal)product.Price;
                cbType.ValueMember = product.Invtype.ToString();
                _prodid = product.Id;

            }
            else { btndeletar.Visible = false; }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click_1(object sender, EventArgs e)
        {
            if (_product != null)
            {
                entities.Product product = new entities.Product();
                product.Name = txtNome.Text;
                product.Description = txtdescricao.Text;
                product.Price = (double)txtvalor.Value;
                product.Quant = (int)txtquant.Value;
                product.Invtype = (enu.InvType.investorType)cbType.SelectedIndex;

                Task t = Task.Run(async () =>
                {
                    await DataAccessObject.Product.ProductDAO.InsertProductAsync(product);
                });

                t.Wait();

                this.Close();
            }
            else
            {
                _product.Name = txtNome.Text;
                _product.Description = txtdescricao.Text;
                _product.Price = (double)txtvalor.Value;
                _product.Quant = (int)txtquant.Value;
                _product.Invtype = (enu.InvType.investorType)cbType.SelectedIndex;

                Task t = Task.Run(async () =>
                {
                    await DataAccessObject.Product.ProductDAO.UpdateAsync(_product);
                });

                t.Wait();

            }
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            Task t = Task.Run(async () =>
            {
                await DataAccessObject.Product.ProductDAO.DeleteProductAsync(_prodid);
            });

            t.Wait();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
