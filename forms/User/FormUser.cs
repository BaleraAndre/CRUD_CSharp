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

namespace Teste.forms.User
{
    public partial class FormUser : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public FormUser()
        {
            InitializeComponent();

            Gridload();
        }

        private void Gridload()
        {
            Task.Run(async () =>
            {
                List<entities.Client> clients = await DataAccessObject.Client.ClientDAO.GetAllAsync();

                foreach (entities.Client client in clients)
                {
                    this.Invoke(new Action(() =>
                    {
                        dgvUser.Rows.Add(client.Id, client.Name, client.Phone, client.Email, client.Gender, client.Wallet, client.Type);

                    }));
                }

            });

        }
        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            entities.Client client = null;
            forms.Client.FormRegClient form = new Client.FormRegClient(client);
            form.ShowDialog();
            dgvUser.Rows.Clear();
            Gridload();
        }

        private void btnfechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pnlsup_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
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

        private void btnok_Click(object sender, EventArgs e)
        {
            entities.Client client = null;
            forms.Client.FormRegClient form = new Client.FormRegClient(client);
            form.ShowDialog();
            dgvUser.Rows.Clear();
            Gridload();

        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            entities.Client client = new entities.Client();
            client.Id = (int)dgvUser.SelectedRows[0].Cells[0].Value;
            client.Name = dgvUser.SelectedRows[0].Cells[1].Value.ToString();
            client.Phone = dgvUser.SelectedRows[0].Cells[2].Value.ToString();
            client.Email = dgvUser.SelectedRows[0].Cells[3].Value.ToString();
            client.Gender = dgvUser.SelectedRows[0].Cells[4].Value.ToString();
            client.Wallet = (float)dgvUser.SelectedRows[0].Cells[5].Value;
            client.Type = (enu.InvType.investorType)dgvUser.SelectedRows[0].Cells[6].Value;

            forms.Client.FormRegClient form = new Client.FormRegClient(client);
            form.ShowDialog();
            dgvUser.Rows.Clear();
            Gridload();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            entities.Client client = new entities.Client();
            Task t = Task.Run(async () =>
            {
                client = await DataAccessObject.Client.ClientDAO.GetByNameAsync(client.Name);
            });

            t.Wait();
            if(client != null)
            {
                forms.Client.FormRegClient form = new Client.FormRegClient(client);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não encontrado");
            }
        }
    }
}
