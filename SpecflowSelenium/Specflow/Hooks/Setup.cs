﻿using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpecflowSelenium.Specflow.Hooks
{
    [Binding]
    public sealed class Setup
    {
        IWebDriver _driver;
      private static readonly string _projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

      [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver(_projectDir + @"\SpecflowSelenium\Specflow\Drivers");
            ScenarioContext.Current["driver"] = _driver;
           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Dispose();
        }
    }
}
