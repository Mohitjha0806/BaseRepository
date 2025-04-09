using System.ComponentModel.DataAnnotations;

namespace BaseRepository.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public int DepartmentId { get; set; }
    }

}
