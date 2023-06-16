using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.ViewModels
{
    public class VehicleDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int VehicleTypeId { get; set; }
        [NotMapped]
        public List<SelectListItem> VehicleTypes { get; set; }
        public int RentalPointId { get; set; }
        [NotMapped]
        public List<SelectListItem> RentalPoints { get; set; }
    }
}
