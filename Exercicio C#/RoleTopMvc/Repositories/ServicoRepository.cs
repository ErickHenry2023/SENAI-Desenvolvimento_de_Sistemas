using System.Collections.Generic;
using System.IO;
using RoleTopMvc.Models;

namespace RoleTopMvc.Repositories
{
    public class ServicoRepository
    {
        private const string PATH = "Database/Servico.csv";

        public double ObterPrecoDe(string nomeServico)               /*/*Para pegar o preço do produto */ 
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeServico))
                {
                    preco = item.Preco;
                    break;
                }
                
            }
            return preco;
        }

        public List<Servico> ObterTodos()
        {
            List<Servico> servicos = new List<Servico>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Servico s = new Servico();
                string[] dados =linha.Split(";");
                s.Nome = dados[0];
                s.Preco = double.Parse(dados[1]);
                servicos.Add(s);
            }

            return servicos;
        }
    }
}