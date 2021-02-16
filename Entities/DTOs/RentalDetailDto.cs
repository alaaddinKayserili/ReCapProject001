﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class RentalDetailDto:IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public int CustomerId { get; set; }
        public string FirsName { get; set; }
        public  string LastName { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
