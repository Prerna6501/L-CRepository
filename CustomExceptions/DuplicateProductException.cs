namespace InventoryManagement.CustomExceptions
{
    public class DuplicateProductException : Exception
    {
        public DuplicateProductException(string message) : base(message) 
        {           
        }
    }
}
