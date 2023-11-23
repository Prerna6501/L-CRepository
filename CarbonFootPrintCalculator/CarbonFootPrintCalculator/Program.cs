using CarbonFootPrintCalculator;

class Program
{
    static void Main(string[] args)
    {
        EmailEntity emailEntity = new EmailEntity();

        Console.Write("Enter your email: ");
        emailEntity.Email = Console.ReadLine();

        Console.Write("Number of inbox mails: ");
        emailEntity.NumberOfInboxEmails = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number of sent mail:");
        emailEntity.NumberOfSentEmails = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number of spam mail: ");
        emailEntity.NumberOfSpamEmails = Convert.ToInt32(Console.ReadLine());

        GetCarbonFootprintForEmail(emailEntity);
    }

    static void GetCarbonFootprintForEmail(EmailEntity entity)
    {
        double inboxCarbonFootprint = (entity.NumberOfInboxEmails * 4.0) / 1000;//with attachment 50
        double sentCarbonFootprint = (entity.NumberOfSentEmails * 4.0) / 1000;
        double spamCarbonFootprint = (entity.NumberOfSpamEmails * 0.3) / 1000;
        double totalCarbonFootprint = inboxCarbonFootprint + sentCarbonFootprint + spamCarbonFootprint;

        Console.WriteLine("emailId: " + entity.Email);
        Console.WriteLine("inbox: " + inboxCarbonFootprint + " KG");
        Console.WriteLine("sent: " + sentCarbonFootprint + " KG");
        Console.WriteLine("spam: " + spamCarbonFootprint + " KG");
        Console.WriteLine("Total Carbon Footprint of " + entity.Email + " is " + totalCarbonFootprint + " KG");
    }
}
