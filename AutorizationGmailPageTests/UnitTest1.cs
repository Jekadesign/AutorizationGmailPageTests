using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;

namespace AutorizationGmailPageTests
{
	public class Tests
	{
		private IWebDriver driver;

		private readonly By _signInButton = By.XPath("//*[contains(@href,'GAZAmgQ')]");
		private readonly By _loginInputButton = By.CssSelector("[type='email']");
		private readonly By _nextButton = By.XPath("//span[text()='Далее']");
		private readonly By _passwordInputButton = By.Id("password");  //By.Name("password"); By.CssSelector("[id='password']"); //
		private readonly By _continueButton = By.XPath("//span[text()='Далее']");




		private const string _login = "direct.gray.begemot@gmail.com";
		private const string _password = "Directgraybegemot";


		[SetUp]
		public void Setup()
		{
			driver = new OpenQA.Selenium.Chrome.ChromeDriver();
			driver.Navigate().GoToUrl("https://www.google.com/");
			driver.Manage().Window.Maximize();

		}

		[Test]
		public void Test1()
		{

			driver.FindElement(_signInButton).Click();
			driver.FindElement(_loginInputButton).SendKeys(_login);
			driver.FindElement(_nextButton).Click();
			//driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
			driver.FindElement(_passwordInputButton).SendKeys(_password);
			//driver.FindElement(_continueButton).Click();




		}

		[TearDown]
		public void TearDown()
		{

		}
	}
}