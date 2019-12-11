using System;
using System.IO;
using System.Collections.Generic;

using MVCRoleTop.Models;

namespace MVCRoleTop.Repositories
{
    public class EventoRepository
    {
        
        public const string PATH = "Database/Eventos.csv";

        public EventoRepository(){
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }

        }

        public bool Inserir(Evento evento)
        {
            var quantidadeEventos = File.ReadAllLines (PATH).Length;
            evento.ID = (ulong) ++quantidadeEventos;
            var linha = new string[]{PrepararRegistroCSV(evento)};
            File.AppendAllLines(PATH, linha);
            return true;
        }

        public Cliente ObterPor( string email )
        {
            var linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas){
                if(ExtrairValorDoCampo("login",linha) == email){
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


        public void Aprovar( string ID )
        {
            var linhas = File.ReadAllLines(PATH);
            for(int i =0; i < linhas.Length; i++)
            {
                if(ExtrairValorDoCampo("ID",linhas[i]) == ID){
                    Evento c = new Evento();
                    c.ID = ulong.Parse(ExtrairValorDoCampo("ID",linhas[i]));
                    c.DonoDoEvento = ExtrairValorDoCampo("DonoDoEvento",linhas[i]);
                    c.Nome = ExtrairValorDoCampo("Nome",linhas[i]);
                    c.TipoDeEvento = ExtrairValorDoCampo("TipoDeEvento",linhas[i]);
                    c.NumeroDePessoas = int.Parse(ExtrairValorDoCampo("NumeroDePessoas",linhas[i]));
                    c.DataDoEvento = DateTime.Parse(ExtrairValorDoCampo("DataDoEvento",linhas[i]));
                    c.Status = 1;
                    linhas[i] = PrepararRegistroCSV(c);
                    File.WriteAllLines(PATH, linhas);
                    break;
                }
            }
        }
        public void Cancelar( string ID )
        {
            var linhas = File.ReadAllLines(PATH);
            for(int i =0; i < linhas.Length; i++)
            {
                if(ExtrairValorDoCampo("ID",linhas[i]) == ID){
                    Evento c = new Evento();
                    c.ID = ulong.Parse(ExtrairValorDoCampo("ID",linhas[i]));
                    c.DonoDoEvento = ExtrairValorDoCampo("DonoDoEvento",linhas[i]);
                    c.Nome = ExtrairValorDoCampo("Nome",linhas[i]);
                    c.TipoDeEvento = ExtrairValorDoCampo("TipoDeEvento",linhas[i]);
                    c.NumeroDePessoas = int.Parse(ExtrairValorDoCampo("NumeroDePessoas",linhas[i]));
                    c.DataDoEvento = DateTime.Parse(ExtrairValorDoCampo("DataDoEvento",linhas[i]));
                    c.Status = 2;
                    linhas[i] = PrepararRegistroCSV(c);
                    File.WriteAllLines(PATH, linhas);
                    break;
                }
            }
        }




        public List<Evento> ObterEventosCliente( string NomeCliente )
        {
            List<Evento> Eventos = new List<Evento>();
            var linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas){
                if(ExtrairValorDoCampo("DonoDoEvento",linha) == NomeCliente){
                    Evento c = new Evento();
                    c.ID = ulong.Parse(ExtrairValorDoCampo("ID",linha));
                    c.DonoDoEvento = ExtrairValorDoCampo("DonoDoEvento",linha);
                    c.Nome = ExtrairValorDoCampo("Nome",linha);
                    c.TipoDeEvento = ExtrairValorDoCampo("TipoDeEvento",linha);
                    c.NumeroDePessoas = int.Parse(ExtrairValorDoCampo("NumeroDePessoas",linha));
                    c.DataDoEvento = DateTime.Parse(ExtrairValorDoCampo("DataDoEvento",linha));
                    c.Status = uint.Parse(ExtrairValorDoCampo("Status",linha));
                    Eventos.Add(c);
                }
            }
            return Eventos;
        }

        public List<Evento> ObterTodosEventosPendentes( )
        {
            List<Evento> Eventos = new List<Evento>();
            var linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas){
                if(ExtrairValorDoCampo("Status",linha) == "0"){
                    Evento c = new Evento();
                    c.ID = ulong.Parse(ExtrairValorDoCampo("ID",linha));
                    c.DonoDoEvento = ExtrairValorDoCampo("DonoDoEvento",linha);
                    c.Nome = ExtrairValorDoCampo("Nome",linha);
                    c.TipoDeEvento = ExtrairValorDoCampo("TipoDeEvento",linha);
                    c.NumeroDePessoas = int.Parse(ExtrairValorDoCampo("NumeroDePessoas",linha));
                    c.DataDoEvento = DateTime.Parse(ExtrairValorDoCampo("DataDoEvento",linha));
                    c.Status = uint.Parse(ExtrairValorDoCampo("Status",linha));
                    Eventos.Add(c);
                }
            }
            return Eventos;
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

        private string PrepararRegistroCSV(Evento evento)
        {
            return $"ID={evento.ID};DonoDoEvento={evento.DonoDoEvento};Nome={evento.Nome};DataDoEvento={evento.DataDoEvento};TipoDeEvento={evento.TipoDeEvento};NumeroDePessoas={evento.NumeroDePessoas};Status={evento.Status}";
        }





    }
}