using System;
using System.Collections.Generic;
using System.Text;

namespace DataformValidation
{
   public class ViewModel
    {
        private EmployeeInfo employeeInfo;

        public EmployeeInfo EmployeeInfo
        {
            get { return employeeInfo; }
            set { employeeInfo = value; }
        }

        public ViewModel()
        {
            EmployeeInfo = new EmployeeInfo();
        }
    }
}
