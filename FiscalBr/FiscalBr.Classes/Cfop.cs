using System;

namespace FiscalBr.Classes
{
    /// <summary>
    /// Código Fiscal de Operações e de Prestações
    /// </summary>
    /// <remarks>
    /// Legislação:
    /// Convênio S/Nº, de 15 de dezembro de 1970
    /// </remarks>
    public class Cfop
    {
        /// <summary>
        /// Código do CFOP
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Descrição do CFOP
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Observação do CFOP
        /// </summary>
        public string Observacao { get; set; }

        /// <summary>
        /// Grupo do CFOP
        /// </summary>
        public string Grupo { get; set; }

        /// <summary>
        /// Subgrupo do CFOP
        /// </summary>
        public string SubGrupo { get; set; }

        /// <summary>
        /// Data inicial permitida para uso no projeto SPED.
        /// </summary>
        public DateTime InicioVigenciaSped { get; set; }

        /// <summary>
        /// Data final permitida para uso no projeto SPED.
        /// </summary>
        public DateTime? FimVigenciaSped { get; set; }

        /// <summary>
        /// Caso a data final de vigência contenha valor será false.
        /// </summary>
        public bool AtivoSped => FimVigenciaSped.HasValue ? false : true;
    }
}
