using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TechServ
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(UserSession.LogIn(tbLogin.Text, tbPassword.Text) != null)
            {
                this.Hide();
                FormMain main = new FormMain();
                //Application.Run(new FormMain());
                main.FormClosed += (object s, FormClosedEventArgs args) => this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("Неверный номер телефона или пароль", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }
    }
}
