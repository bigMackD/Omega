﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Omega.Entities
{
    public class Client
    {
        [Key]
        public long ClientId { get; set; }

        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string NIP { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string PropertyNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}