using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste.forms.User
{
    public partial class FormUser : Form
    {
        private Point _dragStartPoint;
        public FormUser()
        {
            InitializeComponent();
            InitializeDragForm();
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


        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            forms.Client.FormRegClient form = new Client.FormRegClient();
            form.ShowDialog();
            dgvUser.Rows.Clear();
            Gridload();
        }

        private void btnfechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            forms.Client.FormRegClient form = new Client.FormRegClient();
            form.ShowDialog();
            dgvUser.Rows.Clear();
            Gridload();
        }
    }
}
