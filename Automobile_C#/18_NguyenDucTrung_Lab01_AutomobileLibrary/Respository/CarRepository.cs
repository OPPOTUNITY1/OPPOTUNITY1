using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _18_NguyenDucTrung_Lab01_AutomobileLibrary.DataAccess;

namespace _18_NguyenDucTrung_Lab01_AutomobileLibrary.Respository
{
    public class CarRepository : ICarRepository
    {
        public IEnumerable<Car> GetCars() => CarManagement.Instance.GetCarList();
        public Car GetCarByID(int id) => CarManagement.Instance.GetCarByID(id);
        public void InsertCar(Car car) => CarManagement.Instance.Add(car);
        public void UpdateCar(Car car) => CarManagement.Instance.Update(car);
        public void DeleteCar(Car car) => CarManagement.Instance.Remove(car);
    }
}
