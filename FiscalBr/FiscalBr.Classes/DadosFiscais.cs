using System;
using System.Collections.Generic;

namespace FiscalBr.Classes
{
    public static class DadosFiscais
    {
        #region CFOP

        public static List<Cfop> ListaCfopsEntrada
        {
            get
            {
                var lista = new List<Cfop>();
                lista.AddRange(ListaCfopsEntradaMesmoEstado);

                return lista;
            }
        }

        /*
         *  Agrupamentos de CFOP - ENTRADAS 
         */
        private const string _grupo1000 = "1.000 - ENTRADAS OU AQUISIÇÕES DE SERVIÇOS NO ESTADO";
        private const string _subGrupo1100 = "1.100 - COMPRAS PARA INDUSTRIALIZAÇÃO, PRODUÇÃO RURAL, COMERCIALIZAÇÃO OU PRESTAÇÃO DE SERVIÇOS";

        private const string _grupo2000 = "2.000 - ENTRADAS OU AQUISIÇÕES DE SERVIÇOS DE OUTROS ESTADOS";
        private const string _grupo3000 = "3.000 - ENTRADAS OU AQUISIÇÕES DE SERVIÇOS DO EXTERIOR";

        /*
         *  Agrupamentos de CFOP - SAÍDAS 
         */
        private const string _grupo5000 = "5.000 - SAÍDAS OU PRESTAÇÕES DE SERVIÇOS PARA O ESTADO";
        private const string _grupo6000 = "6.000 - SAÍDAS OU PRESTAÇÕES DE SERVIÇOS PARA OUTROS ESTADOS";
        private const string _grupo7000 = "7.000 - SAÍDAS OU PRESTAÇÕES DE SERVIÇOS PARA O EXTERIOR";

        #region Grupo 1.000

        public static List<Cfop> ListaCfopsEntradaMesmoEstado
        {
            get
            {
                var lista = new List<Cfop>();
                lista.Add(Cfop1101);

                return lista;
            }
        }

        private static Cfop Cfop1101 = new Cfop
        {
            Codigo = "1.101",
            Descricao = "Compra para industrialização",
            Observacao = "Classificam-se neste código as compras de mercadorias a serem utilizadas em processo de industrialização ou produção rural. Também serão classificadas neste código as entradas de mercadorias em estabelecimento industrial ou produtor rural de cooperativa recebidas de seus cooperados ou de estabelecimento de outra cooperativa.",
            Grupo = _grupo1000,
            SubGrupo = _subGrupo1100,
            InicioVigenciaSped = new DateTime(2009, 1, 1)
        };
    }

        #endregion Grupo 1.000

        #endregion CFOP
}

