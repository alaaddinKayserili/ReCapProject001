using Business.Concrete;
using Core.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car { CarId = 6, BrandId = 1, ColorId = 2, ModelYear = "2021", DailyPrice = 450, Description = "not6" };

            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //Console.WriteLine("---------Kayıt Eklendi-------------");
            //carManager.Add(car1);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId + " " + car.BrandId + " " + car.ColorId + " " + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);

            //}
            //Console.WriteLine("---------Silme-------------");
            //carManager.Delete(car1);

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId + " " + car.BrandId + " " + car.ColorId + " " + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);

            //}
            //Console.WriteLine("---------Guncelleme-------------");

            //Car car2 = new Car { CarId = 3, BrandId = 3, ColorId = 1, ModelYear = "2012", DailyPrice = 225, Description = "Guncelleme işlemi yapıldı" };
            //carManager.Update(car2);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId + " " + car.BrandId + " " + car.ColorId + " " + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);

            //}
            //Console.WriteLine("---------Id e göre bilgi getirme-------------");
            //foreach (var car in carManager.GetById(5))
            //{
            //    Console.WriteLine(car.CarId + " " + car.BrandId + " " + car.ColorId + " " + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);

            //}
            //Console.WriteLine("---------Car------------");
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId+"-"+car.ColorId+"-"+car.BrandId+"-"+car.ModelYear+"-"+car.DailyPrice+"-"+car.Description);
            //}
            //Console.WriteLine("---------Color------------");
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorId+"-"+color.Name);
            //}
            //Console.WriteLine("---------Brand------------");
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandId + "-" + brand.Name);
            //}
            //Console.WriteLine("---------car-colorName-BrandName------------");
            //foreach (var car in carManager.GetCarDetailDtos())
            //{
            //    Console.WriteLine(car.CarId+"-"+car.ColorName+"-"+car.BrandName+"-"+car.DailPrice+"-"+car.Description);
            //}

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetailDtos();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "--" + car.ColorName);
                }
            }
            else {
                Console.WriteLine(result.Message);
            }



            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result1 = rentalManager.GetAll();
            if (result1.Success == true)
            {
                foreach (var rental in result1.Data)
                {
                    Console.WriteLine(rental.Id+"---"+rental.CarId+"---"+rental.CustomerId+"---"+rental.RentDate+"---"+rental.ReturnDate);
                }
            }

            var result3 = rentalManager.GetRentalDetailDtos();
            if (result3.Success==true)
            {
                foreach (var ren in result3.Data)
                {
                    Console.WriteLine(ren.CarId+"-"+ren.BrandName+"-"+ren.CarId+"-"+ren.FirsName+"-"+ren.LastName+"-"+ren.CompanyName);
                }
                Console.WriteLine(result3.Message);
            }

            Console.WriteLine("------------------------");
            var result4 = carManager.GetAll(1);
            if (result4.Success==true)
            {
                foreach ( var car in result4.Data)
                {
                    Console.WriteLine(car.CarId+"--"+car.ColorId+"--"+car.BrandId+"--"+car.DailyPrice);
                }
            }
            Console.ReadKey();
        }
    }
}
