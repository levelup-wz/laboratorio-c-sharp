namespace Comex.Models.Models
{
    public class Categoria
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }

        public Categoria()
        {
            Id = _id++;
        }

        public Categoria(int id, string nome, string status)
        {
            Id = id;
            Nome = nome;
            Status = status;

            if (id <= 0)
            {
                throw new ArgumentException("ID deve ser maior que ZERO.", nameof(id));
            }
            if (nome.Length <= 3)
            {
                throw new ArgumentException("Nome deve ter mais que 3 caracteres", nameof(nome));
            }
            if (status != "ATIVA" && status != "INATIVA")
            {
                throw new ArgumentException("só permite os valores ATIVA e INATIVA", nameof(status));
            }
        }

        public int DefineId()
        {
            return Id;
        }
    }
}
