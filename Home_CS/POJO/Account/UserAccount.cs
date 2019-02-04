using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_CS.POJO.Account {
    class UserAccount {
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private int age;
        private int user_level;

        /** No-arg constructor */
        public UserAccount(){
            this.firstName = null;
            this.lastName = null;
            this.username = null;
            this.password = null;
            this.age = 0;
            this.user_level = 0;
        }

        public UserAccount(string username, string password, string firstName, string lastName, int age, int user_level) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.age = age;
            this.user_level = user_level;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /** User level is immutable. HAS to be set in the database directly. */
        public int User_Level
        {
            get { return user_level; }
        }

        /** Clone an Account object. */
        public UserAccount Clone(){
            UserAccount newAccount = new UserAccount(username, password, firstName, lastName, age, user_level);

            return newAccount;
        }
    }
}
