using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using Home_CS.POJO.Account;
using Home_CS.POJO.Quiz;

namespace Home_CS.POJO
{
    class DatabaseConnection
    {
        // private static MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=tobymac208;password=Sparta_!3712;database=mydb");

        /** Read in the login_accounts table from the database. Return all of the accounts. */
        public static UserAccountList ReadLoginAccounts()
        {
            // I need an accountList to populate
            UserAccountList accountList = new UserAccountList();
            // This is the string that connects the code to the database
            string connectionString = "server = localhost;user id = tobymac208;password=Sparta_!3712;database = mydb";
            // This is the command that connects the database to my code
            MySqlConnection connection = new MySqlConnection(connectionString);
            // Here's the query command section.
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM login_accounts";

            // Now, I'm going to open up the connection to the database. Try-catch in case a SQLException is thrown
            try
            {
                connection.Open();
            }
            catch (Exception exc)
            {
                Console.WriteLine("An exception occurred. Exception: " + exc.Message);
            }

            // This will be the object that holds all of the information coming in from the database.
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // This code would print out the content, in the current row, for "text"
                // Console.WriteLine(reader["text"].ToString());
                string username, password, firstname, lastname;
                int age, user_level;

                username = reader["username"].ToString();
                password = reader["password"].ToString();
                firstname = reader["firstname"].ToString();
                lastname = reader["lastname"].ToString();
                age = Convert.ToInt32(reader["age"].ToString());
                user_level = Convert.ToInt32(reader["user_level"].ToString());

                UserAccount newAccount = new UserAccount(username, password, firstname, lastname, age, user_level);
                accountList.AddAccount(newAccount);
            }
            connection.Close();
            return accountList;
        } // end of 

        public static void CreateLoginAccount(UserAccount accountToAdd)
        {
            // This is the string that connects the code to the database
            string connectionString = "server = localhost;user id = tobymac208;password=Sparta_!3712;database = mydb";
            // This is the command that connects the database to my code
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Here's the query command section.
            MySqlCommand command = connection.CreateCommand();
            string firstname = accountToAdd.FirstName, lastname = accountToAdd.LastName, username = accountToAdd.Username, password = accountToAdd.Password;
            int age = accountToAdd.Age, user_level = accountToAdd.User_Level;
            string commandString = "INSERT INTO login_accounts VALUES('" + username + "', '" + password + "','" + firstname + "', '" + lastname + "', " + age + ", " + user_level + ")";
            command.CommandText = commandString;

            // Now, I'm going to open up the connection to the database. Try-catch in case a SQLException is thrown
            try
            {
                connection.Open();
            }
            catch (Exception exc)
            {
                Console.WriteLine("An exception occurred. Exception: " + exc.Message);
            }

            command.ExecuteNonQuery();

            connection.Close();
        }

        /** Update an account's information */
        public static void UpdateLoginAccount(UserAccount account)
        {
            // This is the string that connects the code to the database
            string connectionString = "server = localhost;user id = tobymac208;password=Sparta_!3712;database = mydb";
            // This is the command that connects the database to my code
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Here's the query command section.
            MySqlCommand command = connection.CreateCommand();
            string commandString = "UPDATE login_accounts SET password='" + account.Password + "', firstname='" + account.FirstName + "', lastname='" + account.LastName + "', age=" + account.Age + " WHERE username='" + account.Username + "'";
            command.CommandText = commandString;
            
            try
            {
                connection.Open();
            }
            catch (Exception exc)
            {
                Console.WriteLine("An exception occurred. Exception: " + exc.Message);
            }

            command.ExecuteNonQuery();
            connection.Close();
        }

        /** Remove an account. */
        public static void RemoveLoginAccount(UserAccount accountToRemove)
        {
            // This is the string that connects the code to the database
            string connectionString = "server = localhost;user id = tobymac208;password=Sparta_!3712;database = mydb";
            // This is the command that connects the database to my code
            MySqlConnection connection = new MySqlConnection(connectionString);
            // Here's the query command section.
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM login_accounts WHERE username='" + accountToRemove.Username + "'";

            // Now, I'm going to open up the connection to the database. Try-catch in case a SQLException is thrown
            try
            {
                connection.Open();
            }
            catch (Exception exc)
            {
                Console.WriteLine("An exception occurred. Exception: " + exc.Message);
            }

            // Execute the nonquery
            command.ExecuteNonQuery();
            // close the connection
            connection.Close();
        }

        /** Read in the Quiz items. Returns all of the Quiz items. */
        public static QuizItemList ReadQuizItems()
        {
            QuizItemList quizItems = new QuizItemList();

            string connectionString = "server = localhost;user id = tobymac208;password=Sparta_!3712;database = mydb";
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            MySqlCommand command = mySqlConnection.CreateCommand();
            command.CommandText = "SELECT * FROM quiz";

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception thrown! Exception: " + exc.Message);
            }

            // This will be the object that holds all of the information coming in from the database.
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // This code would print out the content, in the current row, for "text"
                // Console.WriteLine(reader["text"].ToString());
                string question, answer;

                question = reader["question"].ToString();
                answer = reader["answer"].ToString();

                QuizItem quizItem = new QuizItem(question, answer);
                quizItems.AddQuizItem(quizItem);
            }

            mySqlConnection.Close();
            return quizItems;
        }
    }
}
