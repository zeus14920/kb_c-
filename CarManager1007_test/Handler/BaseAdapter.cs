using CarManager0811.Model;
using CarManager0902;
using CarManager0902.Model;
using oracleTest0827.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0811.Handler
{
    class BaseAdapter
    {
        // 고객정보를 저장하는 리스트
        readonly List<Customer> custList = new List<Customer>();
        readonly List<Car> carList = new List<Car>();

        public void AddToDB(Customer cust)
        {
            OraMgr.Instance.insertDB(cust);
        }

        public void addToList(Customer cust)
        {
            custList.Add(cust);
            AddToDB(cust);
        }

        public void addToList(Car car)
        {
            carList.Add(car);
            addToDB(car);
        }

        public void addToDB(Car car)
        {
            OraMgr.Instance.insertDB(car);
        }

        // db에서 매출정보를 가져옴.
        public List<SalesVo> getSalesDB()
        {
            List<SalesVo> list = OraMgr.Instance.getSalesVo();
            return list;
        }

        // 차량명으로 검색
        public List<SalesVo> getSearchCarNameVo(string name)
        {
            List<SalesVo> list = OraMgr.Instance.getSearchCarNameVo(name);
            return list;
        }

        // 고객명으로 검색
        public List<SalesVo> getSearchCusNameVo(string name)
        {
            List<SalesVo> list = OraMgr.Instance.getSearchCusNameVo(name);
            return list;
        }

        // 취미정보 가져옴.
        public List<HobbyVo> getHobbyVo(string name)
        {
            List<HobbyVo> list = OraMgr.Instance.getCustHobbyVo(name);
            return list;
        }

        // 고객정보 가지고 옴.
        public List<Customer> getCustomerVo(string name, string tel)
        {
            List<Customer> list = OraMgr.Instance.getCustomerVo(name, tel);
            return list;
        }

        public List<Car> getCarVo(string name)
        {
            List<Car> list = OraMgr.Instance.getCarVo(name);
            return list;
        }

        public List<SalesVo> getSearchUnionDB(string[] arr)
        {
            List<SalesVo> list = OraMgr.Instance.getSearchUnion(arr);
            return list;
        }
    }
}
