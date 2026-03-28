using System.Linq;

namespace DotNet_Lab01_Core
{
    public static class CarStorageExtensions
    {
        // Extension method for CarStorage: returns the oldest car
        public static Car GetOldestCar(this CarStorage storage)
        {
            return storage == null ? null : storage.OrderBy(c => c.ManufactirngYear).FirstOrDefault();
        }

        // Extension for CarStorage: count electric cars
        public static int CountElectricCars(this CarStorage storage)
        {
            if (storage == null) return 0;
            return storage.WhereElectric().Count();
        }
    }
}
