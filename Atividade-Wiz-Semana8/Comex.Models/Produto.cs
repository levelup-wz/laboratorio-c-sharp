namespace Comex.Models
{
    public class Produto
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descircao { get; set; }
        public double PrecoUnitario { get; set; }
        public double QuantidadeEmEstoque { get; set; }
        public string Categoria { get; set; }
        protected string Atributos { get; set; }

        public Produto (string nome, double preco_Unitario, double quantidade_Em_Estoque, string categoria, string atributos)
        {
            Id = _id++;
            Nome = nome;
            PrecoUnitario = preco_Unitario;
            QuantidadeEmEstoque = quantidade_Em_Estoque;
            Categoria = categoria;
            Atributos = atributos;
        }

        public Produto (int id, string nome, double preco_Unitario, double quantidade_Em_Estoque, string categoria)
        {
            Id = id;
            Nome = nome;
            PrecoUnitario = preco_Unitario;
            QuantidadeEmEstoque = quantidade_Em_Estoque;
            Categoria = categoria;

            if (id <= 0)
            {
                throw new ArgumentException("ID deve ser maior que ZERO.", nameof(id));
            }
            if (nome.Length <= 5)
            {
                throw new ArgumentException("Nome deve ter mais que 5 caracteres", nameof(nome));
            }
            if (preco_Unitario <= 0)
            {
                throw new ArgumentException("Preço unitário não pode ser ZERO.", nameof(preco_Unitario));
            }
            if (quantidade_Em_Estoque <= 0)
            {
                throw new ArgumentException("Não é possível inserir um produto com a quantidade ZERO no estoque.", nameof(quantidade_Em_Estoque));
            }
            if (categoria.Length <= 0)
            {
                throw new ArgumentException("Obrigatorio definir a categoria do produto.", nameof(categoria));
            }
        }

        public int DefineId()
        {
            return Id;
        }

        public double CalculaValorTotalEmEstoque()
        {
            double resultado = QuantidadeEmEstoque * PrecoUnitario;
            return resultado;
        }

        public virtual double CalculaImposto()
        {
            double resultado = PrecoUnitario * 0.40;
            return resultado;
        }
    }
}
