using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab1
{
    class User
    {
        public User()
        {

        }

        public bool validationRegistration(string loginUser, string passwordUser)
        {
            if (!usernameIsExists(loginUser))
            {
                bool isPass = true, isLog = true;
                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
                if (passwordUser.Length < 5 || !isLow(passwordUser) || hasSymbols.IsMatch(passwordUser) || (passwordUser.IndexOf(' ') >= 0) || !Regex.IsMatch(passwordUser, @"\p{L}"))
                {
                    isPass = false;
                }
                if (loginUser.Length < 5 || !isLow(loginUser) || hasSymbols.IsMatch(loginUser) || (loginUser.IndexOf(' ') >= 0) || !Regex.IsMatch(loginUser, @"\p{L}"))
                {
                    isLog = false;
                }
                if (isLog && isPass)
                {
                    return true;
                }
                return false;
            }
            return false;
        } // проверка валидности логина и пароля

        private bool usernameIsExists(string newUser)
        {
            string[] users = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\users.txt");
            for (int i = 0; i < users.Length; i++)
            {
                string[] user = users[i].Split(' ');
                if (newUser == user[0])
                {
                    return true;
                }
            }
            return false;
        } // существует ли аккаунт с таким логином

        private bool isLow(string s)
        {
            bool isLow = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsLower(s[i]) && !Char.IsDigit(s[i]))
                {
                    isLow = false;
                }
            }
            return isLow;
        } // проверка на нижний регистр

        public void registrationNewUser(string loginUser, string passwordUser)
        {
            string path = Directory.GetCurrentDirectory() + @"\files\users.txt";
            if (File.Exists(path))
            {
                string text = "\n" + loginUser + " " + passwordUser + "\n";
                File.AppendAllText(path, text);
            }
            path = Directory.GetCurrentDirectory() + @"\files\usersBalance.txt";
            string toSaveBalance = loginUser + " " + 1000 + "\n";
            if (File.Exists(path))
            {
                File.AppendAllText(path, toSaveBalance);
            }
        } // запись информации о новом пользователе

        public bool isAdmin(string loginUser, string passwordUser)
        {
            if (loginUser == "admin" && passwordUser == "admin")
            {
                addToLocalStorage(loginUser);
                return true;
            }
            else
            {
                return false;
            }
        } // вход в режиме администратора

        public bool accountLogin(string loginUser, string passwordUser)
        {
            StreamReader f = new StreamReader(Directory.GetCurrentDirectory() + @"\files\users.txt");
            while (!f.EndOfStream)
            {
                string lineFile = f.ReadLine();
                string[] lineFileArray = lineFile.Split(' ');
                if (lineFileArray[0] == loginUser && lineFileArray[1] == passwordUser)
                {
                    addToLocalStorage(loginUser);
                    return true;
                }
            }
            f.Close();
            return false;
        } // вход в аккаунт

        private void addToLocalStorage(string inputLogin)
        {
            string path = Directory.GetCurrentDirectory() + @"\files\localStorage.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, string.Empty);
                File.AppendAllText(path, inputLogin);
            }
        } // добавление информации о логине, который вошел в программу
    }
}
