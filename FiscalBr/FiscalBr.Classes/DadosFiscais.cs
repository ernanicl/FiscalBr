using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace FiscalBr.Classes
{
    public static class DadosFiscais
    {
        public static class ListaCfop
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

            private const string _grupo1000 = "1.000 - ENTRADAS OU AQUISIÇÕES DE SERVIÇOS NO ESTADO";
            private const string _subGrupo1100 =
                "1.100 - COMPRAS PARA INDUSTRIALIZAÇÃO, PRODUÇÃO RURAL, COMERCIALIZAÇÃO OU PRESTAÇÃO DE SERVIÇOS";

            private const string _grupo2000 = "2.000 - ENTRADAS OU AQUISIÇÕES DE SERVIÇOS DE OUTROS ESTADOS";
            private const string _subGrupo2100 = "2.100 - COMPRAS PARA INDUSTRIALIZAÇÃO, COMERCIALIZAÇÃO OU PRESTAÇÃO DE SERVIÇOS";

            private const string _grupo3000 = "3.000 - ENTRADAS OU AQUISIÇÕES DE SERVIÇOS DO EXTERIOR";
            private const string _subGrupo3100 = "3.100 - COMPRAS PARA INDUSTRIALIZAÇÃO, COMERCIALIZAÇÃO OU PRESTAÇÃO DE SERVIÇOS";

            private const string _grupo5000 = "5.000 - SAÍDAS OU PRESTAÇÕES DE SERVIÇOS PARA O ESTADO";

            private const string _grupo6000 = "6.000 - SAÍDAS OU PRESTAÇÕES DE SERVIÇOS PARA OUTROS ESTADOS";

            private const string _grupo7000 = "7.000 - SAÍDAS OU PRESTAÇÕES DE SERVIÇOS PARA O EXTERIOR";

            public static List<Cfop> ListaCfopsEntradaMesmoEstado
            {
                get
                {
                    var lista = new List<Cfop>();
                    lista.Add(Cfop1101);
                    lista.Add(Cfop1102);

                    return lista;
                }
            }

            public static Cfop Cfop1101 = new Cfop
            {
                Codigo = "1101",
                Descricao = "Compra para industrialização",
                Observacao =
                    "Classificam-se neste código as compras de mercadorias a serem utilizadas em processo de industrialização ou produção rural. Também serão classificadas neste código as entradas de mercadorias em estabelecimento industrial ou produtor rural de cooperativa recebidas de seus cooperados ou de estabelecimento de outra cooperativa.",
                Grupo = _grupo1000,
                SubGrupo = _subGrupo1100,
                InicioVigenciaSped = new DateTime(2009, 1, 1)
            };

            public static Cfop Cfop2101 = new Cfop
            {
                Codigo = "2101",
                Descricao = Cfop1101.Descricao,
                Observacao = Cfop1101.Observacao,
                Grupo = _grupo2000,
                SubGrupo = _subGrupo2100,
                InicioVigenciaSped = Cfop1101.InicioVigenciaSped
            };

            public static Cfop Cfop3101 = new Cfop
            {
                Codigo = "3101",
                Descricao = Cfop1101.Descricao,
                Observacao = Cfop1101.Observacao,
                Grupo = _grupo3000,
                SubGrupo = _subGrupo3100,
                InicioVigenciaSped = Cfop1101.InicioVigenciaSped
            };

            public static Cfop Cfop1102 = new Cfop
            {
                Codigo = "1102",
                Descricao = "Compra para comercialização",
                Observacao = "",
                Grupo = _grupo1000,
                SubGrupo = _subGrupo1100,
                InicioVigenciaSped = new DateTime(2009, 1, 1)
            };

            public static Cfop Cfop2102 = new Cfop
            {
                Codigo = "2102",
                Descricao = Cfop1102.Descricao,
                Observacao = Cfop1102.Observacao,
                Grupo = _grupo2000,
                SubGrupo = _subGrupo2100,
                InicioVigenciaSped = Cfop1102.InicioVigenciaSped
            };

            public static Cfop Cfop3102 = new Cfop
            {
                Codigo = "3102",
                Descricao = Cfop1102.Descricao,
                Observacao = Cfop1102.Observacao,
                Grupo = _grupo3000,
                SubGrupo = _subGrupo3100,
                InicioVigenciaSped = Cfop1102.InicioVigenciaSped
            };

        }

        #endregion CFOP
    }
}

