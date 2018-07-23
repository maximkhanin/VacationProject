﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vacations.Models
{
    public class ProfileVacationsViewModel
    {
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBegin { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfEnd { get; set; }

        public string Comment { get; set; }

        public string VacationType { get; set; }

        public string VacationStatusType { get; set; }

        public int Duration { get; set; }
    }
}