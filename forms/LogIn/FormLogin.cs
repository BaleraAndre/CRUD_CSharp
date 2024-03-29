using System.Threading.Tasks;
using Teste.entities;
using Teste.utils;

namespace Teste
{
    public partial class FormLogin : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public FormLogin()
        {
            InitializeComponent();
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

        private async void btnentrar_Click(object sender, EventArgs e)
        {

            

            bool loggedIn = false;
            string senha = Crip.EncryptAccessAsync(txtpass.Text);
            string username = txtuser.Text;
            List<Access> accessList;

            Task<List<Access>> t = Task.Run(async () =>
            {
                return await DataAccessObject.Access.AccessDAO.GetAllAsync();
            });

            accessList = await t;


            Access acs = null;
            foreach (Access access in accessList)
            {
                if (access.User == username && access.Password == senha)
                {
                    acs = access;
                    loggedIn = true;
                    break;
                }
            }

            if (loggedIn)
            {
                
                forms.Menu.FormMenu form = new forms.Menu.FormMenu(acs);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha ou usu�rio inv�lido", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
