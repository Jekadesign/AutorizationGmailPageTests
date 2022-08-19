using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutorizationGmailPageTests.PageObgects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System.Threading;

using System;

namespace AutorizationGmailPageTests
{
	public class Tests
	{
		private IWebDriver _webDriver;

		//private readonly By _signInButton = By.XPath("//*[contains(@href,'GAZAmgQ')]");
		//private readonly By _loginInputButton = By.CssSelector("[type='email']");
		//private readonly By _nextButton = By.XPath("//span[text()='Далее']");
		//private readonly By _passwordInputButton = By.Id("password");  //By.Name("password"); By.CssSelector("[id='password']"); //
		//private readonly By _continueButton = By.XPath("//span[text()='Далее']");



		//private const string _login = "direct.gray.begemot@gmail.com";
		//private const string _password = "Directgraybegemot";


		[SetUp]
		public void Setup()
		{
			_webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
			_webDriver.Navigate().GoToUrl("https://www.google.com/");
			_webDriver.Manage().Window.Maximize();
		}

		[Test]
		public void Test1()
		{

			//_webDriver.FindElement(_signInButton).Click();
			//_webDriver.FindElement(_loginInputButton).SendKeys(_login);
			//_webDriver.FindElement(_nextButton).Click();
			//_webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
			//_webDriver.FindElement(_passwordInputButton).SendKeys(_password);
			//_webDriverr.FindElement(_continueButton).Click();

			//Assert.AreEqual("expected", "actual");

			var mainMenu = new MainMenuPageObgect(_webDriver);
			mainMenu
				.SignIn()
				.Login();
		}

		[TearDown]
		public void TearDown()
		{

		}
	}
}