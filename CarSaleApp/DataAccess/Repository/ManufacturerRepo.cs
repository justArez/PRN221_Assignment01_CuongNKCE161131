using BusinessObject;
using DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ManufacturerRepo: IManufacturerRepo
    {
        private static ManufacturerRepo instance = null;
        private static readonly object instanceLock = new object();
        public static ManufacturerRepo Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ManufacturerRepo();
                    }
                }
                return instance;
            }
        }
        public void AddManufacturer(Manufacturer manufacturer) => ManufacturerDAO.Instance.Add(manufacturer);

        public void DeleteManufacturerById(string id) => ManufacturerDAO.Instance.Delete(id);

        public Manufacturer GetManufacturerById(string id) => ManufacturerDAO.Instance.GetManufacturerByID(id);

        public IEnumerable<Manufacturer> GetManufacturerList() => ManufacturerDAO.Instance.GetManufacturerList();

        public void UpdateManufacturer(Manufacturer manufacturer) => ManufacturerDAO.Instance.Update(manufacturer);
    }
}
