using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace SpecFlowComWatinExample01
{
    [Binding]
    public class UtilizarMaquinasDePesquisaSteps
    {
        private IE browser;

        [Given(@"que estou na página home do Bing")]
        public void DadoQueEstouNaPaginaHomeDoBing()
        {
            browser = new IE("http://www.bing.com.br");
            browser.BringToFront();
        }
        
        [When(@"eu digito '(.*)' na caixa de texto")]
        public void QuandoEuDigitoNaCaixaDeTexto(string p0)
        {
            browser.TextField(Find.ByName("q")).TypeText(p0);
        }
        
        [When(@"clico no botão '(.*)'")]
        public void QuandoClicoNoBotao(string p0)
        {
            browser.Button(Find.ByTitle(p0)).Click();
        }
        
        [Then(@"a tela me mostra os links que contém a expressão '(.*)'")]
        public void EntaoATelaMeMostraOsLinksRelevantesNaPesquisa(string p0)
        {
            Assert.IsTrue(browser.ContainsText(p0));
            browser.Close();
        }
    }
}
