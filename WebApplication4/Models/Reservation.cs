using System.ComponentModel.DataAnnotations.Schema;
using WebApplication4.Repository;
using System.ComponentModel.DataAnnotations;
namespace WebApplication4.Models
{
    public class Reservation : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public DateTime reservationStart { get; set; }
        public DateTime reservationEnd { get; set; }
        public virtual Vehicle? Vehicle { get; set; }

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
    }
}
