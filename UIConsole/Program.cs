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
            
            
            
            
            
            //OptionsMenu();

        }
        private static void OptionsMenu(){
            Console.WriteLine("Araç Kiralama Sistemimizde İşlem Yapabilmek İçin Menüden Seçim Yapınız");
            Console.WriteLine("Araç işlemleri için      :" + "1");
            Console.WriteLine("Marka işlemleri için     :" + "2");
            Console.WriteLine("Renk işlemleri için      :" + "3");
            Console.WriteLine("Kullanıcı işlemleri için :" + "4");
            Console.WriteLine("Müşteri işlemleri için   :" + "5");
            Console.WriteLine("Kiralama işlemleri için  :" + "6");
            Console.WriteLine("Çıkış için               :" + "0");
           

            string selectedMenu = Console.ReadLine();

            switch (selectedMenu)
            {
                case "1":
                    Console.WriteLine("Araç işlemleri seçildi");
                   // CarTest();
                    break;
                case "2":
                    Console.WriteLine("Marka işlemleri seçildi");
                    //BrandTest();
                    break;
                case "3":
                    Console.WriteLine("Renk işlemleri seçildi");
                    break;
                case "4":
                    Console.WriteLine("Kullanıcı işlemleri seçildi");
                   //UserTest();
                    break;
                case "5":
                    Console.WriteLine("Müşteri işlemleri seçildi");
                  //  CustomerTest();
                    break;
                case "6":
                    Console.WriteLine("Kiralama işlemleri seçildi");
                 //   RentalTest();
                    break;
                case "0":
                    Console.WriteLine("Çıkış yapılıyor");
                    Console.ReadKey();
                    break;

            }
        }

       /* private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, ReturnDate = new DateTime(2021, 02, 13), RentDate = DateTime.Today });
            Console.WriteLine(result.Message);
        }
        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "Ali", LastName = "Kaya", Email = "jdsaksakld@gmail.com", Password = "22222" });
            Console.WriteLine(result.Message);
        }
        private static void CustomerTest()
        {
            
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result=customerManager.Add(new Customer
            {
                
                UserId = 1,
                CompanyName = "Genç Otomotiv"
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
            }*/
            
        
    }
}
