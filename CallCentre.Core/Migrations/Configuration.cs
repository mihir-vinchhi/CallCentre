using System.Data.Entity.Migrations;
using CallCentre.Core.Models;

namespace CallCentre.Core.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CallCentreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CallCentreContext context)
        {
            context.Operators.AddOrUpdate(
                o => o.ID,
                new Operator { Name = "Fuller Andrew", Extension = 101, CallStatus = CallStatus.Available },
                new Operator { Name = "Leverling Janet", Extension = 102, CallStatus = CallStatus.Engage },
                new Operator { Name = "Peacock Margaret", Extension = 103, CallStatus = CallStatus.Available },
                new Operator { Name = "Buchanan Steven", Extension = 104, CallStatus = CallStatus.Engage },
                new Operator { Name = "Suyama Michael", Extension = 105, CallStatus = CallStatus.Available },
                new Operator { Name = "Callahan Laura", Extension = 106, CallStatus = CallStatus.Available },
                new Operator { Name = "Dodsworth Anne", Extension = 107, CallStatus = CallStatus.Engage },
                new Operator { Name = "Davolio Nancy", Extension = 108, CallStatus = CallStatus.Available });
        }
    }
}
