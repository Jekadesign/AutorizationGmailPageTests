using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MailPageTests.PageObgects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System.Threading;

using System;

namespace MailPageTests
{
	public class Tests
	{
		private IWebDriver _webDriver;

		
		[SetUp]
		public void Setup()
		{
			_webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
			_webDriver.Navigate().GoToUrl("https://mail.ukr.net");
			_webDriver.Manage().Window.Maximize();
		}

		[Test]
		public void Test1()
		{

			var mainMenu = new MainMenuPageObgect(_webDriver);
			mainMenu
				.SignIn()
				.SendMail();
		}

		[TearDown]
		public void TearDown()
		{

		}
	}
}