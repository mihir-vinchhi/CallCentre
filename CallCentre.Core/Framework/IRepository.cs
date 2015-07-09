using System.Linq;

namespace CallCentre.Core.Framework
{
    public interface IRepository
    {
        IQueryable<T> Query<T>() where T : class;
    }
}