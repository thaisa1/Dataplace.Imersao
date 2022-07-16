namespace Dataplace.Imersao.Core.Domain.Orcamentos.ValueObjects
{

    public class OrcamentoTabelaPreco
    {
    
      

        public OrcamentoTabelaPreco(string cdTabela, short sqTabela)
        {
            CdTabela = cdTabela;
            SqTabela = sqTabela;
        }
        public string CdTabela { get; set; }
        public short SqTabela { get; set; }
    }
}
