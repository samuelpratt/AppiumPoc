using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTest.Fixtures
{
    abstract class AbstractViewFixture
    {
        protected readonly AndroidDriver<AndroidElement> Driver;
        private readonly List<By> _viewSelectors;

        protected AbstractViewFixture(AndroidDriver<AndroidElement> driver, List<By> viewSelectors)
        {
            _viewSelectors = viewSelectors;
            Driver = driver;
        }


        public bool IsDisplayed()
        {
            try
            {
                foreach(var viewSelector in _viewSelectors)
                    Driver.FindElement(viewSelector);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
        }

        public void WaitForDisplay()
        {
            WaitForDisplay(5000);
        }

        public void WaitForDisplay(int milliSeconds)
        {
            DateTimeOffset waitUntil = DateTimeOffset.Now.AddMilliseconds(milliSeconds);
            while (true)
            {
                try
                {
                    if (DateTimeOffset.Now > waitUntil)
                    {
                        throw new TimeoutException($"View was not shown within {milliSeconds} milliseconds");
                    }
                    foreach (var viewSelector in _viewSelectors)
                        Driver.FindElement(viewSelector);
                }
                catch (NoSuchElementException)
                {
                    continue;
                }
                break;

            }
        }

        protected void ClickElement(By elementToClick)
        {
            var element = Driver.FindElement(elementToClick);
            element.Tap(1, 0);
        }
    }
}