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
        // S2933 오류
        // 읽기, 쓰기 둘 다 해야함으로 예외처리
#pragma warning disable S2933 // Fields that are only assigned in the constructor should be "readonly"
        List<Employee> list = new List<Employee>();
#pragma warning restore S2933 // Fields that are only assigned in the constructor should be "readonly"

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
            // S1117 오류
            // 사용자 정의 변수명 예외처리
            List<Employee> list = OraMgr.Instance.getEmployeeVo();
            return list;
        }
    }
}
