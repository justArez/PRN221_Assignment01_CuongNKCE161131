using BusinessObject;
using DataAccess;

namespace BusinessService
{
    public class CarService: ICarService
    {
        public void AddCar(Car car) => CarRepo.Instance.AddCar(car);

        public void DeleteCarById(string id) => CarRepo.Instance.DeleteCarById(id);

        public Car GetCarById(string id) => CarRepo.Instance.GetCarById(id);

        public IEnumerable<Car> GetCarList() => CarRepo.Instance.GetCarList();

        public void UpdateCar(Car car) => CarRepo.Instance.UpdateCar(car);
    }
}
