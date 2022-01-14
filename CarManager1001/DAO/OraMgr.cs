using CarManager0811.Model;
using CarManager0902;
using CarManager0902.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest0827.DAO
{
    class OraMgr
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=scott; Password=1234;";

        readonly OracleConnection conn;
        readonly OracleCommand cmd;
        static OraMgr instance;

        public static OraMgr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OraMgr();
                }
                return instance;
            }
        }

        // 생성자
        public OraMgr()
        {
            Console.WriteLine("오라클 객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        // 소멸자
        ~OraMgr()
        {
            closeDB();
            Console.WriteLine("오라클 객체 소멸");
        }

        public void connectDB()
        {
            // 예외 처리
            // 접속 성공시
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            // 접속 실패시
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류" + e.Message);
                Environment.Exit(0);
            }
        }

        public void closeDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 접속 해제");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류: " + e.Message);
            }
        }

        public void createTable()
        {
            try
            {
                string sql = "CREATE TABLE STUDENTS_T (" +
                    "ID NUMBER NOT NULL," +
                    "NAME VARCHAR(20) NOT NULL," +
                    "AGE NUMBER NOT NULL," +
                    "ADDR VARCHAR(80) NOT NULL," +
                    "CONSTRAINT PK_STUDENTS_ID PRIMARY KEY(ID))";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seq = "CREATE SEQUENCE SEQU_ID " +
                    "INCREMENT BY 1 START WITH 1000";
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 생성 오류: " + e.Message);
            }
        }

        public void dropTable()
        {
            try
            {
                string sql = "DROP TABLE STUDENTS_T";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                string sequ = "DROP SEQUENCE SEQU_ID";
                cmd.CommandText = sequ;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블(시퀀스) 삭제 오류: " + e.Message);
            }

        }

        public void insertDB()
        {
            try
            {
                string name = "홍길동";
                int age = 200;
                string addr = "조선 한양 홍대감댁 11번지";
                string sql = string.Format("insert into students_t values (" +
                    "sequ_id.nextval, '{0}', {1}, '{2}')", name, age, addr);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("데이터 추가 완료");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public void insertDB(Customer cust)
        {
            try
            {
                string sql = string.Format("insert into customer_0827 values (" +
                    "customer_0827_seq.nextval, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    cust.Name, cust.Tel, cust.Addr, cust.Birth, cust.Gender, cust.Date);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                List<string> hbList = cust.HobbyList;
                string[] hbArr = new string[6];
                for (int i = 0; i < hbList.Count; i++)
                {
                    hbArr[i] = hbList[i];
                }
                string sqlHb = string.Format("insert into customer_hb_0827 values (" +
                    "customer_hb_0827_seq.nextval, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', customer_0827_seq.currval)",
                    hbArr[0], hbArr[1], hbArr[2], hbArr[3], hbArr[4], hbArr[5]);
                cmd.CommandText = sqlHb;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public void insertDB(Car car)
        {
            try
            {
                string sql = string.Format("insert all " +
                    "into car_0827 values (car_0827_seq.nextval, '{0}', '{1}', '{2}', '{3}')",
                    car.Name, car.Color, car.Price, car.InsuDate);

                sql += string.Format("into sales_0827 values (" +
                    "sales_0827_seq.nextval, sales_0827_seq.currval, " +
                    "sales_0827_seq.currval, '{0}')", car.Manager);
                sql += "select * from dual";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("차량 데이터 추가 오류: " + e.Message);
            }
        }

        public void showDB()
        {
            string sql = "select*from students_t order by id desc";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Console.WriteLine("ID: " + rd["id"]);
                    Console.WriteLine("이름: " + rd["name"]);
                    Console.WriteLine("나이: " + rd["age"]);
                    Console.WriteLine("주소: " + rd["addr"]);
                    Console.WriteLine("==============================");
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
        }

        public List<SalesVo> getSalesVo()
        {
            string sql = "select sa.cid as 고객ID, ca.name as 차량명, ca.price as 가격, " +
                "ca.insu_date as 인수날짜, cu.name as 고객명, cu.tel as 연락처, " +
                "cu.jupsu_date as 접수날짜, sa.manager as 담당자 " +
                "from car_0827 ca, customer_0827 cu, sales_0827 sa " +
                "where sa.carid = ca.carid and sa.cid = cu.cid";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            //int count = 1;
            List<SalesVo> list = new List<SalesVo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SalesVo saVo = new SalesVo
                        (rd["차량명"].ToString(), 
                        int.Parse(rd["가격"].ToString()),
                        rd["인수날짜"].ToString(), 
                        rd["고객명"].ToString(), 
                        rd["연락처"].ToString(),
                        rd["접수날짜"].ToString(), 
                        rd["담당자"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<SalesVo> getSearchCarNameVo(string name)
        {
            string sql = string.Format("select sa.cid as 고객ID, ca.name as 차량명, ca.price as 가격, " +
                "ca.insu_date as 인수날짜, cu.name as 고객명, cu.tel as 연락처, " +
                "cu.jupsu_date as 접수날짜, sa.manager as 담당자 " +
                "from car_0827 ca, customer_0827 cu, sales_0827 sa " +
                "where sa.carid = ca.carid and sa.cid = cu.cid " +
                "and ca.name='{0}'", name);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            //int count = 1;
            List<SalesVo> list = new List<SalesVo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SalesVo saVo = new SalesVo
                        (rd["차량명"].ToString(),
                        int.Parse(rd["가격"].ToString()),
                        rd["인수날짜"].ToString(),
                        rd["고객명"].ToString(),
                        rd["연락처"].ToString(),
                        rd["접수날짜"].ToString(),
                        rd["담당자"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<SalesVo> getSearchCusNameVo(string name)
        {
            string sql = string.Format("select sa.cid as 고객ID, ca.name as 차량명, ca.price as 가격, " +
                "ca.insu_date as 인수날짜, cu.name as 고객명, cu.tel as 연락처, " +
                "cu.jupsu_date as 접수날짜, sa.manager as 담당자 " +
                "from car_0827 ca, customer_0827 cu, sales_0827 sa " +
                "where sa.carid = ca.carid and sa.cid = cu.cid " +
                "and cu.name='{0}'", name);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            //int count = 1;
            List<SalesVo> list = new List<SalesVo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SalesVo saVo = new SalesVo
                        (rd["차량명"].ToString(),
                        int.Parse(rd["가격"].ToString()),
                        rd["인수날짜"].ToString(),
                        rd["고객명"].ToString(),
                        rd["연락처"].ToString(),
                        rd["접수날짜"].ToString(),
                        rd["담당자"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<HobbyVo> getCustHobbyVo(string name)
        {
            string sql = string.Format("select hb.health, hb.game, hb.study, hb.drinking, hb.sleeping, hb.bruise " +
                        "from sales_0827_view sv, customer_hb_0827 hb " +
                        "where 고객ID = hb.cid and 고객명 = '{0}'",name);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            //int count = 1;
            List<HobbyVo> list = new List<HobbyVo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    HobbyVo hbVo = new HobbyVo
                        (rd["health"].ToString(),
                        rd["game"].ToString(),
                        rd["study"].ToString(),
                        rd["drinking"].ToString(),
                        rd["sleeping"].ToString(),
                        rd["bruise"].ToString());
                    list.Add(hbVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<Customer> getCustomerVo(string name, string tel)
        {
            string sql = string.Format("select * from customer_0827 " +
                "where name='{0}' and tel='{1}'", name, tel);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            //int count = 1;
            List<Customer> list = new List<Customer>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Customer cust = new Customer
                        (rd["name"].ToString(),
                        rd["tel"].ToString(),
                        rd["addr"].ToString(),
                        rd["jupsu_date"].ToString(),
                        rd["birth"].ToString(),
                        rd["gender"].ToString()
                        );
                    list.Add(cust);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<Car> getCarVo(string name)
        {
            string sql = string.Format("select c.name, c.color, c.price, " +
                "c.insu_date, s.manager from car_0827 c, sales_0827 s " +
                "where s.carid = c.carid and name = '{0}'",name);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            //int count = 1;
            List<Car> list = new List<Car>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Car car = new Car
                        (rd["name"].ToString(),
                        rd["color"].ToString(),
                        int.Parse(rd["price"].ToString()),
                        rd["insu_date"].ToString(),
                        rd["manager"].ToString());
                    list.Add(car);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public string login(string passwd)
        {
            //string check = "";
            string check = string.Empty;
            
            string sql = string.Format("select count(*) as 행의개수, " +
                "decode(count(*), 1, '성공', 0, '실패', 'None') as 결과 " + 
                "from admin_t where id = 'admin' and func_decrypt(pwd) = '{0}'",passwd);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    check = rd["결과"].ToString();
                    Console.WriteLine("암호 확인: " + check);
                }
            }
            else
            {
                Console.WriteLine("암호가 일치하지 않습니다.");
            }
            rd.Close();
            return check;
        }

        public List<SalesVo> getSearchUnion(string[] ans)
        {
            string[] que = new string[]
            {
                "ca.name", "cu.name", "cu.jupsu_date", "sa.manager"
            };

            //string sqlTail = string.Empty;
            StringBuilder sqlTail = new StringBuilder();
            for (int i = 0; i < ans.Length; i++)
            {
                if(ans[i] != "")
                {
                    /*sqlTail += " and ";
                    sqlTail += que[i];
                    sqlTail += "=";
                    sqlTail += "'"+ ans[i]+"'";*/
                    sqlTail.Append(" and ");
                    sqlTail.Append(que[i]);
                    sqlTail.Append("=");
                    sqlTail.Append("'" + ans[i] + "'");
                }
            }

            string sql = "select sa.cid as 고객ID, ca.name as 차량명, ca.price as 가격, " +
                "ca.insu_date as 인수날짜, cu.name as 고객명, cu.tel as 연락처, " +
                "cu.jupsu_date as 접수날짜, sa.manager as 담당자 " +
                "from car_0827 ca, customer_0827 cu, sales_0827 sa " +
                "where sa.carid = ca.carid and sa.cid = cu.cid";
            sql = sql + sqlTail;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<SalesVo> list = new List<SalesVo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SalesVo saVo = new SalesVo
                        (rd["차량명"].ToString(),
                        int.Parse(rd["가격"].ToString()),
                        rd["인수날짜"].ToString(),
                        rd["고객명"].ToString(),
                        rd["연락처"].ToString(),
                        rd["접수날짜"].ToString(),
                        rd["담당자"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
    }
}
