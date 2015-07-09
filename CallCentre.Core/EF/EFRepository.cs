using System.Linq;
using CallCentre.Core.Framework;

namespace CallCentre.Core.EF
{
    public class EFRepository : IRepository
    {
        // Should be injected
        private readonly CallCentreContext callCentreContext = new CallCentreContext();

        public IQueryable<T> Query<T>() where T : class
        {
            return callCentreContext.Set<T>();
        }
    }
}