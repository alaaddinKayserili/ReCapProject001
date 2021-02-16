using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyReCapContext context=new MyReCapContext())
            {
                var result = from c in context.Cars
                             join col in context.Colors
                             on c.ColorId equals col.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto { 
                             CarId=c.CarId,
                             Description=c.Description,
                             ColorName=col.Name,
                             BrandName=b.Name,
                             DailPrice=c.DailyPrice                             
                             };
                return result.ToList();
            }
        }
    }
}
