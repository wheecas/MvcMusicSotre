using MvcMusicStore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserName { get; set; }
        [Required]
        [StringLength(16,MinimumLength =1)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(16,MinimumLength =1)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [MaxWords(10,ErrorMessage ="太长了")]
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage ="邮箱地址不符合规范")]
        public string Email { get; set; }
        [Compare(nameof(Email))]
        public string EmailConfirm { get; set; }
        public decimal Total { get; set; }
        [Range(35,44)]
        public int Age { get; set; }
        [Range(typeof(decimal),"0.00","49.99")]
        public decimal Price { get; set; }
    }
}