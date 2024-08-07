using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_NguyenDucTrung_Lab01_AutomobileLibrary.DataAccess
{
    internal class CarManagement
    {
        private static CarManagement instance = null;
        private static readonly object instanceLock = new object();
        private CarManagement() { }
        public static CarManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarManagement();
                    }
                    return instance;
                }
            }
        }
        // ------------------
        public IEnumerable<Car> GetCarList()
        {
            List<Car> cars;
            try
            {
                var myStockDB = new NguyenDucTrungMyStockContext();
                cars = myStockDB.Cars.ToList();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return cars;
        }
        // ----------------------------------
        public Car GetCarByID(int id)
        {
            Car car = null;
            try
            {
                var myStockDB = new NguyenDucTrungMyStockContext();
                car = myStockDB.Cars.SingleOrDefault(c => c.CarId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return car;
        }
        // ------------------------------
        public void Add(Car c)
        {
            try
            {
                Car car = GetCarByID(c.CarId);
                if (car != null)
                {
                    var myStockDB = new NguyenDucTrungMyStockContext();
                    myStockDB.Cars.Add(c);
                    myStockDB.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // -------------------------------------
        public void Update(Car car)
        {
            try
            {
                Car c = GetCarByID(car.CarId);
                if (c != null)
                {
                    var myStockDB = new NguyenDucTrungMyStockContext();
                    myStockDB.Entry<Car>(car).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    myStockDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Ther car does not exist");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // -----------------------------------
        public void Remove(Car car)
        {
            try
            {
                Car c = GetCarByID(car.CarId);
                if (c != null)
                {
                    var myStockDB = new NguyenDucTrungMyStockContext();
                    myStockDB.Cars.Remove(car);
                    myStockDB.SaveChanges();
                }
                else
                {
                    throw new Exception("The car does not exist");
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    
    }
}
