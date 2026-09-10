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
        BindingList<User> myUsers = new BindingList<User>();
        public void WriteDataToFile(string listname, BindingList<User> myList)
        {
            FileStream outFile = new FileStream(listname + ".ser", FileMode.Create, FileAccess.Write);

            BinaryFormatter bFormatter = new BinaryFormatter();

            bFormatter.Serialize(outFile, myList);

            outFile.Close();
        }

        public void ReadDataToFile(string listname, BindingList<User> myList)
        {
            try
            {
                string targetFile = listname + ".ser";
                // Simple check to make sure the file exists before creating the stream
                if (File.Exists(targetFile))
                {
                    FileStream inFile = new FileStream(listname + ".ser", FileMode.Open, FileAccess.Read);

                    BinaryFormatter bFormatter = new BinaryFormatter();

                    myList.Clear();

                    var tempList = (BindingList<User>)bFormatter.Deserialize(inFile);

                    foreach (User myObject in tempList)
                    {
                        myList.Add(myObject);

                    }

                    inFile.Close();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The data file could not be found");
            }
        }
        public frmSignUp()
        {
            InitializeComponent();
            ReadDataToFile("users", myUsers);
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
            foreach (User u in myUsers)
            {
                if (u.UserName == username)
                {
                    return true;
                }
            }
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

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter both your username and password!");
                return;
            }
            else if (txtConfirmPassword.Text != password)
            {
                MessageBox.Show("Confirmation password does not match original password, please try again");
                return;
            }

            if (!CheckPass(password))
            {
                MessageBox.Show("Your password is not secure.");
                return;
            }

            if (UserExists(username))
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            User newUser = new User();
            newUser.UserName = username;
            newUser.Password = password;
            myUsers.Add(newUser);
            WriteDataToFile("users", myUsers);

            MessageBox.Show("Registration successful!");
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            GoToLogin();
        }

        private void pbxDisplay_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            txtConfirmPassword.UseSystemPasswordChar = false;
        }
    }
}
