using Business.Concrete;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        // IEntity Child Objects

        private static Car car = new Car();
        private static Color color = new Color();
        private static Brand brand = new Brand();
        private static User user = new User();
        private static Customer customer = new Customer();
        private static Rental rental = new Rental();

        // Manager Objects

        private static CarManager carManager = new CarManager(new EfCarDal());
        private static ColorManager colorManager = new ColorManager(new EfColorDal());
        private static BrandManager brandManager = new BrandManager(new EfBrandDal());
        private static UserManager userManager = new UserManager(new EfUserDal());
        private static CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        private static RentalManager rentalManager = new RentalManager(new EfRentalDal());

        public static void Main(string[] args)
        {
            // *************** CAR TEST *************** //

            // Get all car details +
            // GetAllCarDetailsCarTest();

            // Get all cars by brand id +
            // GetAllByBrandIdCarTest();

            // Get all cars by color id +
            // GetAllByColorIdCarTest();

            // Get car by id +
            // GetByIdCarTest();

            // List all cars +
            // GetAllCarTest();

            // Add a new car +
            // car.BrandId = ;
            // car.ColorId = ;
            // car.ModelYear = ;
            // car.DailyPrice = ;
            // car.Description = "";
            // AddCarTest(car);

            // Update a car +
            // car.Id = ;
            // car.BrandId = ;
            // car.ColorId = ;
            // car.ModelYear = ;
            // car.DailyPrice = ;
            // car.Description = "";
            // UpdateCarTest(car);


            // Delete a car
            // car.Id = ;
            // DeleteCarTest(car);


            // *************** COLOR TEST *************** //

            // Get color by id + 
            // GetByIdColorTest();

            // List all colors +
            // GetAllColorTest();

            // Add a new color + 
            // color.Name = "";
            // AddColorTest(color);

            // Update a color +
            // color.Id = ;
            // color.Name = "";
            // UpdateColorTest(color);

            // Delete a color +
            // color.Id = ;
            // DeleteColorTest(color);


            // *************** BRAND TEST *************** //

            // Get brand by id +
            // GetByIdBrandTest();

            // List all brands +
            // GetAllBrandTest();

            // Add a new brand +
            // brand.Name = "";
            // AddBrandTest(brand);

            // Update a brand +
            // brand.Id = ;
            // brand.Name = "";
            // UpdateBrandTest(brand);

            // Delete a brand +
            // brand.Id = ;
            // DeleteBrandTest(brand);

            // *************** USER TEST *************** //

            // Get user by id +
            // GetByIdUserTest();

            // List all users +
            // GetAllUserTest();

            // Add a new user +
            // user.FirstName = "";
            // user.LastName = "";
            // user.Email = "";
            // user.Password = "";
            // AddUserTest(user);

            // Update a user +
            // user.Id = ;
            // user.FirstName = "";
            // user.LastName = "";
            // user.Email = "";
            // user.Password = "";
            // UpdateUserTest(user);

            // Delete a user 
            // user.Id = ;
            // DeleteUserTest(user);

            // *************** CUSTOMER TEST *************** //

            // Get customer by id +
            // GetByIdCustomerTest();

            // List all customers +
            // GetAllCustomerTest();

            // Add a new customer +
            // customer.UserId = "";
            // customer.CompanyName = "";
            // AddCustomerTest(customer);

            // Update a customer 
            // customer.Id = ;
            // customer.UserId = "";
            // customer.CompanyName = "";
            // UpdateCustomerTest(customer);

            // Delete a customer 
            // customer.Id = ;
            // DeleteCustomerTest(customer);

            // *************** RENTAL TEST *************** //

            // Get all rentals by car id
            // GetAllByCarIdRentalTest();

            // Get all rentals by customer id
            // GetAllByCustomerIdRentalTest();

            // Get rental by id 
            // GetByIdRentalTest();

            // List all rentals +
            // GetAllRentalTest();

            // Add a new rental +
            //rental.CarId = ;
            //rental.CustomerId = ;
            //AddRentalTest(rental);

            // Update a rental +
            // rental.Id = ;
            // rental.CarId = ;
            // rental.CustomerId = ;
            // rental.RentDate = ;
            // rental.ReturnDate = ;
            // UpdateRentalTest(rental);

            // Delete a rental
            // rental.Id = ;
            // DeleteRentalTest(rental);

            // Return a car +
            // rental.Id = ;
            // ReturnACarRentalTest(rental);

        }

        // ******************************************************** ******************************************************** //

        // Car Test

        private static void GetAllCarDetailsCarTest()
        {
            var result = carManager.GetAllCarDetails();

            PrintCarDetails(result.Data);
        }

        private static void GetCarsByBrandIdCarTest(int brandId)
        {
            var result = carManager.GetAllByBrandId(brandId);

            PrintCars(result.Data);
        }
        private static void GetCarsByColorIdCarTest(int colorId)
        {
            var result = carManager.GetAllByColorId(colorId);

            PrintCars(result.Data);
        }
        private static void GetByIdCarTest(int id)
        {
            var result = carManager.GetById(id);

            PrintCar(result.Data);

        }
        private static void GetAllCarTest()
        {
            var result = carManager.GetAll();

            PrintCars(result.Data);
        }
        private static void AddCarTest(Car car)
        {
            var result = carManager.Add(car);

            PrintIResult(result);
        }
        private static void UpdateCarTest(Car car)
        {
            var result = carManager.Update(car);

            PrintIResult(result);
        }
        private static void DeleteCarTest(Car car)
        {
            var result = carManager.Delete(car);

            PrintIResult(result);
        }

        // Car Print Test

        private static void PrintCars(List<Car> listOfCars)
        {
            foreach (var car in listOfCars)
            {
                PrintCar(car);
            }
        }

        private static void PrintCar(Car singleCar)
        {
            Console.WriteLine("Car Id: " + singleCar.Id);
            Console.WriteLine("Car Brand Id: " + singleCar.BrandId);
            Console.WriteLine("Car Color Id: " + singleCar.ColorId);
            Console.WriteLine("Car Model Year: " + singleCar.ModelYear);
            Console.WriteLine("Car Daily Price: " + singleCar.DailyPrice);
            Console.WriteLine("Car Description: " + singleCar.Description);
            Console.WriteLine("***********************************");
        }

        // Car Detail Print Test

        private static void PrintCarDetails(List<CarDetailDto> listOfCarDetails)
        {
            foreach (var carDetail in listOfCarDetails)
            {
                PrintCarDetail(carDetail);
            }
        }

        private static void PrintCarDetail(CarDetailDto singleCarDetail)
        {
            Console.WriteLine("CarDetail Id: " + singleCarDetail.CarId);
            Console.WriteLine("CarDetail Model Year: " + singleCarDetail.ModelYear);
            Console.WriteLine("CarDetail Daily Price: " + singleCarDetail.DailyPrice);
            Console.WriteLine("CarDetail Description: " + singleCarDetail.Description);
            Console.WriteLine("CarDetail Brand Id: " + singleCarDetail.BrandId);
            Console.WriteLine("CarDetail Brand Name: " + singleCarDetail.BrandName);
            Console.WriteLine("CarDetail Color Id: " + singleCarDetail.ColorId);
            Console.WriteLine("CarDetail Color Name: " + singleCarDetail.ColorName);
            Console.WriteLine("***********************************");
        }

        // ******************************************************** ******************************************************** //

        // Color Test

        private static void GetByIdColorTest(int id)
        {
            var result = colorManager.GetById(id);

            PrintColor(result.Data);

        }
        private static void GetAllColorTest()
        {
            var result = colorManager.GetAll();

            PrintColors(result.Data);
        }
        private static void AddColorTest(Color color)
        {
            var result = colorManager.Add(color);

            PrintIResult(result);
        }
        private static void UpdateColorTest(Color color)
        {
            var result = colorManager.Update(color);

            PrintIResult(result);
        }
        private static void DeleteColorTest(Color color)
        {
            var result = colorManager.Delete(color);

            PrintIResult(result);
        }

        // Color Print Test

        private static void PrintColors(List<Color> listOfColors)
        {
            foreach (var color in listOfColors)
            {
                PrintColor(color);
            }
        }

        private static void PrintColor(Color singleColor)
        {
            Console.WriteLine("Color Id: " + singleColor.Id);
            Console.WriteLine("Color Name: " + singleColor.Name);
            Console.WriteLine("***********************************");
        }

        // ******************************************************** ******************************************************** //

        // Brand Test

        private static void GetByIdBrandTest(int id)
        {
            var result = brandManager.GetById(id);

            PrintBrand(result.Data);

        }
        private static void GetAllBrandTest()
        {
            var result = brandManager.GetAll();

            PrintBrands(result.Data);
        }
        private static void AddBrandTest(Brand brand)
        {
            var result = brandManager.Add(brand);

            PrintIResult(result);
        }
        private static void UpdateBrandTest(Brand brand)
        {
            var result = brandManager.Update(brand);

            PrintIResult(result);
        }
        private static void DeleteBrandTest(Brand brand)
        {
            var result = brandManager.Delete(brand);

            PrintIResult(result);
        }

        // Brand Print Test

        private static void PrintBrands(List<Brand> listOfBrands)
        {
            foreach (var brand in listOfBrands)
            {
                PrintBrand(brand);
            }
        }

        private static void PrintBrand(Brand singleBrand)
        {
            Console.WriteLine("Brand Id: " + singleBrand.Id);
            Console.WriteLine("Brand Name: " + singleBrand.Name);
            Console.WriteLine("***********************************");
        }

        // ******************************************************** ******************************************************** //

        // User Test

        private static void GetByIdUserTest(int id)
        {
            var result = userManager.GetById(id);

            PrintUser(result.Data);

        }
        private static void GetAllUserTest()
        {
            var result = userManager.GetAll();

            PrintUsers(result.Data);
        }
        private static void AddUserTest(User user)
        {
            var result = userManager.Add(user);

            PrintIResult(result);
        }
        private static void UpdateUserTest(User user)
        {
            var result = userManager.Update(user);

            PrintIResult(result);
        }
        private static void DeleteUserTest(User user)
        {
            var result = userManager.Delete(user);

            PrintIResult(result);
        }

        // User Print Test

        private static void PrintUsers(List<User> listOfUsers)
        {
            foreach (var user in listOfUsers)
            {
                PrintUser(user);
            }
        }

        private static void PrintUser(User singleUser)
        {
            Console.WriteLine("User Id: " + singleUser.Id);
            Console.WriteLine("User First Name: " + singleUser.FirstName);
            Console.WriteLine("User Last Name: " + singleUser.LastName);
            Console.WriteLine("User Email: " + singleUser.Email);
            Console.WriteLine("User Password: " + singleUser.PasswordHash);
            Console.WriteLine("***********************************");
        }

        // ******************************************************** ******************************************************** //

        // Customer Test

        private static void GetByIdCustomerTest(int id)
        {
            var result = customerManager.GetById(id);

            PrintCustomer(result.Data);

        }
        private static void GetAllCustomerTest()
        {
            var result = customerManager.GetAll();

            PrintCustomers(result.Data);
        }
        private static void AddCustomerTest(Customer customer)
        {
            var result = customerManager.Add(customer);

            PrintIResult(result);
        }
        private static void UpdateCustomerTest(Customer customer)
        {
            var result = customerManager.Update(customer);

            PrintIResult(result);
        }
        private static void DeleteCustomerTest(Customer customer)
        {
            var result = customerManager.Delete(customer);

            PrintIResult(result);
        }

        // Customer Print Test

        private static void PrintCustomers(List<Customer> listOfCustomers)
        {
            foreach (var customer in listOfCustomers)
            {
                PrintCustomer(customer);
            }
        }

        private static void PrintCustomer(Customer singleCustomer)
        {
            Console.WriteLine("Customer Id: " + singleCustomer.Id);
            Console.WriteLine("Customer User Id: " + singleCustomer.UserId);
            Console.WriteLine("Customer Company Name: " + singleCustomer.CompanyName);
            Console.WriteLine("***********************************");
        }

        // ******************************************************** ******************************************************** //

        // Rental Test

        private static void GetByIdRentalTest(int id)
        {
            var result = rentalManager.GetById(id);

            PrintRental(result.Data);

        }
        private static void GetAllRentalTest()
        {
            var result = rentalManager.GetAll();

            PrintRentals(result.Data);
        }
        private static void AddRentalTest(Rental rental)
        {
            var result = rentalManager.Add(rental);

            PrintIResult(result);
        }
        private static void UpdateRentalTest(Rental rental)
        {
            var result = rentalManager.Update(rental);

            PrintIResult(result);
        }
        private static void DeleteRentalTest(Rental rental)
        {
            var result = rentalManager.Delete(rental);

            PrintIResult(result);
        }

        private static void GetAllByCustomerId(int customerId)
        {
            var result = rentalManager.GetAllByCustomerId(customerId);

            PrintRentals(result.Data);
        }
        private static void GetAllByCarId(int carId)
        {
            var result = rentalManager.GetAllByCustomerId(carId);

            PrintRentals(result.Data);
        }

        private static void ReturnACarRentalTest(Rental rental)
        {
            var result = rentalManager.ReturnACar(rental);

            PrintIResult(result);
        }

        // Rental Print Test

        private static void PrintRentals(List<Rental> listOfRentals)
        {
            foreach (var rental in listOfRentals)
            {
                PrintRental(rental);
            }
        }

        private static void PrintRental(Rental singleRental)
        {
            Console.WriteLine("Rental Id: " + singleRental.Id);
            Console.WriteLine("Rental Car Id: " + singleRental.CarId);
            Console.WriteLine("Rental Customer Id: " + singleRental.CustomerId);
            Console.WriteLine("Rental Rent Date: " + singleRental.RentDate);
            Console.WriteLine("Rental Return Date: " + singleRental.ReturnDate);
            Console.WriteLine("***********************************");
        }

        // ******************************************************** ******************************************************** //

        private static void PrintIResult(IResult iResult)
        {
            Console.WriteLine("Message: " + iResult.Message);
            Console.WriteLine("Success: " + iResult.Success);
            Console.WriteLine("***********************************");
        }

    }
}
