using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }
        
        #region События формы


        
        //Событие клика по крестику
        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Событие отвода от крестика не надо, так как в событие перемещения формы есть условие, что если не нажата левая кнопка мыши по форме, то Cursor = Cursors.Default;

        //Перемещение формы
        private Point MouseHook;
        private void loginWindowPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                MouseHook = e.Location;
                Cursor = Cursors.Default;
            }
            else
            {
                Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
                Cursor = Cursors.NoMove2D;
            }
        }

        //Клик по кнопке войти
        private void btnSingIn_Click(object sender, EventArgs e)
        {
            string loginText = inputLogin.Text;
            string passwordText = inputPassword.Text;
            Info.personal = new Personal();
            errorLabel.Text = Info.personal.CheckLoginAndPassword(loginText, passwordText);
            if (errorLabel.Text.Length == 0)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();//Прячем главную форму
            }
        }

        #endregion

    }
}
