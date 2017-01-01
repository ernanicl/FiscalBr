using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalBr.MotorTributario
{
    /// <summary>
    /// Produto/Serviço conforme dados no DTO fornecido pela API do IBPT
    /// </summary>
    /// <remarks>
    /// http://iws.ibpt.org.br/help/index#!//Servicos_Get
    /// </remarks>
    public class ProdutoServicoIbptDto
    {
        public string Codigo { get; set; }
        public string UF { get; set; }
        public int EX { get; set; }
        public string Descricao { get; set; }
        public double Nacional { get; set; }
        public int Estadual { get; set; }
        public double Importado { get; set; }
        public int Municipal { get; set; }
        public string Tipo { get; set; }
        public string VigenciaInicio { get; set; }
        public string VigenciaFim { get; set; }
        public string Chave { get; set; }
        public string Versao { get; set; }
        public string Fonte { get; set; }
    }
}
