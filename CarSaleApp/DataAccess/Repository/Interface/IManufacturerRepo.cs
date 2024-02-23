﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IManufacturerRepo
    {
        public void AddManufacturer(Manufacturer manufacturer);

        public void DeleteManufacturerById(string id);

        public Manufacturer GetManufacturerById(string id);

        public IEnumerable<Manufacturer> GetManufacturerList();

        public void UpdateManufacturer(Manufacturer manufacturer);
    }
}
