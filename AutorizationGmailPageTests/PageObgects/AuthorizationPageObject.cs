using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutorizationGmailPageTests.PageObgects
{
	internal class AuthorizationPageObject
	{
		private IWebDriver _webdriver;

		private readonly By _loginInputButton = By.CssSelector("[type='email']");
		private readonly By _nextButton = By.XPath("//span[text()='Далее']");
		private readonly By _passwordInputButton = By.Id("password");  //By.Name("password"); By.CssSelector("[id='password']"); //
		private readonly By _continueButton = By.XPath("//span[text()='Далее']");

		public AuthorizationPageObject(IWebDriver webdriver)
		{
			_webdriver = webdriver;
		}

		public MainMenuPageObgect Login()
		{
			_webdriver.FindElement(_loginInputButton).SendKeys("direct.gray.begemot@gmail.com");
			_webdriver.FindElement(_nextButton).Click();
			_webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
			_webdriver.FindElement(_passwordInputButton).SendKeys("Directgraybegemot");
			_webdriver.FindElement(_continueButton).Click();

			return new MainMenuPageObgect(_webdriver);
		}

	}
}
