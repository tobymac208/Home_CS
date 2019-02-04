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
using Home_CS.POJO.Quiz;
using Home_CS.POJO;

namespace Home_CS
{
    public partial class UserAccount_Form : Form
    {
        private UserAccount userAccountLoggedIn;
        private Quiz theQuiz;
        private UserAccountList allUserAccounts;

        public UserAccount_Form(object obj)
        {
            if ((obj.GetType()) == typeof(UserAccount))
            {
                userAccountLoggedIn = (UserAccount)obj;
            }
            InitializeComponent();
        }

        private void UserAccount_Form_Load(object sender, EventArgs e)
        {
            if (userAccountLoggedIn.User_Level == 1)
            {
                remove_account_button.Show();
            }
            else
            {
                remove_account_button.Hide();
            }

            // Show the first panel
            ShowGroupBox(1);

            updateFields();

            // load in the quiz
            theQuiz = new Quiz(DatabaseConnection.ReadQuizItems());

            quiz_question_label.Text = theQuiz.GetQuestion();
        }

        // ------------------ MODIFICATION WINDOW ------------------ //

        /** Called, when the user clicks the "Save" button */
        private void save_changes_button_Click(object sender, EventArgs e)
        {
            // Check all of the textboxes. Making sure they have something in them, before changing the value.
            if (changed_password_label.Text.Trim().Count() > 0)
            {
                if (changed_password_label.Text.Trim().Count() >= 5)
                {
                    userAccountLoggedIn.Password = changed_password_label.Text;
                    ExitModifySettingsPanel();
                }
                else
                {
                    MessageBox.Show("Password must have at least 5 characters.");
                }
            }
            if (changed_firstname_label.Text.Trim().Count() > 0)
            {
                userAccountLoggedIn.FirstName = changed_firstname_label.Text;
                ExitModifySettingsPanel();
            }
            if (changed_lastname_label.Text.Trim().Count() > 0)
            {
                userAccountLoggedIn.LastName = changed_lastname_label.Text;
                ExitModifySettingsPanel();
            }
            if (changed_age_label.Text.Trim().Count() > 0)
            {
                userAccountLoggedIn.Age = Convert.ToInt32(changed_age_label.Text);
                ExitModifySettingsPanel();
            }
        }

        /** Updates the database, and clears all of the fields. */
        private void ExitModifySettingsPanel()
        {
            DatabaseConnection.UpdateLoginAccount(userAccountLoggedIn);

            ShowGroupBox(1);

            updateFields();
        }

        // ------------------ END OF MODIFICATION WINDOW ------------------ //

        // ------------------ QUIZ WINDOW ------------------ //

        /** Cancel's the quiz that's currently being taken. */
        private void quiz_cancel_button_Click(object sender, EventArgs e)
        {
            ShowGroupBox(1);
        }

        /** Called when the "True" button is clicked. */
        private void button1_Click(object sender, EventArgs e)
        {
            String theAnswer = theQuiz.GetAnswer().ToLower();
            if (theAnswer.Equals("true"))
            {
                theQuiz.AddCorrect();
            }
            else if (theAnswer.Equals("false"))
            {
                theQuiz.AddIncorrect();
            }
            // print out the results to the user
            quiz_notification_label.Text = "Correct: " + theQuiz.NumberCorrect + ", Incorrect: " + theQuiz.NumberIncorrect;
            quiz_notification_label.Text = theQuiz.GetQuestion();
        }

        /** Called when the "False" button is clicked. */
        private void quiz_false_button_Click(object sender, EventArgs e)
        {
            String theAnswer = theQuiz.GetAnswer().ToLower();
            if (theAnswer.Equals("false"))
            {
                theQuiz.AddCorrect();
            }
            else if (theAnswer.Equals("true"))
            {
                theQuiz.AddIncorrect();
            }


            // print out the results to the user
            quiz_notification_label.Text = "Correct: " + theQuiz.NumberCorrect + ", Incorrect: " + theQuiz.NumberIncorrect;
            quiz_notification_label.Text = theQuiz.GetQuestion();
        }

        /** Runs when the "Quiz" button has been clicked. */
        private void daily_quiz_button_Click(object sender, EventArgs e)
        {
            ShowGroupBox(4);
        }

        // ------------------ END OF QUIZ WINDOW ------------------ //

        // ------------------ REMOVE ACCOUNT WINDOW ------------------ //
        /** Called when an admin is trying to remove an account */

        private void remove_acount_submit_button_Click(object sender, EventArgs e)
        {
            string selected = (string)remove_account_account_selection.SelectedItem;
            if (selected != null)
            {
                UserAccountList temporaryList = DatabaseConnection.ReadLoginAccounts();
                UserAccount temporaryUser = temporaryList.FindByUsername(selected);
                DatabaseConnection.RemoveLoginAccount(temporaryUser);

                MessageBox.Show("Account removed, with username '" + selected + "'!");

                ShowGroupBox(1);
            }
            else
            {
                MessageBox.Show("You MUST select an account to remove.");
            }
        }

        // ------------------ END OF REMOVE ACCOUNT WINDOW ------------------ //

        // ------------------ USER ACCOUNT UTILITY ------------------ //

        /** Accepts a number, ranging from 1 - 4.
         * 1 = User Settings
           2 = Modify settings
           3 = Remove Account 
           4 = Daily Quiz */
        private void ShowGroupBox(int choice)
        {
            switch (choice)
            {
                case 1: // to see the user's information
                    user_information_groupbox.Show();

                    remove_account_groupbox.Hide();
                    modify_settings_groupbox.Hide();
                    daily_quiz_groupbox.Hide();
                    break;
                case 2: // to modify the current user's settings
                    modify_settings_groupbox.Show();
                    
                    remove_account_groupbox.Hide();
                    user_information_groupbox.Hide();
                    daily_quiz_groupbox.Hide();
                    break;
                case 3: // to remove an account
                    remove_account_groupbox.Show();

                    modify_settings_groupbox.Hide();
                    user_information_groupbox.Hide();
                    daily_quiz_groupbox.Hide();
                    break;
                case 4: // for the daily quiz
                    daily_quiz_groupbox.Show();

                    remove_account_groupbox.Hide();
                    modify_settings_groupbox.Hide();
                    user_information_groupbox.Hide();
                    break;
                default:
                    Console.WriteLine("That was not an option.");
                    break;
            }
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close(); // close this window
        }

        /** Update all of the fields */
        private void updateFields()
        {
            // Items for display settings
            actual_username_label.Text = userAccountLoggedIn.Username;
            actual_password_label.Text = userAccountLoggedIn.Password;
            actual_firstname_label.Text = userAccountLoggedIn.FirstName;
            actual_lastname_label.Text = userAccountLoggedIn.LastName;
            actual_age_label.Text = userAccountLoggedIn.Age + "";

            // Items for modifying settings
            settings_username_label.Text = userAccountLoggedIn.Username;
            settings_password_label.Text = userAccountLoggedIn.Password;
            settings_firstname_label.Text = userAccountLoggedIn.FirstName;
            settings_lastname_label.Text = userAccountLoggedIn.LastName;
            settings_age_label.Text = userAccountLoggedIn.Age + "";
        }

        private void user_information_button_Click(object sender, EventArgs e)
        {
            ShowGroupBox(1); // show user information window
        }

        /** Runs functionality, when "Modify Settings" is clicked. */
        private void change_settings_button_Click(object sender, EventArgs e)
        {
            // Show the "change settings" window
            ShowGroupBox(2);
            // Update the fields fields
            updateFields();
        }

        private void remove_account_button_Click(object sender, EventArgs e)
        {
            // Switch to the "remove account" panel
            ShowGroupBox(3);

            // load in the accounts
            allUserAccounts = DatabaseConnection.ReadLoginAccounts();

            foreach (UserAccount currentAccount in allUserAccounts.Accounts)
            {
                if (currentAccount.User_Level != 1)
                {
                    remove_account_account_selection.Items.Add(currentAccount.Username);
                }
            }
        }

        // ------------------ END OF USER ACCOUNT UTILITY ------------------ //

        // ------------------ UNUSED CRAP ------------------ //

        private void actual_username_label_Click(object sender, EventArgs e) { }

        private void label12_Click(object sender, EventArgs e) { }

        // ------------------ END OF UNUSED CRAP ------------------ //
    }
}
