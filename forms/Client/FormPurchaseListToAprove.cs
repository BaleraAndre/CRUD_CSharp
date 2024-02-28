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

namespace Teste.forms.ADM
{
    public partial class FormPurchaseListToAprove : Form
    {
        entities.Client _cli = new entities.Client();
        entities.Compra compra = null;
        public FormPurchaseListToAprove(entities.Client client)
        {
            InitializeComponent();
            _cli = client;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GridLoad();
        }

        public void GridLoad()
        {
            
            Task r = Task.Run(async () =>
            {
                compra = await DataAccessObject.Purchase.purchaseDAO.GetPurchaseByClientIdAsync(_cli.Id);



            });
            r.Wait();
            if (compra == null) { MessageBox.Show("Nenhuma compra efetuada"); this.Close(); }

            else
            {
                foreach (entities.ItemDaCompra item in compra.ItemDaCompras)
                {
                    entities.Product prod = null;
                    Task t = Task.Run(async () =>
                    {
                        prod = await DataAccessObject.Product.ProductDAO.GetByIdAsync(item.ProdutoId);



                    });
                    t.Wait();
                    this.Invoke(new Action(() =>
                    {
                        dgvlistadecompra.Rows.Add(compra.Id, item.Quantidade, item.ValorPagoPorUnidade, prod?.Name);
                    }));
                }
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            
            int id = (int)dgvlistadecompra.SelectedRows[0].Cells[0].Value;
            Task r = Task.Run(async () =>
            {
                 await DataAccessObject.Purchase.purchaseDAO.ExcluirCompraPorIdAsync(id);



            });
            r.Wait();
            
        }
    }
}
