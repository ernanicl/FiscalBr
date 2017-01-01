using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiscalBr.MotorTributario;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiscalBr.Tests
{
    [TestClass]
    public class MotorTributarioTests
    {
        [TestMethod]
        public void ConsultarTributacaoDeProdutoNoIbpt()
        {
            var meuToken = "SEU_TOKEN_AQUI";
            var meuCnpj = "SEU_CNPJ_AQUI";
            var codNcmOuCodServ = "22011000"; // Água Mineral
            var minhaUf = "GO";

            var resultado = FiscalBr.MotorTributario.TributacaoMediaIbpt.ConsultarProdutoServicoIbpt(meuToken, meuCnpj,
                codNcmOuCodServ, minhaUf, 0, TributacaoMediaIbpt.TipoConsulta.Produto);

            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void ConsultarTributacaoDeServicoNoIbptTabelaNbs()
        {
            var meuToken = "SEU_TOKEN_AQUI";
            var meuCnpj = "SEU_CNPJ_AQUI";
            var codNcmOuCodServ = "115022000"; // Serviços de projeto e desenvolvimento, adaptação e instalação de aplicativos personalizados (customizados)
            var minhaUf = "GO";

            var resultado = FiscalBr.MotorTributario.TributacaoMediaIbpt.ConsultarProdutoServicoIbpt(meuToken, meuCnpj,
                codNcmOuCodServ, minhaUf, TributacaoMediaIbpt.TipoConsulta.Servico);

            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void ConsultarTributacaoDeServicoNoIbptLeiComplementar116()
        {
            var meuToken = "SEU_TOKEN_AQUI";
            var meuCnpj = "SEU_CNPJ_AQUI";
            var codNcmOuCodServ = "0101"; // Análise e desenvolvimento de sistemas
            var minhaUf = "GO";

            var resultado = FiscalBr.MotorTributario.TributacaoMediaIbpt.ConsultarProdutoServicoIbpt(meuToken, meuCnpj,
                codNcmOuCodServ, minhaUf, TributacaoMediaIbpt.TipoConsulta.Servico);

            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void ObtemTributacaoMediaDeProduto()
        {
            var meuToken = "SEU_TOKEN_AQUI";
            var meuCnpj = "SEU_CNPJ_AQUI";
            var codNcmOuCodServ = "22011000"; // Água Mineral
            var valorProduto = 3.50M;
            var minhaUf = "GO";

            var resultado = FiscalBr.MotorTributario.TributacaoMediaIbpt.ObterTributacaoMedia(meuToken, meuCnpj,
                codNcmOuCodServ, valorProduto, minhaUf, 0, TributacaoMediaIbpt.TipoConsulta.Produto);

            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void ObtemTributacaoMediaDeServico()
        {
            var meuToken = "SEU_TOKEN_AQUI";
            var meuCnpj = "SEU_CNPJ_AQUI";
            var codNcmOuCodServ = "0101"; // Análise e desenvolvimento de sistemas
            var valorServico = 1.00M;
            var minhaUf = "GO";

            var resultado = FiscalBr.MotorTributario.TributacaoMediaIbpt.ObterTributacaoMedia(meuToken, meuCnpj,
                codNcmOuCodServ, valorServico, minhaUf, 0, TributacaoMediaIbpt.TipoConsulta.Servico);

            Assert.IsNotNull(resultado);
        }
    }
}
