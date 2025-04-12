using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs
{
    
    class CalculateSalaryEmp
    {
        public delegate bool FilterDelegate(CEmployee emp);
        public event FilterDelegateEventHandeler FilterEvent;
        public delegate void FilterDelegateEventHandeler(CEmployee emp,int salary);

         public void  CalculateSalaryEmpE1(List<CEmployee> empList, FilterDelegate predecate)
        {
            foreach (CEmployee emp in empList)
            {
                if (predecate(emp))
                {
                    //Console.WriteLine($"Id : {emp.Id} \nName : {emp.Name}\nSalary : {emp.Salary}");
                   // FilterEvent(emp, emp.Salary);
                   FilterEvent?.Invoke(emp, emp.Salary);
                }
            }

        }
    }
}
