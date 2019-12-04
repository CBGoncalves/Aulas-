using System.IO;
using MVCRoleTop.Models;

namespace MVCRoleTop.Repositories
{
    public class OrcamentoRepository
    {
        private const string PATH = "Database/Orcamento.csv";
        public OrcamentoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        public bool Inserir (Orcamento orcamento)
        {
            var linha = new string[] { PrepararOrcamentoCSV(orcamento) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        
        private string PrepararOrcamentoCSV(Orcamento orcamento)
        {
            return $"nome={orcamento.Nome};email={orcamento.Email};telefone={orcamento.Telefone};data_evento={orcamento.DataEvento};tipo_evento={orcamento.Evento};numero_pessoas={orcamento.NumPessoas};como_conheceu={orcamento.ComoConheceu};observacoes={orcamento.Observacoes}";
        }

    }
}