using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DataGrid_Control
{
    class PersonData
    {
        public List<Person> getPersons()
        {
            List<Person> PersonInfo = new List<Person>();

            for (int a = 0; a < 10; a++ )
            {
                PersonInfo.Add(new Person()
                {
                    Firstname = "Max " + a.ToString(),
                    Lastname = "Mustermann " + a.ToString(),
                    Department = "Production " + a.ToString()
                });
            }
                
            return PersonInfo;
        }
    }
}
