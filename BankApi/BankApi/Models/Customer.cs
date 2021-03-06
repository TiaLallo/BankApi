﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApi.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Account = new HashSet<Account>();
        }

        public Customer(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public long Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public long BankId { get; set; }
        [StringLength(10)]
        public string Password { get; set; }

        [ForeignKey("BankId")]
        [InverseProperty("Customer")]
        public virtual Bank Bank { get; set; }
        [InverseProperty("BankNavigation")]
        public virtual ICollection<Account> Account { get; set; }
    }
}