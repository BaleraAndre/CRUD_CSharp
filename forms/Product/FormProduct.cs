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
    public partial class FormProduct : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public FormProduct()
        {
            InitializeComponent();
            gridload();
        }

        private async void gridload()
        {
            List<entities.Product> products = new List<entities.Product>();
            Task t = Task.Run(async () =>
            {
                products = await DataAccessObject.Product.ProductDAO.GetAllAsync();
            });

            t.Wait();

           
            foreach (entities.Product product in products)
            {
                dgvprod.Rows.Add(product.Id, product.Name, product.Description, product.Price, product.Quant, product.Invtype);
            }
        }

        private void btnFechar_Click_2(object sender, EventArgs e)
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            entities.Product prod = null;
            forms.Product.FormRegProduct form = new forms.Product.FormRegProduct(prod);
            form.ShowDialog();
            dgvprod.Rows.Clear();
            gridload();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Task<entities.Product> t = Task.Run(async () =>
            {
                return await DataAccessObject.Product.ProductDAO.GetByNameAsync(txtnome.Text);
            });

            entities.Product product = t.Result;

            if(product != null)
            {
                forms.Product.FormRegProduct form = new FormRegProduct(product);
                form.ShowDialog();           
            }
            


        }
    }
}
