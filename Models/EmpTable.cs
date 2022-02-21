using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models
{
    public class EmpTable
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string age { get; set; }
    }
}
