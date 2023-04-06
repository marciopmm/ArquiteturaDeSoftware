using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;
using System.Threading;

namespace WatinExample02
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void BingSearchTest()
        {
            bool result;

            using (IE browser = new IE("http://www.bing.com.br"))
            {
                browser.BringToFront();
                Thread.Sleep(3000);
                var textBox = browser.TextField(Find.ByName("q"));
                var button = browser.Button(Find.ByName("go"));

                textBox.TypeText("Logical Docs");
                button.Click();
                Thread.Sleep(3000);

                result = browser.ContainsText("Logical Docs");
            }

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GoogleSearchTest()
        {
            bool result;

            using (IE browser = new IE("http://www.google.com.br"))
            {
                browser.BringToFront();
                var textBox = browser.TextField(Find.ByName("q"));
                var button = browser.Button(Find.ByName("btnK"));

                textBox.Focus();
                textBox.TypeText("Logical Docs");
                Thread.Sleep(3000);
                textBox.Blur();
                textBox.Click();

                Thread.Sleep(3000);

                if (!button.Exists)
                    button = browser.Button(Find.ByName("btnG"));

                button.Click();

                Thread.Sleep(3000);

                result = browser.ContainsText("Logical Docs");
            }

            Assert.IsTrue(result);
        }
    }
}
