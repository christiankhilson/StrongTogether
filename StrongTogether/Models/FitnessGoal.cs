using System.ComponentModel.DataAnnotations;

namespace StrongTogether.Models
{
    public class FitnessGoal
    {
        [Key]
        public int FitnessId { get; set; }
        public string FitnessDescription { get; set;}
    }
}
