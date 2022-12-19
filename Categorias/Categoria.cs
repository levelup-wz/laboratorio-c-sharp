using System;

namespace Comex.Categorias
{
    public class Categoria
    {
        public static int Quantidade { get; private set; }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Status { get; set; }

        public Categoria(string nome, string status)
        {
            Quantidade++;
            Id = Quantidade;
            
            if (nome.Length <= 3) 
            {
                throw new ArgumentException("Nome deve ser maior que 3 caracteres");
            }
            if (status != "ATIVA" && status != "INATIVA")
            {
                throw new ArgumentException("Status deve ser somente ATIVA ou INATIVA");
            }
            
            Nome = nome;
            Status = status;
        }
    }
}
