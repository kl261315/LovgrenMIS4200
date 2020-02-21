using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace LovgrenMIS4200.DAL
{
    public class Cars
    {
        public int CarsID { get; set; }

        [Display (Name= "Car Nick Name")]
        [Required (ErrorMessage = "Car nick name required!")]
        [StringLength(20)]
        public string carNickName { get; set; }

        [Display(Name = "License Plate")]
        [Required(ErrorMessage = "License plate required!")]
        [StringLength(20)]
        public string license { get; set; }

        [Display(Name = "Car Year")]
        [Required]
        [StringLength(20)]
        public string carYear { get; set; }

        [Display(Name = "Car Make")]
        [Required]
        [StringLength(20)]
        public string carMake { get; set; }

        [Display(Name = "Car Model")]
        [Required]
        [StringLength(20)]
        public string carModel { get; set; }


    }
}