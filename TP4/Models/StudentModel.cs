using System.ComponentModel.DataAnnotations;

namespace TP4.Models
{
    public class StudentModel
    {
        [Key] public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int phone_number { get; set; }
        public string university { get; set; }
    public int timestamp { get; set; }
        public string course { get; set; }
    }
}
