using AutoIt;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WindowsInput;
using WindowsInput.Native;

namespace UploadFile_Practice
{
    [TestClass]
    public class UploadFile_Practice
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            string extn = "C:\\Users\\YourName\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Extensions\\bgnkhhnnamicmpeenaelnjfhikgbkllg\\4.1.53_0";
            options.AddArguments("load-extension=" + extn);
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://demoqa.com/automation-practice-form";
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            InputSimulator sim = new InputSimulator();

            driver.FindElement(By.Id("firstName")).Click();
            sim.Keyboard.TextEntry("Nadeem");
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            sim.Keyboard.TextEntry("Khan");
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            sim.Keyboard.TextEntry("youremail@gmail.com");
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            sim.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
            sim.Keyboard.KeyPress(VirtualKeyCode.LEFT);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            sim.Keyboard.TextEntry("3141234567");
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_A);
            sim.Keyboard.TextEntry("DD/MM/YYYY");
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            IWebElement subj = driver.FindElement(By.CssSelector("input[id='subjectsInput']"));
            subj.Click();
            sim.Keyboard.TextEntry("Comp");
            subj.SendKeys(Keys.Return);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            driver.FindElement(By.CssSelector("label[for='hobbies-checkbox-3']")).Click();
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            AutoItX.WinActivate("Open");
            Thread.Sleep(1000);
            AutoItX.Send(@"C:\Users\YourName\Pictures\Programmer.png");
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");
            driver.FindElement(By.Id("currentAddress")).Click();
            sim.Keyboard.TextEntry("Your Address");
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            sim.Keyboard.TextEntry("Raj");
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            sim.Keyboard.TextEntry("Jaip");
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
