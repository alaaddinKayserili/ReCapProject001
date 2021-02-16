
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }  //Brand=marka
        public int ColorId { get; set; }
        public string ModelYear { get; set; } //model yılı
        public decimal DailyPrice { get; set; } //gunluk fıyat
        public string Description { get; set; }  //aciklama
    }
}
