
//Lista de CDs
//Lista de Hotwheels
//Lista de Figurinhas

namespace Loja
{
    class Carro
    {
        //visibilidade tipo Nome getter e setter
        public static int Id {get; set;}
        public int NumeroPortas { get; set; }
        public Cor Cor { get; set; }
        public string Nome { get; set; }
        public double Potencia { get; set;}
        public Modelo Modelo { get; set; }
        public TipoCambio Cambio { get; set; }
        public int Ano { get; set; }
        public List<Acessorio> Acessorios { get; set; }
        public OpcoesDeDirecao TipoDirecao {get; set;}

        public int QuantidadeDeAccessorios() {
            return Acessorios.Count;
        }
    }

    enum OpcoesDeDirecao
    {
        Eletrica = 1,
        Hidraulica = 2,
        Mecanica = 3
    }


    // enum Classificacao
    // {
    //     R = 'R',
    //     C = 'C',
    //     D = 'D'
    // }

    enum Cor
    {
        Azul,
        Branco,
        Cinza,

    }

    enum TipoCambio
    {
        AT,
        MT
    }

    class Acessorio
    {

    }

    class Modelo
    {

    }
}
