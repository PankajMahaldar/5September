using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5September
{
    public class Sepember_9
    {
        public void seleniumConcepts()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("");
            driver.Navigate().Back();
            driver.Navigate().Refresh();
            driver.Navigate().Forward();
            string sas = driver.Title;
            string url = driver.Url;
            driver.Manage().Window.Maximize();
            driver.Manage().Window.Minimize();
            driver.Manage().Window.FullScreen();
            driver.FindElement(By.XPath(""));
            IList<IWebElement> list = driver.FindElements(By.XPath(""));
            string current = driver.CurrentWindowHandle;
            IList<string>handles = driver.WindowHandles;
            foreach (string element in handles)
            {
                if(!element.Equals(current))
                {
                    driver.SwitchTo().Window(element);
                }
            }
            Thread.Sleep(4000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("")));
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame(2);
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Dismiss();
            driver.SwitchTo().Alert().SendKeys(Keys.Escape);
            string alerttext =driver.SwitchTo().Alert().Text;

            Actions a = new Actions(driver);
            a.ContextClick(driver.FindElement(By.XPath("")));
            a.KeyDown(Keys.Enter);
            a.KeyUp(Keys.Enter);

            IWebElement sample = driver.FindElement(By.XPath(""));

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(false)", sample);//scroll down
            js.ExecuteScript("arguments[0].scrollIntoView(true)", sample);//scroll up

            SelectElement sel = new SelectElement(sample);
            sel.SelectByIndex(0);
        }
        public void PrintWithoutLoop(int x)
        {
            int a = 0;
            if(a<x)
            {
                a++;
                Console.Write(a.ToString() + " ");
                PrintWithoutLoop(a);
            }
        }
        public void CountOfAlphabets(string str)
        {
            char[] chars = str.ToLower().ToCharArray();
            string sample = "abcdefghijklmnopqrstuvwxyz";
            char[] alphabets = sample.ToCharArray();
            
            for(int i =0; i < alphabets.Length; i++)
            {
                int count = 0;
                for (int j = 0;j<chars.Length;j++)
                {
                    if(alphabets[i] == chars[j])
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine($"Count of {alphabets[i]} is {count}");
                }
            }
        }
        public void codes()
        {
            string abc = "aaggghjjkkduj";
            string z = "";
            string s1 = "Today i have to crack interview";
            char[] chars = abc.ToCharArray();
            Console.WriteLine(abc);
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                z += chars[i];
            }
            Console.WriteLine(z);
            //find all substrings
            string[] s2 = s1.Split(" ");
            foreach (string s in s2)
            {

                Console.Write(s + "-");
            }
            //get the occurrence of character
            Console.WriteLine();
            string s3 = s1.ToLower();
            Console.WriteLine(s3);
            char[] ch1 = s3.ToCharArray(); // array of characters it includes spaces as well
            List<char> list = new List<char>(); //empty list
            Dictionary<char, int> dic = new Dictionary<char, int>(); //empty dictionary
            for (int i = 0; i < ch1.Length; i++)
            {
                int count = 0;
                if (!dic.ContainsKey(ch1[i])) //!list.Contains(ch1[i])
                {
                    //list.Add(ch1[i]);

                    count++;
                    for (int j = i + 1; j < ch1.Length; j++)
                    {
                        if (ch1[i] == ch1[j])
                            count++;
                    }
                    dic.Add(ch1[i], count);
                    Console.WriteLine($"The occurrence of character'{ch1[i]}' is {count}");
                }
            }
            //how to print dictionary in alphadetical order
            var sortedDic = dic.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (KeyValuePair<char, int> pair in sortedDic)
            {
                Console.WriteLine($"The character is {pair.Key} and count of it is {pair.Value}");
            }
        }
        public void otherCodes()
        {
            string abc = "aaaajjjttth";
            string z = "";
            //reverse the string
            for (int i = abc.Length - 1; i >= 0; i--)
            {
                z += abc[i];
            }
            Console.WriteLine(abc);
            Console.WriteLine(z);

            // get the count of occurrence

            List<char> list = new List<char>();

            for (int i = 0; i < abc.Length; i++)
            {
                int count = 0;
                if (!list.Contains(abc[i]))
                {
                    list.Add(abc[i]);
                    count++;
                    for (int j = i + 1; j < abc.Length; j++)
                    {
                        if (abc[i] == abc[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"The occurence of character'{abc[i]}' is {count}");
                }
            }

            // reversing the string sentence

            string sample = "My name is Pankaj Kumar Mahaldar";
            string[] result = sample.Split(" ");
            Console.WriteLine(sample);
            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i] + " ");
            }

        }

    }
}
