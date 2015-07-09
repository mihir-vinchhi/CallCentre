using System.Collections.Generic;
using System.Linq;
using CallCentre.Core.EF;
using CallCentre.Core.Framework;
using CallCentre.Core.Models;

namespace CallCentre.Core.Queries.Operators
{
    // CQRS Query
    // Naming convension: Queries.{controller}.{method}Query
    public class GetQuery
    {
        // Should be injected
        private readonly IRepository repository = new EFRepository();

        public GetResult Execute(GetParameters parameters)
        {
            return new GetResult
            {
                Operators = repository.Query<Operator>()
                    .OrderBy(o => o.Extension)
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

    // Naming convension: Queries.{controller}.{method}Parameters
    public class GetParameters
    {
    }

    // Naming convension: Queries.{controller}.{method}Result
    public class GetResult
    {
        public IEnumerable<OperatorResult> Operators { get; set; }
    }

    // Naming convension: Queries.{controller}.{child-model}Result
    public class OperatorResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Extension { get; set; }
        public CallStatus CallStatus { get; set; }
        public string CallStatusText { get; set; }
    }
}