using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;

namespace ViewModel
{
    public class EmployeesViewModel : ViewModelBase
    {
        private List<DataLayer.Employee> _listEmployees;
        private AdventureWorks2014Entities db = new AdventureWorks2014Entities();

        public List<DataLayer.Employee> listEmployees
        {
            get
            {
                if (_listEmployees == null)
                {
                    _listEmployees = db.Employee.ToList();
                }

                return _listEmployees;
            }
            set
            {
                _listEmployees = value;
                OnPropertyChanged("");

            }
        }

    }
}
