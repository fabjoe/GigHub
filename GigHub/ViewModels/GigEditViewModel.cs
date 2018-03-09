using GigHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GigHub.ViewModels
{
    public class GigEditViewModel : GigFormViewModel
    {
        [Required]
        public int Id { get; set; }
    }
}