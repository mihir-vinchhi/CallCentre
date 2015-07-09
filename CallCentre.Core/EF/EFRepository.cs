using System.Linq;
using CallCentre.Core.Framework;

namespace CallCentre.Core.EF
{
    public class EFRepository : IRepository
    {
        private readonly CallCentreContext callCentreContext = new CallCentreContext();

        public IQueryable<T> Query<T>() where T : class
        {
            return callCentreContext.Set<T>();
        }
    }
}