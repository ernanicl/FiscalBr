using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace FiscalBr.MotorTributario
{
    /// <summary>
    /// A citação da fonte transfere ao IBPT a responsabilidade pelo cálculo da empresa emissora do documento fiscal.
    /// </summary>
    public class TributacaoMediaIbpt
    {
        private const string UriApiDeOlhoNoImposto = "http://iws.ibpt.org.br/api/deolhonoimposto/";

        public enum TipoConsulta
        {
            Produto,
            Servico
        }

        public static decimal[] ObterTributacaoMedia(string token, string cnpj, string codigo, decimal valor, string uf,
            int ex = 0, TipoConsulta tipoConsulta = TipoConsulta.Produto)
        {
            var tribNacional = 0.00M;
            var tribEstadual = 0.00M;
            var tribMunicipal = 0.00M;
            var tribImportacao = 0.00M;
            decimal[] valores;

            try
            {
                var request = CriarRequestConsulta(token, cnpj, codigo, uf, ex, tipoConsulta);

                var result = (ProdutoServicoIbptDto) RespostaRequestConsulta(request);

                tribNacional = valor > 0 ? valor * (decimal) result.Nacional : 0.00M;
                tribEstadual = valor > 0 ? valor * (decimal) result.Estadual : 0.00M;
                tribMunicipal = valor > 0 ? valor * (decimal) result.Municipal : 0.00M;
                tribImportacao = valor > 0 ? valor * (decimal) result.Importado : 0.00M;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (tribNacional > 0)
                    tribNacional = Math.Round(tribNacional/100, 2, MidpointRounding.AwayFromZero);

                if (tribEstadual > 0)
                    tribEstadual = Math.Round(tribEstadual / 100, 2, MidpointRounding.AwayFromZero);

                if (tribMunicipal > 0)
                    tribMunicipal = Math.Round(tribMunicipal / 100, 2, MidpointRounding.AwayFromZero);

                if (tribImportacao > 0)
                    tribImportacao = Math.Round(tribImportacao / 100, 2, MidpointRounding.AwayFromZero);

                valores = new[] { tribNacional, tribEstadual, tribMunicipal, tribImportacao };
            }

            return valores;
        }

        public static object ConsultarProdutoServicoIbpt(string token, string cnpj, string codigo, string uf, int ex = 0,
            TipoConsulta tipoConsulta = TipoConsulta.Produto)
        {
            var request = CriarRequestConsulta(token, cnpj, codigo, uf, ex, tipoConsulta);

            return RespostaRequestConsulta(request);
        }

        public static object ConsultarProdutoServicoIbpt(string token, string cnpj, string codigo, string uf, TipoConsulta tipoConsulta = TipoConsulta.Servico)
        {
            var request = CriarRequestConsulta(token, cnpj, codigo, uf, 0, tipoConsulta);

            return RespostaRequestConsulta(request);
        }

        private static HttpWebRequest CriarRequestConsulta(string token, string cnpj, string codigo, string uf,
            int ex = 0, TipoConsulta tipoConsulta = TipoConsulta.Produto)
        {
            var requestUrl = string.Empty;

            switch (tipoConsulta)
            {
                case TipoConsulta.Produto:
                    requestUrl = string.Format($"{UriApiDeOlhoNoImposto}/{"Produtos"}?token={token}&cnpj={cnpj}&codigo={codigo}&uf={uf}&ex=0");
                    break;
                case TipoConsulta.Servico:
                    requestUrl = string.Format($"{UriApiDeOlhoNoImposto}/{"Servicos"}?token={token}&cnpj={cnpj}&codigo={codigo}&uf={uf}");
                    break;
            }

            var request = WebRequest.Create(requestUrl) as HttpWebRequest;

            if (!string.IsNullOrEmpty(token))
                request.Headers.Add(HttpRequestHeader.Authorization, token);

            return request;
        }

        private static object RespostaRequestConsulta(WebRequest request)
        {
            try
            {
                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception($"Server error (HTTP {response.StatusCode}: {response.StatusDescription}).");

                    DataContractJsonSerializer jsonSerializer = null;

                    jsonSerializer = new DataContractJsonSerializer(typeof (ProdutoServicoIbptDto));

                    var objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    return objResponse;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

