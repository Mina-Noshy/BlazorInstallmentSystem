using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebModels.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        [MaxLength(30)]
        [Required]
        public string AddressDetails { get; set; }

        [MaxLength(15)]
        [Phone]
        [Required]
        public string Phone_1 { get; set; }

        [MaxLength(15)]
        [Phone]
        public string Phone_2 { get; set; }

        [MaxLength(15)]
        [Phone]
        public string Phone_3 { get; set; }

        [MaxLength(30)]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Fax { get; set; }

        public virtual ICollection<Bill> GetBills { get; set; }
    }
}
