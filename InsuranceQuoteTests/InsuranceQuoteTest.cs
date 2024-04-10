﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace InsuranceQuoteTests
{
    [TestFixture]
    public class InsuranceQuoteTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void InsuranceQuote01_InputAllValidDataAnd24And3And0_Output5500()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 798);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("24");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.CssSelector(".card-body > .form-group:nth-child(2)")).Click();
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$5500"));
            }
        }
        [Test]
        public void InsuranceQuote02_InputAllValidDataAnd25And3And4_OutputNoInsurance()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1052, 800);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("4");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
            }
        }
        [Test]
        public void InsuranceQuote03_InputAllValidDataAnd35And9And2_Output3905()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 798);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("35");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("9");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("2");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$3905"));
            }
        }
        [Test]
        public void InsuranceQuote04_InputInvalidphoneNumberAndAllRemainingValidDataAnd27And3And0_OutputPhoneNumberMustfollowPattern()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1052, 800);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-123");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("27");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
        }
        [Test]
        public void InsuranceQuote05_InputInvalidEmailAndAllRemainingValidDataAnd28And3And0_OutputMustBeValidEmailAddress()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1052, 800);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            {
                var element = driver.FindElement(By.CssSelector(".col-md-6"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector(".col-md-6"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector(".col-md-6"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("whathow.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("28");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
        }
        [Test]
        public void InsuranceQuote06_InputInvalidPostalCodeAndAllRemainingValidDataAnd35And15And1_OutputPostalCodeMustFollowPattern()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1052, 800);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("22J 3B8");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("35");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("15");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("1");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
        }

        [Test]
        public void InsuranceQuote07_InputAllValidDataAndAgeOmittedAnd5And0_OutputAgeMoreThan16Required()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1052, 800);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("5");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
        }
        [Test]
        public void InsuranceQuote08_InputAllValidDataAnd37And8AndAccidentOmitted_OutputNumberOfAccidentsIsRequired()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1052, 800);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("37");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("8");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
        }
        [Test]
        public void InsuranceQuote09_InputAllValidDataAnd45AndExperienceOmittedAnd0_OutputYearsOfExperienceIsRequired()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1052, 800);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("45");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));

        }

        [Test]
        public void InsuranceQuote10_InputFirstNameOmittedAndAllRemainingValidDataAnd27And3And0_OutputFirstNameIsRequired()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1052, 800);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.CssSelector(".col-md-4:nth-child(1)")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("27");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            Assert.That(driver.FindElement(By.Id("firstName-error")).Text, Is.EqualTo("First Name is required"));
        }
        [Test]
        public void InsuranceQuote11_InputLastNameOmittedAndAllRemainingValidDataAnd25And2And1_OutputLastNameIsRequired()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1052, 800);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("2");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("1");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            Assert.That(driver.FindElement(By.Id("lastName-error")).Text, Is.EqualTo("Last Name is required"));
        }
        [Test]
        public void InsuranceQuote12_InputAddressOmittedAndAllRemainingValidDataAnd25And2And1_OutputAddressIsRequired()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1052, 800);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("2");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("1");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            Assert.That(driver.FindElement(By.Id("address-error")).Text, Is.EqualTo("Address is required"));
        }
        [Test]
        public void InsuranceQuote13_InputCityOmittedAndAllRemainingValidDataAnd28And4And1_OutputCityIsRequired()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8171a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(1052, 800);
            //Act
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Kush");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Patel");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("King Street North");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("what@how.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("28");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("4");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("1");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            Assert.That(driver.FindElement(By.Id("city-error")).Text, Is.EqualTo("City is required"));
        }

    }
}