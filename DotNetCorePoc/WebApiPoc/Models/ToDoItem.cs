using System.ComponentModel.DataAnnotations;
namespace WebApiPoc.Models
{
    public class ToDoItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
        
    }
}