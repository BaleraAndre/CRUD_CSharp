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
    public partial class FormBUY : Form
    {
        public FormBUY(Access access)
        {
            InitializeComponent();
            string tpe = access.Type.ToString();
            gridload(access,tpe);
        }

        private async void gridload(Access access,string str)
        {
            List<entities.Product> products = await DataAccessObject.Product.ProductDAO.GetAllAsync();
            foreach (entities.Product product in products)
            {
                if(access.Type.ToString() == str)
                dgvprod.Rows.Add(product.Id, product.Name, product.Description, product.Price, product.Quant, product.Invtype);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            if (nudquant.Value <= 0)
            {
                MessageBox.Show("Informe a quantidade a ser comprada", "Erro", MessageBoxButtons.OK);
                return;
            }
            
            entities.Product product = new entities.Product();

            product.Id = (int)dgvprod.SelectedRows[0].Cells[0].Value;
            product.Name = dgvprod.SelectedRows[0].Cells[1].Value.ToString();
            product.Description = dgvprod.SelectedRows[0].Cells[2].Value.ToString();
            product.Price = (double)dgvprod.SelectedRows[0].Cells[3].Value;
            product.Quant = (int)dgvprod.SelectedRows[0].Cells[4].Value;
            product.Invtype = (enu.InvType.investorType)dgvprod.SelectedRows[0].Cells[5].Value;

            if (product.Quant < nudquant.Value)
            {
                MessageBox.Show("Quantidade indisponivel", "Erro", MessageBoxButtons.OK);
                return;
            }


        }
    }
}
