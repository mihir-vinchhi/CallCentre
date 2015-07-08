using System.Web.Http;
using OperatorStatusList.Queries.Operators;

namespace OperatorStatusList.Controllers
{
    public class OperatorsController : ApiController
    {
        public GetResult Get()
        {
            // Execute the query and return the result
            // This prevents direct access to the domain models and put the controller on diet
            return new GetQuery().Execute(new GetParameters());
        }
    }
}