using System;

namespace PrototypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address() { Country="China",ZipCode=200300,DoorNumber=315,StreetNumber=799};
            var employee = new Employee() { Id = 1, Name = "Toby" };
            employee.EmpAddress = address;
            var copyEmployee = (Employee)employee.DeepCopy();
            employee.Id = 2;
            employee.Name = "Jason";
            employee.EmpAddress.Country = "America";
            employee.EmpAddress.ZipCode = 345678;
            Console.WriteLine("employee Info:" + employee.GetSummary());
            Console.WriteLine("copyEmployee Info:" + copyEmployee.GetSummary());
            Console.ReadLine();
        }
    }
}
