﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacations.Models
{
    public class RequestProcessViewModel
    {
        public string EmployeeID { get; set; }

        public string VacationID { get; set; }

        public string EmployeeName { get; set; }

        public string JobTitle { get; set; }

        public string TeamName { get; set; }

        public string TeamLeadName { get; set; }

        [Display(Name = "vacation type")]
        public string VacationType { get; set; }

        [Required(ErrorMessage = " required field")]
        [Display(Name = "from")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBegin { get; set; }

        [Required(ErrorMessage = " required field")]
        [Display(Name = "to")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfEnd { get; set; }

        [Display(Name = "Comment")]
        public string Comment { get; set; }

        [Required(ErrorMessage = " required field")]
        [Display(Name = "duration")]
        [Range(1, 28, ErrorMessage = " should be from 1 to 28.")]
        public int Duration { get; set; }

        public string Status { get; set; }

        public string ProcessedBy { get; set; }

        public int EmployeesBalance { get; set; }
    }
}
