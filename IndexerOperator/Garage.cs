using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOperator
{
    public class Garage
    {
        
        /// <summary>
        /// Adds a car to the garage
        /// </summary>
        /// <param name="car">The car to be added to the garage</param>
        public void Add(Car car)
        {
            //Searches the list for any occurrences of the given car
            if (cars.FindAll((c) => { return c.Equals(car); }).Count == 0)
            {
                cars.Add(car);
            }
        }

        /// <summary>
        /// Returns the car at the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Car Get(int index)
        {
            return cars.ElementAt(index);
        }

        /// <summary>
        /// Removes a car from the garage
        /// </summary>
        /// <param name="car">The instance of the car to be removed from the garage</param>
        public void Remove(Car car)
        {
            cars.Remove(car);
        }

        /// <summary>
        /// The number of cars in the garage
        /// </summary>
        public int Count
        {
            get { return cars.Count; }
        }

        public void Clean()
        {
            foreach(var car in cars)
            {
                car.Clean = true;
            }
        }

        public void Repair()
        {
            foreach(var car in cars)
            {
                car.DamageAmount = 0;
            }
        }

        public Car this[int index]
        {
            get
            {
                return Get(index);
            }
        }

        protected List<Car> cars = new List<Car>();
    }
}
