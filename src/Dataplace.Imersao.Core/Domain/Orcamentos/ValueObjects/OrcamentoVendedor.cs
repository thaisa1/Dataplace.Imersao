namespace Dataplace.Imersao.Core.Domain.Orcamentos.ValueObjects
{
    public class OrcamentoVendedor
    {
        public OrcamentoVendedor(string codigo)
        {
            Codigo = codigo;
        }
        public string Codigo { get; }
    }
}
