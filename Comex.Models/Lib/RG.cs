namespace Comex.Models.Lib
{
    public class RG : Documento
    {
        public RG()
        {
            this.DocumentoInterno = false;
        }

        public override bool Valido()
        {
            return true;
        }
    }
}
