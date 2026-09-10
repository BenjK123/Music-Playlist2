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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
           
        }

        BindingList <User> myUsers = new BindingList <User>();
        //serialize a list to a file
        public void WriteDAtaToFile(string listname, BindingList <User> myList)
        {
            FileStream outFile = new FileStream (listname + ".ser", FileMode.Create, FileAccess.Write);

            BinaryFormatter bFormatter = new BinaryFormatter();

            bFormatter.Serialize(outFile, myList);

            outFile.Close();
        }

        public void ReadDAtaToFile(string listname, BindingList<User> myList)
        {
            try
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
            catch(FileNotFoundException)
            {
                MessageBox.Show("The data file could not be found");
            }
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
            myForm.Show();
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

            btnLogin.ForeColor = Color.Black;

            ReadDAtaToFile("users", myUsers);

            bool isFound = false;
            foreach (User u in myUsers)
            {
                if (u.UserName == inputUsername && u.Password == inputPassword)
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                MessageBox.Show("You are now logged in!", "Login Successful");
                this.Hide();
                GoToHome();
               
            }
            else
            {
                MessageBox.Show("Your login details do not exist in the database, try creating a new account!", "User not found");
                GoToSignUp();
            }
        }

        private void pbxDisplay_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
    }
}
