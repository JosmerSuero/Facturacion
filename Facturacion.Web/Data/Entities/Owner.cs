using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Facturacion.Web.Data
{
    public class Owner
    {
        public int ID { get; set; }



        [MaxLength(30, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Document { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(12, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLenght(12, ErrorMessage: "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Cellphone")]
        public string CellPhone { get; set; }

        [MaxLength(100, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        public string Address { get; set; }

        [Display(Name = "Owner")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Owner")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
