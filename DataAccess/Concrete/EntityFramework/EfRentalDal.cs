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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (var context=new MyReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.CustomerId
                             join u in context.Users
                             on c.UserId equals u.Id
                             join car in context.Cars
                             on r.CarId equals car.CarId
                             join b in context.Brands
                             on car.BrandId equals b.BrandId
                             select new RentalDetailDto
                             {
                                 Id=r.Id,
                                 CarId=car.CarId,
                                 BrandName=b.Name,
                                 ModelYear=car.ModelYear,
                                 DailyPrice=car.DailyPrice,
                                 CustomerId=c.CustomerId,
                                 FirsName=u.FirsName,
                                 LastName=u.LastName,
                                 CompanyName=c.CompanyName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate
                                 
                             };
                return result.ToList();
            }
        }
    }
}
