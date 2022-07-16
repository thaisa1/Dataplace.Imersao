namespace Dataplace.Imersao.Core.Domain.Orcamentos.ValueObjects
{
    public class OrcamentoCliente
    {
        public OrcamentoCliente(string codigo)
        {
            Codigo = codigo;
        }
        public string Codigo { get; private set; }
    }
}
