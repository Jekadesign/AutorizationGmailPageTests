using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MailPageTests.PageObgects
{
	internal class PageObject
	{
		private IWebDriver _webdriver;
				
		private readonly By _writeMailButton = By.CssSelector("[class='button primary compose']");
		private readonly By _sendMailFromField = By.XPath("//*[contains(@class,'input')]");
		private readonly By _subjectField = By.Name("subject");
		private readonly By _sendButton = By.CssSelector("[class='button primary send']");

		public PageObject(IWebDriver webdriver)
		{
			_webdriver = webdriver;
		}

		public MainMenuPageObgect SendMail()
		{
			
			_webdriver.FindElement(_writeMailButton).Click();
			_webdriver.FindElement(_sendMailFromField).SendKeys("direct.gray.begemot@ukr.net");
			_webdriver.FindElement(_subjectField).SendKeys("Hello!");
			_webdriver.FindElement(_sendButton).Click();

			_webdriver.Quit();			

			return new MainMenuPageObgect(_webdriver);
		}

	}
}
