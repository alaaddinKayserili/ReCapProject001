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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, MyReCapContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetailDtos()
        {
            using (MyReCapContext context=new MyReCapContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new CustomerDetailDto { 
                             CustomerId=c.CustomerId,
                             FirsName=u.FirsName,
                             CompanyName=c.CompanyName,
                             LastName=u.LastName,
                             Email=u.Email
                             };
                return result.ToList();
            }
        }
    }
}
