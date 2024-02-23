
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ManufacturerService: IManufacturerService
    {
        public void AddManufacturer(Manufacturer manufacturer) => ManufacturerRepo.Instance.AddManufacturer(manufacturer);

        public void DeleteManufacturerById(string id) => ManufacturerRepo.Instance.DeleteManufacturerById(id);

        public Manufacturer GetManufacturerById(string id) => ManufacturerRepo.Instance.GetManufacturerById(id);

        public IEnumerable<Manufacturer> GetManufacturerList() => ManufacturerRepo.Instance.GetManufacturerList();

        public void UpdateManufacturer(Manufacturer manufacturer) => ManufacturerRepo.Instance.UpdateManufacturer(manufacturer);
    }
}
