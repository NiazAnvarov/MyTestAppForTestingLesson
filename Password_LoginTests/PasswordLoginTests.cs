using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyTestApp;

namespace Password_LoginTests
{
    [TestClass]
    public class PasswordLoginTests
    {
        [TestMethod]
        public void LoginAndPassword_DirectorandAdmin12SpecialSimbol_returnedUspeh()
        {

            // исходные данные
            string login = "Director";
            string password = "Admin12!";
            string expected = "Успех";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void LoginAndPassword_EmptyLoginandAdmin12SpecialSimbol_returnedIncorrectLogin()
        {

            // исходные данные
            string login = "";
            string password = "Admin12!";
            string expected = " Не верный логин!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void LoginAndPassword_DirectorandEmptyPassword_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void LoginAndPassword_EmptyLoginandEmptyPassword_returnedIncorrectPasswordAndIncorrectLogin()
        {

            // исходные данные
            string login = "";
            string password = "";
            string expected = "Не верный пароль! Не верный логин!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void LoginAndPassword_DirectorandAm1SpecialSimbol_returnedIncorrectPasswordAndIncorrectLogin()
        {

            // исходные данные
            string login = "Director";
            string password = "Amms41!";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void LoginAndPassword_Directorand123_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "12345678";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }








    }
}
