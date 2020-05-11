using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo
{
    public class Employee:ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address EmpAddress { get; set; }

        public Employee ShallowCopy()
        {
            throw new NotImplementedException();
        }

        public Employee DeepCopy()
        {
           var copiedEmployee =  (Employee)Clone();
            copiedEmployee.EmpAddress = new Address()
            {
                ZipCode = this.EmpAddress.ZipCode,
                Country = this.EmpAddress.Country,
                DoorNumber = this.EmpAddress.DoorNumber,
                StreetNumber = this.EmpAddress.StreetNumber
            };
            return copiedEmployee;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string GetSummary()
        {
            return $"The employee with the Id of {Id}, and name is {Name}, " +
                $"Address is No.{EmpAddress.DoorNumber}, Street{EmpAddress.StreetNumber}, Country{EmpAddress.Country}, Zip{EmpAddress.ZipCode}";
        }
    }
}
