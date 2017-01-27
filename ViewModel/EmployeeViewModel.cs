using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewModel
{
    public class EmployeeViewModel : ViewModelBase
    {
        private DataLayer.Employee _employee;



        public DataLayer.Employee Employee
        {
            get
            {
                if (_employee == null)
                {
                    _employee = new DataLayer.Employee();
                }

                return _employee;
            }

            set
            {
                _employee = value;
                OnPropertyChanged("");
            }
        }

       
    }
}
