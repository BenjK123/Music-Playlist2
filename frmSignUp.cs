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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Music_Playlist_Manager_Group42
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }
        //Checking if the password is strong.
            private bool CheckPass(string pass)
            {
                bool number = false;
                bool uppercase = false;
                bool symbol = false;

                for (int i = 0; i < pass.Length; i++)
                {
                    if (char.IsDigit(pass[i]))
                    {
                        number = true;
                    }
                    else if (char.IsUpper(pass[i]))
                    {
                        uppercase = true;
                    }
                    else if (char.IsSymbol(pass[i]) || char.IsPunctuation(pass[i]))
                    {
                        symbol = true;
                    }
                }

                if (number && uppercase && symbol)
                {
                    return true;
                }
                else
                {
                    return false;
                }
             }
    private bool UserExists(string username)
        {
            if (!File.Exists("users.txt"))
            {
                return false;
            }
            StreamReader sr = new StreamReader("users.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {

                if (line == username)
                {
                    sr.Close();
                    return true;
                }

            }
            sr.Close();
            return false;
        }



        //Then we go back to the login page.
        public void GoToLogin()
        {
            this.Hide();

            frmLogin myForm = new frmLogin();
            myForm.ShowDialog();

            this.Show();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            GoToLogin();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter both your username and password!");
                return; 

            }
            else if (confirmPassword != password)
            {
                MessageBox.Show("Confirmation password does not match original password, please try again");
                return;
            }

            if (CheckPass(password))
            {
                MessageBox.Show("Your password is secure!");
            }
            else
            {
                MessageBox.Show("Your password is not secure.");
                return;
            }

            // checking if the user already exits and saving the uses name.
            if (UserExists(username))
            {
                MessageBox.Show("Username already exits.");
                return;
            }

            try
            {
                //Using true to keep whats in the text file, and add more information.
                using (StreamWriter writer = new StreamWriter("users.txt", true))
                {
                    writer.WriteLine(txtUsername.Text);
                    writer.WriteLine(txtPassword.Text);
                }

                MessageBox.Show("Registration successful!");

                txtUsername.Clear();
                txtPassword.Clear();
            }

            //Handles
            catch (Exception Ex)
            {
                MessageBox.Show("An error ocurred:" + Ex.Message);
            }

            GoToLogin();
        
        }

        private void pbxDisplay_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            txtConfirmPassword.UseSystemPasswordChar = false;
        }
    }
}
