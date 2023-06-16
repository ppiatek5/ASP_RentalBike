using WebApplication4.Repository;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Vehicle : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual VehicleType? VehicleType { get; set; }

        [ForeignKey("VehicleType")]
        public int VehicleTypeId { get; set; }
        
        public decimal Price { get; set; }  

    }
}
