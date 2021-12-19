using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Date Required.")]
        [Remote("CheckDate", "Validation")]
        public DateTime? Date { get; set; }
        [Required(ErrorMessage = "Low Temp Required.")]
        [Range(-200, 200, ErrorMessage = "Low Temp Range: -200 - 200.")]
        public double? Low { get; set; }
        [Required(ErrorMessage = "High Temp Required.")]
        [Range(-200, 200, ErrorMessage = "High Temp Range: -200 - 200.")]
        public double? High { get; set; }
    }
}
