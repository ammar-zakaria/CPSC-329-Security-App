using System;
using System.IO;

namespace CPSC_329_Security_App.Resources
{
    class Tester
    {
        string filename;
        string commonPasswords;
        int minLength;

        public Tester(string filename, int minLength)
        {
            this.filename = filename;
            getCommonPasswords(filename);
            this.minLength = minLength;
        }

        public string testPassword(string password)
        {
            bool hasLowercase = false, hasUppercase = false, hasNumber = false, hasSymbol = false, goodLength = false;
            int strengthScore = 0;
            string strengthString;

            //Converts the letters in the password to all lowercase, then checks if the password is contained in the string of common passwords.
            //If it is found in the string, exits the function with a string stating the password was found in the list
            if (commonPasswords.Contains(password.ToLower()))
            {
                return "PASSWORD \"" + password + "\" HAS A STRENGTH SCORE: 0 out of 5\n" +
                       "\n" +
                       "PROBLEM: PASSWORD MATCHES ONE OF THE MOST COMMONLY USED PASSWORDS\n";
            }

            //Set a flag for string writing if the password meets the minimum length
            if (password.Length >= minLength)
            {
                goodLength = true;
            }

            //Checks each character in the password and sets flags for each type of character found
            foreach (char c in password)
            {
                if (c >= 'a' && c <= 'z')
                {
                    hasLowercase = true;
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    hasUppercase = true;
                }
                else if (c >= '0' && c <= '9')
                {
                    hasNumber = true;
                }
                else if ("~`! @#$%^&*()_-+={[}]|\\:;\"'<,>.?/".Contains(c))
                {
                    hasSymbol = true;
                }

            }

            //For each flag set, increment the password's score
            if (hasLowercase)
                strengthScore++;
            if (hasUppercase)
                strengthScore++;
            if (hasNumber)
                strengthScore++;
            if (hasSymbol)
                strengthScore++;
            if (goodLength)
                strengthScore++;


            //Formatting the returned string
            strengthString = "PASSWORD \"" + password + "\" HAS A STRENGTH SCORE: " + strengthScore + " out of 5";

            if (strengthScore < 5)
            {
                strengthString += "\n\nYOU CAN IMPROVE YOUR PASSWORDS STRENGTH BY:";
                if (!goodLength)
                    strengthString += "\n   -  Making your password at least " + minLength + " characters long";
                if (!hasLowercase)
                    strengthString += "\n   -  Including at least one lowercase letter";
                if (!hasUppercase)
                    strengthString += "\n   -  Including at least one uppercase letter";
                if (!hasNumber)
                    strengthString += "\n   -  Including at least one number";
                if (!hasSymbol)
                    strengthString += "\n   -  Including at least one symbol";
            }

            return strengthString + '\n';
        }

        /*
         *  Reads the given filename if it exists, and returns it as string. If the file does not exist, returns an empty string (This will be changed to throwing an exception later). 
         */
        private void getCommonPasswords(string filename)
        {
            if (File.Exists(filename))
            {
                commonPasswords = File.ReadAllText(filename);
            }
            else
            {
                commonPasswords = "";
            }
        }
    }
}
