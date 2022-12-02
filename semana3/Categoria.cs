namespace Comex
{
    class Categoria
    {


        public Categoria(string descricao)
        {
            Descricao = descricao;
        }

        public Categoria()
        {

        }


        private string _descricao;

        public string Descricao { set; get; }
    }

    class Banco
    {
        public decimal Saldo { get; private set; }

        public void Debito(decimal valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
            {
                Console.WriteLine("Vc nao tem saldo");
            }

        }
    }
}


