namespace Comex.Utils
{
    public class Correios
    {

        public string ObterRegiaoPorCEP(string cep)
        {
            int regiao = int.Parse(cep.Substring(0, 1));

            switch (regiao)
            {
                case 0 :
                    return "Região 0 - Sede São Paulo (Grande São Paulo)";                    
                case 1 :
                    return "Região 1 - Sede Santos";                    
                case 2:
                    return "Região 2 - Sede Rio de Janeiro";                    
                case 3:
                    return "Região 3 - Sede Belo Horizonte";                    
                case 4:
                    return "Região 4 - Sede Salvador";
                case 5:
                    return "Região 5 - Sede Recife";                    
                case 6:                
                    return "Região 6 - Sede Fortaleza";                    
                case 7:                
                    return "Região 7 - Sede Brasília";                    
                case 8:               
                    return "Região 8 - Sede Curitiba";                    
                case 9:               
                    return "Região 9 - Sede Porto Alegre";
                default:
                    return "O CEP fornecedo é inválido!";
            }
        }
    }
}