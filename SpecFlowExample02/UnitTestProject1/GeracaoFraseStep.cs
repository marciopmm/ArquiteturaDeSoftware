using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowExample02
{
    [Binding]
    public class GeracaoFrasePorIndice
    {
        private Example.GeradorFrases gerador;
        int indice;
        string result = null;

        [Given("que tenho o índice 2")]
        public void DadoQueTenhoIndice2()
        {
            gerador = new Example.GeradorFrases();
            indice = 2;
        }

        [When("chamo o método com o índice")]
        public void QuandoDigito2()
        {
            result = gerador.Gerar(indice);
        }

        [Then("deve ser exibida a frase 'Eu gosto de picanha.'")]
        public void EntaoDeveSerExibidaAFrase()
        {
            Assert.AreEqual(result, "Eu gosto de picanha.");

        }
    }

    [Binding]
    public class GeracaoFraseSemIndice
    {
        private Example.GeradorFrases gerador;
        string result;

        [Given("que não tenho índice")]
        public void DadoQueNaoTenhoIndice()
        {
            gerador = new Example.GeradorFrases();
        }

        [When("chamo o método sem índice")]
        public void ChamoOMetodoSemIndice()
        {
            result = gerador.Gerar();
        }

        [Then("deve ser exibida qualquer frase")]
        public void DeveSerExibidaQualquerFrase()
        {
            Assert.IsFalse(string.IsNullOrEmpty(result));
        }
    }
}
