using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace WatinExample01
{
    [Binding]
    public class GoogleSearchSteps
    {
        private IE browser;

        [Given("que estou na home page do Google")]
        public void DadoQueEstouNaHomePageDoGoogle()
        {
            browser = new IE("http://www.google.com.br");
            Thread.Sleep(1000);
            browser.BringToFront();
        }

        [When("digito 'Hello World' na caixa de pesquisa")]
        public void QuandoDigitoHelloWorldNaCaixaDePesquisa()
        {
            var textBox = browser.TextField(Find.ByName("q"));

            textBox.Focus();
            textBox.TypeText("Hello World");
            textBox.Blur();
            textBox.Click();
            Thread.Sleep(2000);
        }

        [When("clico no botão de pesquisa")]
        public void EClicoNoBotaoDePesquisa()
        {
            browser.Button(Find.ByName("btnK")).Click();
            browser.Button(Find.ByName("btnG")).Click();
            Thread.Sleep(2000);
        }

        [Then("recebo uma lista de links relacionados com Hello World")]
        public void EntaoReceboUmaListaDeLinksRelacionadosComHelloWorld()
        {
            bool result = browser.ContainsText("Hello World");
            browser.Close();
            Assert.IsTrue(result);
        }
    }
}
