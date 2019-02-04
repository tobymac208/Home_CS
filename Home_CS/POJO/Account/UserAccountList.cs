using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_CS.POJO.Account {
    class UserAccountList {
        private List<UserAccount> accounts;
        // A variable for tracking how man accounts their are
        private static int numberOfAccounts = 0;

        public UserAccountList() {
            this.accounts = new List<UserAccount>();
            numberOfAccounts++;
        }

        /** Getter and setter for the Account list */
        public List<UserAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        /** Getter and setter of numberOfAccounts */
        public static int NumberOfAccounts
        {
            get { return numberOfAccounts; }
        }

        // Methods
        /**
         * Allows someone to add to this collection of Account objects
         */
        public void AddAccount(String username, String password, String firstname, String lastName, int age, int user_level) {
            if (FindByUsername(username) == null)
            { // if an Account with that name doesn't exist yet
                accounts.Add(new UserAccount(username, password, firstname, lastName, age, user_level));
            }
            else
            {
                Console.WriteLine("Account couldn't be created! Copied username.");
            }
        }

        /**
         * Allows someone to add to this collection of Account objects
         */
        public void AddAccount(UserAccount newAccount) {
            // simply passes all fields from newAccount to the other method
            AddAccount(newAccount.Username, newAccount.Password, newAccount.FirstName, newAccount.LastName, newAccount.Age, newAccount.User_Level);
        }

        /**
         * A method that checks if there are any users with that username yet, if there are return nothing
         */
        public UserAccount FindByUsername(String username){
            if (!(accounts.Count > 0))
            { // there is nothing in the list yet
                return null; // no items in the list
            }
            foreach (UserAccount currentAccount in accounts)
            { // for-each loop will go through each Account object and check its name
                if (currentAccount.Username.Equals(username))
                { // if the username matches
                    return currentAccount; // return the account
                }
            }

            // found nothing, return null
            return null;
        }
    }
}
