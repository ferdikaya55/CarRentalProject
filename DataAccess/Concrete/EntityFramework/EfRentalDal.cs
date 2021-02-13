using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,RentCarContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>>filter= null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from re in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars
                             on re.CarId equals ca.Id
                             join cu in context.Customers
                             on re.CustomerId equals cu.Id
                             join us in context.Users
                             on cu.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 Id = re.Id,
                                 CarName = ca.CarName,
                                 CustomerName = cu.CompanyName,
                                 CarId = ca.Id,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 UserName = us.FirstName + " " + us.LastName
                             };
                return result.ToList();
            }
        }
    }
}
