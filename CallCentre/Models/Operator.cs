using System.ComponentModel.DataAnnotations;

namespace OperatorStatusList.Models
{
    public class Operator
    {
        public int ID { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }
        
        public int Extension { get; set; }
        
        public CallStatus CallStatus { get; set; }
    }

    public enum CallStatus
    {
        Available = 0,
        Engage
    }
}