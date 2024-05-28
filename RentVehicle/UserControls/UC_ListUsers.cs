using RentVehicle.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentVehicle.UserControllers
{
    public partial class UC_ListUsers : UserControl
    {
        private UserManager userManager;
        private int selectedUserId;
        

        public UC_ListUsers()
        {
            InitializeComponent();

            userManager = new UserManager();

            button4.Click += AddUserButton_Click;
            button7.Click += DeleteUserButton_Click;
            button6.Click += ExitConsoleButton_Click;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }
        public void LoadUsers()
        {
           listBox1.Items.Clear();
            foreach (var user in userManager.GetUsers())
            {
                listBox1.Items.Add(user); 
            }
        }
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var Name=textBoxName.Text;
            var Email=textBoxEmail.Text;

            var newUser=new User(Name, Email);
            userManager.AddUser(newUser);

            listBox1.Items.Add(newUser);

            LoadUsers();
            MessageBox.Show("User Added");
        }

        private void DeleteUserButton_Click(Object sender, EventArgs e)
        {
            userManager.DeleteUser(selectedUserId);
            LoadUsers() ;
           
        }
        private void ExitConsoleButton_Click(object? sender, EventArgs e)
        {
            //Application.Exit();
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedUserId = ((User)listBox1.SelectedItem).UserId;
            }
        }
    }
}
