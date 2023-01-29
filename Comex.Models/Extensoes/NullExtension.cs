namespace Comex.Models.Exceptions
{
    public static class NullExtension
    {
        public static bool IsNull(this object obj) => obj == null;
    }
}
