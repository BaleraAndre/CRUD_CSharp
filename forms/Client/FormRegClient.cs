using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste.forms.Client
{
    public partial class FormRegClient : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public FormRegClient()
        {
            InitializeComponent();

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

            accessid = DataAccessObject.Access.AccessDAO.InsertAccessAsync(access).Result;

            if (accessid == 0)
            {
                return;
            }


            entities.Client client = new entities.Client();
            client.Name = txtNome.Text;
            client.Wallet = (float)txtcarteira.Value;
            client.Email = txtemail.Text;
            client.Cpf = txtcpf.Text;
            client.AccessId = accessid;
            if (rbmasc.Checked) { client.Gender = "Masculino"; }
            else if (rbfem.Checked) { client.Gender = "Feminino"; }
            else { client.Gender = "Outro"; }


            DataAccessObject.Client.ClientDAO.InsertClientAsync(client);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
    }
}
