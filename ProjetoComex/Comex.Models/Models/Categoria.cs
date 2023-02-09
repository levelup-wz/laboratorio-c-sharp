using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entidades
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        //public EStatus Status { get; private set; }
        public string Status { get; private set; }

        //public Categoria(string nome, EStatus status = EStatus.Ativa)
        //{
        //    Status = status;
        //    Nome = nome.ToUpper();
        //    Id = Categoria.numId;
        //    Categoria.numId++;
        //}

        public Categoria(string nome, string status = "Ativa")
        {
            Status = status;
            Nome = nome.ToUpper();
        }

        public Categoria(int id, string nome, string status)
        {
            try
            {
                ValidarCriacao(id, nome, status);
            }
            catch (ArgumentException error)
            {
                // Console.WriteLine(error.StackTrace);
                Console.WriteLine(error.Message);
                //throw;
            }
        }

        public void ListarCategoria()
        {
            Console.WriteLine($"{Nome} ({Id} - {Status})");
        }

        public void ValidarCriacao(int id, string nome, string status)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"Campo ID deve ser maior que ZERO");
            };
            if (nome.Length <= 3) 
            {
                throw new ArgumentException($"Campo NOME deve ter mais que 3 caracteres");
            }
            if (status != "Ativa" && status != "Inativa")
            {
                throw new ArgumentException($"Valor do campo STATUS é inválido");
            }
            else
            {
                Id = id;
                Nome = nome;
                Status = status.ToUpper();
                Console.WriteLine($"Categoria {Nome} criada com sucesso");
            }
            
        }
                
    }
}
