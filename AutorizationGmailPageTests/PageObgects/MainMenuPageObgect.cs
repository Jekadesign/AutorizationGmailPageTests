using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailPageTests.PageObgects
{
	internal class MainMenuPageObgect
	{
		private IWebDriver _webDriver;

		//private readonly By _signInButton = By.XPath("//*[contains(@href,'GAZAmgQ')]");
		private readonly By _loginInputButton = By.CssSelector("[name='login']");
		private readonly By _passwordInputButton = By.CssSelector("[name='password']");
		private readonly By _continueButton = By.XPath("//*[contains(@type,'submit')]");


		public MainMenuPageObgect(IWebDriver webDriver)
		{
			_webDriver = webDriver;
		}

		public PageObject SignIn()
		{
			//_webDriver.FindElement(_signInButton).Click();
			_webDriver.FindElement(_loginInputButton).SendKeys("direct.gray.begemot@ukr.net");
			_webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
			_webDriver.FindElement(_passwordInputButton).SendKeys("Directgraybegemot");
			_webDriver.FindElement(_continueButton).Click();

			return new PageObject(_webDriver);
		}

	}
}
