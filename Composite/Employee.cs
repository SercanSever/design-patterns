using Composite.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Employee : IPerson,IEnumerable<IPerson>
    {
        public string Name { get; set; }


        List<IPerson> _supOrdinates = new List<IPerson>();
        public void AddSupOrdinates(IPerson person)
        {
            _supOrdinates.Add(person);
        }
        public void RemoveSupOrdinates(IPerson person)
        {
            _supOrdinates.Remove(person);
        }
        public IPerson GetSubOrdinate(int index)
        {
            return _supOrdinates[index];
        }
        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var supOrdinates in _supOrdinates)
            {
                yield return supOrdinates;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
