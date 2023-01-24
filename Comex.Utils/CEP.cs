namespace Comex.Utils
{
    ///<sumary>
    /// Funções para CEP do Brasil
    ///</sumay>
    public class Correios
    {
        /// <summary>
        /// Method <c>Draw</c> renders the point.
        /// </summary>
        public Regiao ObterRegiaoPorCEP(string cep)
        {
            var regiao = cep.Trim().Substring(0,1);
            return (Regiao)Convert.ToInt16(regiao);
        }
    }

    public enum Regiao
    {
        Santos,
        SaoPaulo,
        RJ,
        BH
    }
}
