using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace Chojnowski_Appium_WebDriver
{
    [TestClass]
    public class UnitTest1
    {
        private AndroidDriver<AppiumWebElement> driver;

        [TestInitialize]
        public void BeforeTest()
        {
            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "11");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");

            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
        }

        // 2+2*2-2/2 = 5
        [TestMethod]
        public void TestMethod1()
        {
            Clear();

            IWebElement el1 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_2");
            el1.Click();
            IWebElement el2 = (IWebElement)driver.FindElementByAccessibilityId("plus");
            el2.Click();
            IWebElement el3 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_2");
            el3.Click();
            IWebElement el4 = (IWebElement)driver.FindElementByAccessibilityId("multiply");
            el4.Click();
            IWebElement el5 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_2");
            el5.Click();
            IWebElement el6 = (IWebElement)driver.FindElementByAccessibilityId("minus");
            el6.Click();
            IWebElement el7 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_2");
            el7.Click();
            IWebElement el8 = (IWebElement)driver.FindElementByAccessibilityId("divide");
            el8.Click();
            IWebElement el9 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_2");
            el9.Click();
            IWebElement el10 = (IWebElement)driver.FindElementByAccessibilityId("equals");
            el10.Click();


            string result = Result();
            string expected = "5";
            Assert.AreEqual(expected, result);
        }

        // 123*456+789/100-12345 = 43750.89
        [TestMethod]
        public void TestMethod2()
        {
            Clear();
            
            IWebElement el1 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_1");
            el1.Click();
            IWebElement el2 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_2");
            el2.Click();
            IWebElement el3 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_3");
            el3.Click();
            IWebElement el4 = (IWebElement)driver.FindElementByAccessibilityId("multiply");
            el4.Click();
            IWebElement el5 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_4");
            el5.Click();
            IWebElement el6 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_5");
            el6.Click();
            IWebElement el7 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_6");
            el7.Click();
            IWebElement el8 = (IWebElement)driver.FindElementByAccessibilityId("plus");
            el8.Click();
            IWebElement el9 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_7");
            el9.Click();
            IWebElement el10 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_8");
            el10.Click();
            IWebElement el11 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_9");
            el11.Click();
            IWebElement el12 = (IWebElement)driver.FindElementByAccessibilityId("divide");
            el12.Click();
            IWebElement el13 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_1");
            el13.Click();
            IWebElement el14 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_0");
            el14.Click();
            el14.Click();
            IWebElement el15 = (IWebElement)driver.FindElementByAccessibilityId("minus");
            el15.Click();
            IWebElement el16 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_1");
            el16.Click();
            IWebElement el17 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_2");
            el17.Click();
            IWebElement el18 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_3");
            el18.Click();
            IWebElement el19 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_4");
            el19.Click();
            IWebElement el20 = (IWebElement)driver.FindElementById("com.google.android.calculator:id/digit_5");
            el20.Click();
            IWebElement el21 = (IWebElement)driver.FindElementByAccessibilityId("equals");
            el21.Click();

            string result = Result();
            string expected = "43750.89";
            Assert.AreEqual(expected, result);
        }

        private void Clear()
        {
            IWebElement clear = (IWebElement)driver.FindElementById("com.google.android.calculator:id/clr");
            clear.Click();
        }

        private string Result()
        {
            IWebElement result = (IWebElement)driver.FindElementById("com.google.android.calculator:id/result_final");
            return result.Text;
        }
    }
}