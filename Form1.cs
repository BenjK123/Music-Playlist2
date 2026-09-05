using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Music_Playlist_Manager_Group42
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
           
        }

        public void GoToSignUp()
        {
            this.Hide();

            frmSignUp myForm = new frmSignUp();
            myForm.ShowDialog();

            this.Show();
        }

        public void GoToHome()
        {

          frmHome myForm = new frmHome(txtUsername.Text);
          myForm.ShowDialog();

            this.Show();
            this.Hide();
        }

        private void btnGoToSignUp_Click_1(object sender, EventArgs e)
        {
            GoToSignUp();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;


            if (inputUsername == "" || inputPassword == "")
            {
                MessageBox.Show("Please enter a username or a password");
                return;
            }
            else
            {
                btnLogin.ForeColor = Color.Black;

                try
                {
                    StreamReader inputFile = new StreamReader("users.txt");
                    String userNameLine = inputFile.ReadLine();
                    String passwordLine = inputFile.ReadLine();
                    bool isFound = false;

                    while (userNameLine != null && passwordLine != null)
                    {

                        if (inputUsername == userNameLine && inputPassword == passwordLine)
                        {
                            isFound = true;
                            break;
                        }
                        else
                        {
                            userNameLine = inputFile.ReadLine();
                            passwordLine = inputFile.ReadLine();
                        }

                    }
                    inputFile.Close();

                    if (isFound == true)
                    {
                        MessageBox.Show("You are now logged in!", "Login Successful");
                        GoToHome();
                    }
                    else
                    {
                        MessageBox.Show("Your login details do not exist in the database, try creating a new account!", "User not found");
                    }
                }


                catch (Exception generalException)
                {
                    MessageBox.Show("Error: \n" + generalException.Message);
                }

            }

        }

        private void pbxDisplay_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
    }
}
