using ErrorHandlingAssignment.Exceptions;

public class Program { 
static void Main(string[] args)
{
    Console.WriteLine("Starting the car.");
    try
    {
        StartCar();
    }
    catch (OutOfFuelException ex)
    {
        Console.WriteLine("Car couldn't start due to: " + ex.Message);
        ex.HandleOutOfFuelException();
    }
    catch (AccidentException ex)
    {
        Console.WriteLine("Car couldn't start due to: " + ex.Message);
        ex.HandleAccident();
    }
    catch (BrakeFailureException ex)
    {
        Console.WriteLine("Car couldn't start due to: " + ex.Message);
        ex.HandleBrakeFailure();
    }
    catch (OverHeatingException ex)
    {
        Console.WriteLine("Car couldn't start due to: " + ex.Message);
        ex.HandleOverHeating();
    }
    finally
    {
        Console.WriteLine("Be safe");
    }
}

static void StartCar()
{
    Random random = new Random();
    int carState = random.Next(0,7);

    if (carState < 2)
    {
        Console.WriteLine("Car started sucessfully!!!");
    }

    else if (carState >= 2 && carState < 4)
    {
        throw new OutOfFuelException("Out of gas!");
    }

    else if (carState >= 3 && carState < 5)
    {
        throw new AccidentException("SOS!!!!!Car involved in an accident!");
    }

    else if (carState >= 4 && carState < 6)
    {
        throw new OverHeatingException("Overheating can cause performance impact and cause accidents");
    }

    else if (carState >= 5 && carState < 7)
    {
        throw new BrakeFailureException("Alert!!! Break failure.");
    }
}
}