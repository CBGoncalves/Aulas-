using System;
using System.IO;
using MVCRoleTop.Models;

namespace MVCRoleTop.Repositories
{
    public class ClienteRepository
    {
        
        public const string PATH = "Database/Cliente.csv";

        public ClienteRepository(){
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }

        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[]{PrepararRegistroCSV(cliente)};
            File.AppendAllLines(PATH, linha);
            return true;
        }

        public Cliente ObterPor( string Usuario )
        {
            var linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas){
                if(ExtrairValorDoCampo("Usuario",linha) == Usuario){
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("Nome",linha);
                    c.Usuario = ExtrairValorDoCampo("Usuario",linha);
                    c.Senha = ExtrairValorDoCampo("Senha",linha);
                    c.Email = ExtrairValorDoCampo("Email",linha);
                    c.DataDeNascimento = DateTime.Parse(ExtrairValorDoCampo("DataDeNascimento",linha));
                    return c;
                }
            }
            return null;
        }
        public string ExtrairValorDoCampo( string nomeCampo, string linha )
        {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);
            var indiceTerminal = linha.IndexOf(";",indiceChave);
            var valor = "";

            if(indiceTerminal != -1){
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }else{
                valor = linha.Substring(indiceChave);
            }
            return valor.Replace(nomeCampo + "=","");
        }

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"Nome={cliente.Nome};Usuario={cliente.Usuario};Senha={cliente.Senha};Email={cliente.Email};DataDeNascimento={cliente.DataDeNascimento}";
        }





    }
}