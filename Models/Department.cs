using System.ComponentModel.DataAnnotations;

namespace BaseRepository.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
