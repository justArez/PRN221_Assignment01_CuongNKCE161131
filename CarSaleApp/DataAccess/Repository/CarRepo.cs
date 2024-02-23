using BusinessObject;
using DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CarRepo: ICarRepo
    {
        private static CarRepo instance = null;
        private static readonly object instanceLock = new object();
        public static CarRepo Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarRepo();
                    }
                }
                return instance;
            }
        }
        public void AddCar(Car car) => CarDAO.Instance.Add(car);

        public void DeleteCarById(string id) => CarDAO.Instance.Delete(id);

        public Car GetCarById(string id) => CarDAO.Instance.GetCarByID(id);

        public IEnumerable<Car> GetCarList() => CarDAO.Instance.GetCarList();

        public void UpdateCar(Car car) => CarDAO.Instance.Update(car);
    }
}
