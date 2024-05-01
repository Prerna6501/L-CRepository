namespace InventoryManagement.CustomExceptions
{
    public class InsufficientQuantityException : Exception
    {
        public InsufficientQuantityException(string message) : base(message)
        {
        }
    }
}
