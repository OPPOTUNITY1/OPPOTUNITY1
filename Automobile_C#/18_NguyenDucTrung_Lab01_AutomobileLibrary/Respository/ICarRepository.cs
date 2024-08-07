using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _18_NguyenDucTrung_Lab01_AutomobileLibrary.DataAccess;

namespace _18_NguyenDucTrung_Lab01_AutomobileLibrary.Respository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int id);
        void InsertCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(Car car);
    }
}
