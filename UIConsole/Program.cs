using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //CustomerTest();
            //UserTest();
            RentalTest();

        }
        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, ReturnDate = new DateTime(2021, 02, 13), RentDate = DateTime.Today });
            Console.WriteLine(result.Message);
        }
        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "Ferdi", LastName = "Kaya", Email = "jdsaksakld@gmail.com", Password = "111111" });
            Console.WriteLine(result.Message);
        }
        private static void CustomerTest()
        {
            
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result=customerManager.Add(new Customer
            {
                
                UserId = 1,
                CompanyName = "Kuzenler Otomotiv"
            });
            Console.WriteLine(result.Message);
           
        
           
        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "--" + car.CarName + "--" + car.ColorName + "--" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
