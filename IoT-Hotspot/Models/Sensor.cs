using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IoT_Hotspot.Models
{
    public class Sensor
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "You most associate an Erb")]
        public int erb_id { get; set; }
        
        [Required(ErrorMessage = "You most enter a series")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "num_serie")]
        public string num_serie { get; set; }

        [Required(ErrorMessage = "You most enter a password")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "passw")]
        public string passw { get; set; }

        [Required(ErrorMessage = "You most enter a voltage value")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "vol_1")]
        public string vol_1 { get; set; }

        [Required(ErrorMessage = "You most enter a voltage value")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "vol_2")]
        public string vol_2 { get; set; }

        [Required(ErrorMessage = "You most enter a voltage value")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "vol_3")]
        public string vol_3 { get; set; }

        [Required(ErrorMessage = "You most enter a temperature value")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "temp_1")]
        public string temp_1 { get; set; }

        [Required(ErrorMessage = "You most enter a temperature value")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "temp_2")]
        public string temp_2 { get; set; }

        [Required(ErrorMessage = "You most enter a temperature value")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "temp_3")]
        public string temp_3 { get; set; }

        [Required(ErrorMessage = "You most enter a temperature value")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "temp_4")]
        public string temp_4 { get; set; }

        [Required(ErrorMessage = "You most enter a open or close status")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "door_1")]
        public string door_1 { get; set; }

        [Required(ErrorMessage = "You most enter a open or close status")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "door_2")]
        public string door_2 { get; set; }

        [Required(ErrorMessage = "You most enter a open or close status")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "door_3")]
        public string door_3 { get; set; }

        [Required(ErrorMessage = "You most enter a open or close status")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "door_4")]
        public string door_4 { get; set; }

        [Required(ErrorMessage = "You most enter a on or off status")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "rlay_1")]
        public string rlay_1 { get; set; }

        [Required(ErrorMessage = "You most enter a on or off status")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "rlay_2")]
        public string rlay_2 { get; set; }

        [Required(ErrorMessage = "You most enter a on or off status")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "rlay_3")]
        public string rlay_3 { get; set; }

        [Required(ErrorMessage = "You most enter a on or off status")]
        [StringLength(255, ErrorMessage = "The input {0} most at least write {2} and the maximum {1} charaters")]
        [Display(Name = "rlay_4")]
        public string rlay_4 { get; set; }
        
        public string text { get; set; }

        [Required(ErrorMessage = "You most enter a date")]
        [DataType(DataType.DateTime)]
        [Display(Name = "created_at")]
        public DateTime created_at { get; set; }

        [Required(ErrorMessage = "You most enter a date")]
        [DataType(DataType.DateTime)]
        [Display(Name = "updated_at")]
        public DateTime updated_at { get; set; }
        
    }
}
