using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.entities;

namespace Teste.forms.Client
{
    public partial class FormRegClient : Form
    {

        private int idcli;
        private entities.Client _client;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public FormRegClient(entities.Client client)
        {
            _client = client;
            InitializeComponent();
            if (client != null)
            {
                txtcarteira.Value = (decimal)client.Wallet;
                txtNome.Text = client.Name;
                txtemail.Text = client.Email;
                txtcpf.Text = client.Cpf;
                txttelefone.Text = client.Phone;
                cbType.Text = client.Type.ToString();
                pnlaccess.Visible = false;
                txtcarteira.ReadOnly = true;
                btndeletar.Visible = false;
                idcli = client.Id;
            }
            else
            {
                pnldepositar.Visible = false;
            }

        }


        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click_1(object sender, EventArgs e)
        {
            entities.Access access = new entities.Access();
            access.User = txtusuario.Text;
            if (cbadm.Checked) { access.IsAdmin = true; }
            if (txtsenha.Text == txtconfirmarsenha.Text)
            {
                access.Password = txtsenha.Text;
            }
            else
            {
                MessageBox.Show("As senhas não coincidem. Por favor, insira senhas iguais nos campos 'Senha' e 'Confirmar Senha'.", "Senhas Diferentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtsenha.Clear();
                txtconfirmarsenha.Clear();

                txtsenha.Focus();
                return;
            }

            int accessid = 0;

            Task t = Task.Run(async () =>
            {
                accessid = await DataAccessObject.Access.AccessDAO.InsertAccessAsync(access);
            });

            t.Wait();

            if (accessid == 0)
            {
                return;
            }

            entities.Client client = new entities.Client();
            if (_client == null)
            {
                client.Name = txtNome.Text;
                client.Wallet = (float)txtcarteira.Value;
                client.Email = txtemail.Text;
                client.Cpf = txtcpf.Text;
                client.AccessId = accessid;
                client.Phone = txttelefone.Text;
                client.Type = (enu.InvType.investorType)cbType.SelectedItem;
                if (rbmasc.Checked) { client.Gender = "Male"; }
                else if (rbfem.Checked) { client.Gender = "Female"; }
                else { client.Gender = "Other"; }


                Task t2 = Task.Run(async () =>
                {
                    await DataAccessObject.Client.ClientDAO.InsertClientAsync(client);
                });

                t2.Wait();

                this.Close();
            }
            else
            {
                client.Name = txtNome.Text;
                client.Wallet = (float)txtcarteira.Value;
                client.Email = txtemail.Text;
                client.Cpf = txtcpf.Text;
                client.AccessId = accessid;
                client.Phone = txttelefone.Text;
                if (rbmasc.Checked) { client.Gender = "Male"; }
                else if (rbfem.Checked) { client.Gender = "Female"; }
                else { client.Gender = "Other"; }

                Task t2 = Task.Run(async () =>
                {
                    await DataAccessObject.Client.ClientDAO.UpdateClientAsync(client);
                });

                t2.Wait();

                this.Close();

            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlsup_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlsup_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnlsup_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btndepositar_Click(object sender, EventArgs e)
        {

            float value = (float)nuddepositar.Value;

            Task t = Task.Run(async () =>
            {
                await DataAccessObject.Client.ClientDAO.AddToWalletAsync(idcli, value);
            });

            t.Wait();

            MessageBox.Show("Depósito realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            Task t = Task.Run(async () =>
            {
                await DataAccessObject.Client.ClientDAO.DeleteClientAsync(idcli);
            });

            t.Wait();

            this.Close();
        }
    }
}
