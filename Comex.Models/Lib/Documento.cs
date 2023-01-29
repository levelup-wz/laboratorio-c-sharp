namespace Comex.Models.Lib
{
    public abstract class Documento
    {
        public abstract bool Valido();

        protected bool DocumentoInterno {get;set;}
    }
}
