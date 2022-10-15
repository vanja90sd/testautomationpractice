﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationPractice.Pages
{
    class HomePage
    {
        readonly IWebDriver driver;
        public By homepage = By.Id("index");
        public By contactUs = By.Id("contact-link");
        public By searchField = By.Id("search_query_top");
        public By searchBtn = By.Name("sumbit_search");
        public By signIn = By.ClassName("login");



        public HomePage(IWebDriver driver)
        {
            this.driver = driver; 
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(homepage)); 
        }

           
    }


}

