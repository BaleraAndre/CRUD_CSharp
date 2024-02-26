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

            Access access1 = new Access();
            access1.Id = 1;
            access1.User = "Andre marino";
            access1.Password = "password";
            access1.IsAdmin = false;

            bool loggedIn = true;
           /* string senha = Crip.EncryptAccessAsync(txtpass.Text);
            string username = txtuser.Text;
            List<Access> accessList = DataAccessObject.Access.AccessDAO.GetAllAsync().Result;
            

            foreach (Access access in accessList)
            {
                if (access.User == username && access.Password == senha)
                {
                    loggedIn = true;
                    break;
                }
            }*/

            if (loggedIn)
            {
               // Access access = await DataAccessObject.Access.AccessDAO.GetByUsernameAsync(username);
                forms.Menu.FormMenu form = new forms.Menu.FormMenu(access1);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha ou usuário inválido", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
