using System.Collections.Generic;
using System.Linq;
using OperatorStatusList.Models;

namespace OperatorStatusList.Queries.Operators
{
    // Naming convension: Queries.{controller}.{method}Query
    public class GetQuery
    {
        private readonly CallCentreContext callCentreContext = new CallCentreContext();

        public GetResult Execute(GetParameters parameters)
        {
            return new GetResult
            {
                Operators = callCentreContext.Operators
                    .Select(o =>
                        new OperatorResult
                        {
                            ID = o.ID,
                            Name = o.Name,
                            Extension = o.Extension,
                            CallStatus = o.CallStatus,
                            CallStatusText = o.CallStatus == CallStatus.Available
                                ? "available"
                                : "on call"
                        })
                    .ToArray()
            };
        }
    }

    public class GetParameters
    {
    }

    public class GetResult
    {
        public IEnumerable<OperatorResult> Operators { get; set; }
    }

    public class OperatorResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Extension { get; set; }
        public CallStatus CallStatus { get; set; }
        public string CallStatusText { get; set; }
    }
}