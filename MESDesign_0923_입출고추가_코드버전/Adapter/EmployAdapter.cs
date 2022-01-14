using MESDesign_code.DBO;
using MESDesign_code.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESDesign_code.Adapter
{
    class EmployAdapter
    {
        List<Employee> list = new List<Employee>();

        /*public List<Employee> getEmployList()
        {
            return list;
        }*/

        public void addToList(Employee emp)
        {
            list.Add(emp);
            addToDB(emp);
        }

        public void addToDB(Employee emp)
        {
            OraMgr.Instance.inserEmpDB(emp);
        }

        public List<Employee> getEmployeeDB()
        {
            List<Employee> list = OraMgr.Instance.getEmployeeVo();
            return list;
        }
    }
}
