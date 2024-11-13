using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyTestApp;

namespace Password_LoginTests
{
    [TestClass]
    public class PasswordLoginTests
    {
        //Ввод корректных данных
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
        //Ввод пустого логина с корректным паролем
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
        //Ввод корректного логина с пустым паролем
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
        //Ввод пустого логина и пустого пароля
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
        //Ввод пробела в логине и пароле
        [TestMethod]
        public void LoginAndPassword_SpaceLoginandSpacePassword_returnedIncorrectPasswordAndIncorrectLogin()
        {

            // исходные данные
            string login = "        ";
            string password = "        ";
            string expected = "Не верный пароль! Не верный логин!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод пробела в логин и ввод корректного пароля
        [TestMethod]
        public void LoginAndPassword_SpaceLoginandAwer12sSpecialSimbol_returnedIncorrectPasswordAndIncorrectLogin()
        {

            // исходные данные
            string login = "        ";
            string password = "Awer12s!";
            string expected = " Не верный логин!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и ввод пробела в пароль
        [TestMethod]
        public void LoginAndPassword_DirectorandSpacePassword_returnedIncorrectPasswordAndIncorrectLogin()
        {
            // исходные данные
            string login = "Director";
            string password = "        ";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод логина с пробелом и ввод корректного пароля
        [TestMethod]
        public void LoginAndPassword_DirectoSpacerandAwert12SpecialSimbol_returnedIncorrectPasswordAndIncorrectLogin()
        {
            // исходные данные
            string login = "Directo r";
            string password = "Awert12!";
            string expected = " Не верный логин!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и ввод пароля с 8-ю символами и с одним пробелом
        [TestMethod]
        public void LoginAndPassword_DirectorandAwert12SpecialSimbolSpace_returnedIncorrectPasswordAndIncorrectLogin()
        {
            // исходные данные
            string login = "Director";
            string password = "Awert12! ";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и ввод пароля с 7-ю символами и с одним пробелом
        [TestMethod]
        public void LoginAndPassword_DirectorandAwert1SpecialSimbolSpace_returnedIncorrectPasswordAndIncorrectLogin()
        {
            // исходные данные
            string login = "Director";
            string password = "Awert1#! ";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод логина с пробелом и ввод пароля с пробелом 
        [TestMethod]
        public void LoginAndPassword_DirectoSpacerandAwert12SpecialSimbolSpace_returnedIncorrectPasswordAndIncorrectLogin()
        {
            // исходные данные
            string login = "Directo r";
            string password = "Awert12! ";
            string expected = "Не верный пароль! Не верный логин!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из менее 8 символов
        [TestMethod]
        public void LoginAndPassword_DirectorandAmms41SpecialSimbol_returnedIncorrectPasswordAndIncorrectLogin()
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
        //Ввод корректного логина и пароля состящего из 20 символов
        [TestMethod]
        public void LoginAndPassword_Directorandv1TXPETdFTStEightSpecialSimbol_returnedIncorrectPasswordAndIncorrectLogin()
        {
            // исходные данные
            string login = "Director";
            string password = "v1TXPETdFTSt[]*;;_!+";
            string expected = "Успех";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из 21 символа
        [TestMethod]
        public void LoginAndPassword_DirectorandvHTXPETdFTStNineSpecialSimbol_returnedIncorrectPasswordAndIncorrectLogin()
        {
            // исходные данные
            string login = "Director";
            string password = "v1TXPETdFTSt[]*;;_!++";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля сосотящего из цифр
        [TestMethod]
        public void LoginAndPassword_Directorand12345678_returnedIncorrectPassword()
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
        //Ввод корректного логина и пароля состоящего из цифр и букв
        [TestMethod]
        public void LoginAndPassword_Directorand12345Adf_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "12345Adf";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из цифр и спец символов
        [TestMethod]
        public void LoginAndPassword_Directorand12345ThreeSpecialSimbols_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "12345!@#";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из букв и спец символов
        [TestMethod]
        public void LoginAndPassword_DirectorandAdfertTwoSpecialSimbols_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "Adfert!@";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из букв нижнего регистра
        [TestMethod]
        public void LoginAndPassword_Directorandasdfqwer_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "asdfqwer";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из букв верхнего и нижнего регистра
        [TestMethod]
        public void LoginAndPassword_DirectorandASDfqwer_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "ASDfqwer";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из букв верхнего регистра
        [TestMethod]
        public void LoginAndPassword_DirectorandASDFQWER_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "ASDFQWER";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из спец символов
        [TestMethod]
        public void LoginAndPassword_DirectorandSpecialSimbols_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "!@#%+-*/";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из букв нижнего регистра и спец символов
        [TestMethod]
        public void LoginAndPassword_DirectorandadfertTwoSpecialSimbols_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "adfert!@";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из букв нижнего регистра и цифр
        [TestMethod]
        public void LoginAndPassword_Directorandadfert12_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "adfert12";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из букв верхнего регистра и спец символов
        [TestMethod]
        public void LoginAndPassword_DirectorandADfertTwoSpecialSimbols_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "ADFERT!@";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод корректного логина и пароля состоящего из букв верхнего регистра и цифр
        [TestMethod]
        public void LoginAndPassword_DirectorandADFERT12_returnedIncorrectPassword()
        {

            // исходные данные
            string login = "Director";
            string password = "ADFERt12";
            string expected = "Не верный пароль!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод логина начинающегося со спец символа и корректного пароля
        [TestMethod]
        public void LoginAndPassword_SpecialSimbolirectorandAdmin12SpecialSimbol_returnedUspeh()
        {

            // исходные данные
            string login = "_irector";
            string password = "Admin12!";
            string expected = " Не верный логин!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }
        //Ввод логина начинающегося с цифры и корректного пароля
        [TestMethod]
        public void LoginAndPassword_1irectorandAdmin12SpecialSimbol_returnedUspeh()
        {

            // исходные данные
            string login = "1irector";
            string password = "Admin12!";
            string expected = " Не верный логин!";

            // получения значения с помощью тестируемого метода

            PasswordCheck check = new PasswordCheck();
            string actual = check.ValidatePassword(password, login);

            // сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);

        }


    }
}
