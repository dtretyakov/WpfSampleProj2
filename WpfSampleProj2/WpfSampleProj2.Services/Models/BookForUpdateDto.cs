﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WpfSampleProj2.Services.Models
{
    public class BookForUpdateDto : BookForManipulationDto
    {
        [Required(ErrorMessage ="You should fill out description")]
        public override string Description { get => base.Description; set => base.Description = value; }
    }
}
