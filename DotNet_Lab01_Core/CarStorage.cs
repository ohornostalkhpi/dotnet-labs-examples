using System.Collections.Generic;
using System.Linq;

namespace DotNet_Lab01_Core
{
    // CarStorage implements IEnumerable<Car> for full LINQ support.
    // Note: In C#, 'duck typing' allows foreach to work if a class has a public GetEnumerator() method returning IEnumerator<T>,
    // even if it does NOT explicitly implement IEnumerable<T>. However, LINQ extension methods like OrderBy require IEnumerable<T>.
    // So, for full compatibility, explicit interface implementation is preferred.
    public class CarStorage : IEnumerable<Car>
    {
        private List<Car> _cars = new List<Car>();
        private Dictionary<string, Car> _carDict = new Dictionary<string, Car>();

        public void Add(Car car)
        {
            if (car != null && !_carDict.ContainsKey(car.Name))
            {
                _cars.Add(car);
                _carDict[car.Name] = car;
            }
        }

        // Implements IEnumerable<Car>
        public IEnumerator<Car> GetEnumerator()
        {
            foreach (var car in _cars)
                yield return car;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Car FindByName(string name)
        {
            Car car;
            return _carDict.TryGetValue(name, out car) ? car : null;
        }

        public IEnumerable<Car> WhereElectric()
        {
            return _carDict.Values.Where(c => c.IsElectric);
        }
    }
}
