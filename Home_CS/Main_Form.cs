using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Home_CS.POJO.Account;
using Home_CS.POJO;

namespace Home_CS {
    public partial class main_form : Form {
        private UserAccountList accountList = DatabaseConnection.ReadLoginAccounts();

        public main_form() {
            InitializeComponent();
        }

        // ------------------ LOGIN WINDOW STUFF ------------------ //

        /** Attempts to log a user in. */
        private void submit_button_Click(object sender, EventArgs e) {
            string username = username_textbox.Text;
            string password = password_textbox.Text;

            // Check what's in the username field and password field
            if (!(username.Equals("")) || !(password.Equals("")))
            { // if the fields are not empty
                // Update the list
                accountList = DatabaseConnection.ReadLoginAccounts();
                UserAccount checkerAccount = accountList.FindByUsername(username);
                if (checkerAccount != null)
                { // if an account was found

                    // check if the password matches
                    if (checkerAccount.Password.Equals(password))
                    {
                        // Found the account!
                        // Create a new instance of the other form
                        UserAccount_Form userAccount_Form = new UserAccount_Form(checkerAccount);
                        // Hide this form
                        this.Hide();
                        // Show the instance of the UserAccount_Form form.
                        userAccount_Form.ShowDialog();
                        // After "showDialog()" finishes, it will return here
                        this.Show();

                        username_textbox.Text = "";
                        password_textbox.Text = "";
                    }
                    else
                    { // no password found
                        // display an error message
                        // error_label.SetStyle("-fx-text-fill: red");
                        MessageBox.Show("Incorrect password was entered.");
                    }
                }
                else
                { // no username found
                    // display an error message
                    // errorLabel.setStyle("-fx-text-fill: red");
                    MessageBox.Show("Username was not found.");
                }
            }
            else
            {
                // display an error message
                // errorLabel.setStyle("-fx-text-fill: red");
                MessageBox.Show("You must enter text into both fields.");
            }
        }

        /** Runs when the program starts. */
        private void Login_Load(object sender, EventArgs e)
        {
            register_groupbox.Hide();
        }
        
        private void login_showpassword_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (password_textbox.PasswordChar == '*')
            {
                password_textbox.PasswordChar = '\0';
            }
            else
            {
                password_textbox.PasswordChar = Convert.ToChar("*");
            }
        }

        // ------------------ END OF LOGIN WINDOW STUFF ------------------ //

        // ------------------ REGISTER WINDOW STUFF ------------------ //

        /** Register a new account */
        private void submit_register_button_Click(object sender, EventArgs e)
        {
            string username, password, re_enter_password, firstname, lastname;
            int age = 0;

            username = register_username_textbox.Text;
            password = register_password_textbox1.Text;
            re_enter_password = register_password_textbox2.Text;
            firstname = register_firstname_textbox.Text;
            lastname = register_lastname_textbox.Text;
            try
            {
                age = Convert.ToInt32(register_age_textbox.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("All fields must have information in them. Exception: " + exc.Message);
            }

            if (username.Trim().Count() > 0 && password.Trim().Count() > 0 && re_enter_password.Trim().Count() > 0 && password.Equals(re_enter_password) && firstname.Trim().Count() > 0 && lastname.Trim().Count() > 0 && register_age_textbox.Text.Trim().Count() > 0)
            {
                // Update the list
                accountList = DatabaseConnection.ReadLoginAccounts();
                UserAccount checkerAccount = accountList.FindByUsername(username);
                if (checkerAccount != null) // an account was found!
                {
                    MessageBox.Show("Creation failed! An account with that username already exists.");
                }
                else
                {
                    DatabaseConnection.CreateLoginAccount(new UserAccount(username, password, firstname, lastname, age, 0)); // ALWAYS ZERO FOR USER_LEVEL, by default.
                    MessageBox.Show("Account successfully created!");

                    register_groupbox.Hide();
                    login_groupbox.Show();

                    // Update the account list
                    accountList = DatabaseConnection.ReadLoginAccounts();
                }
            }
            else
            {
                MessageBox.Show("All fields must have information in them.");
            }
        }

        /** Cancels registration */
        private void cancel_register_button_Click(object sender, EventArgs e)
        {
            register_groupbox.Hide();
            login_groupbox.Show();

            register_username_textbox.Text = "";
            register_password_textbox1.Text = "";
            register_password_textbox2.Text = "";
            register_firstname_textbox.Text = "";
            register_lastname_textbox.Text = "";
            register_age_textbox.Text = "";
        }

        /** Runs when register button is clicked. */
        private void register_button_Click(object sender, EventArgs e)
        {
            login_groupbox.Hide();
            register_groupbox.Show();
        }

        /** Runs when checkbox 1 is clicked. */
        private void show_password_checbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (register_password_textbox1.PasswordChar == '*')
            {
                register_password_textbox1.PasswordChar = '\0';
            }
            else
            {
                register_password_textbox1.PasswordChar = Convert.ToChar("*");
            }

        }

        /** Runs when checkbox 2 is clicked. */
        private void show_password_checbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (register_password_textbox2.PasswordChar == '*')
            {
                register_password_textbox2.PasswordChar = '\0';
            }
            else
            {
                register_password_textbox2.PasswordChar = Convert.ToChar("*");
            }
        }

        // ------------------ END OF REGISTER WINDOW STUFF ------------------ //

        // ------------------ UNUSED CRAP ------------------ //
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void username_label_p2_Click(object sender, EventArgs e) { }
        private void firstname_label_p2_Click(object sender, EventArgs e) {}
        private void label1_Click_1(object sender, EventArgs e) { }
        private void user_information_groupbox_Enter(object sender, EventArgs e) { }
        private void check_button_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void register_username_label_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void username_textbox_TextChanged(object sender, EventArgs e) { }
        private void password_textbox_TextChanged(object sender, EventArgs e) { }

        // ------------------ END OF UNUSED CRAP ------------------ //
    }
}
