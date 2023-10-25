using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrintCalculator
{
    public class EmailEntity
    {
        public string? Email { get; set; }
        public int NumberOfInboxEmails { get; set; }
        public int NumberOfSentEmails { get; set; }
        public int NumberOfSpamEmails { get; set; }
    }
}
