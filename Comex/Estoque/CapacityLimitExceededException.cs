namespace Comex
{
  class CapacityLimitExceededException : Exception
  {
    public CapacityLimitExceededException(string message) : base(message)
    {
    }
  }
}