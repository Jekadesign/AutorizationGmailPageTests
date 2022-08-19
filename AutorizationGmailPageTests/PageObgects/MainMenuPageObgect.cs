using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorizationGmailPageTests.PageObgects
{
	internal class MainMenuPageObgect
	{
		private IWebDriver _webDriver;

		private readonly By _signInButton = By.XPath("//*[contains(@href,'GAZAmgQ')]");

		public MainMenuPageObgect(IWebDriver webDriver)
		{
			_webDriver = webDriver;
		}

		public AuthorizationPageObject SignIn()
		{
			_webDriver.FindElement(_signInButton).Click();
			return new AuthorizationPageObject(_webDriver);
		}

	}
}
