namespace ErrorHandlingAssignment.Exceptions
{
    class OverHeatingException : Exception
    {
        public OverHeatingException(string message) : base(message)
        {

        }

        public void HandleOverHeating()
        {
            Console.WriteLine("Please shutdown the engine to cool down!!!!");
        }

    }
}
