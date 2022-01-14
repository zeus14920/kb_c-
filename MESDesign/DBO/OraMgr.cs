using MESDesign.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESDesign.DBO
{
    class OraMgr
    {

        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=scott; Password=1234;";

        OracleConnection conn;
        OracleCommand cmd;
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
        public void insertLineEnvDB(LineEnvData env)
        {
            try
            {
                string sql = string.Format("insert into line_env_data_t " +
                    "values (LINE_ENV_DATA_T_SEQ.nextval, '{0}', '{1}', '{2}', '{3}')",
                    env.Time, env.Temp1, env.Humi1, env.Dust1);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("센서 데이터 추가 오류: " + e.Message);
            }
        }

        public void insertLineManagDB(LineProduce lineProduce)
        {
            try
            {
                string sql = string.Format("insert into line_manag_data_t " +
                    "values (LINE_MANAG_DATA_T_SEQ.nextval, '{0}', '{1}', '{2}')",
                    lineProduce.Time, lineProduce.Finished, lineProduce.Defective);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("센서 데이터 추가 오류: " + e.Message);
            }
        }

        public void inserEmpDB(Employee emp)
        {
            try
            {
                string sql = string.Format("INSERT INTO EMPLOYEE VALUES(EMPLOYEE_SEQ.nextval, " +
                    "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    emp.Name, emp.Gender, emp.Tel, emp.Depart, emp.Position, emp.Work);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public void insertMatDB(Material mat)
        {
            try
            {
                string sql = string.Format("insert all " +
                    "into warehouse values(WAREHOUSE_SEQ.nextval, 0) " +
                    "into material VALUES('{0}', '{1}', {2}, WAREHOUSE_SEQ.nextval) " +
                    "SELECT * from dual", mat.Code, mat.Name, mat.Price);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("자재 등록이 되었습니다.");
            }
            catch (OracleException e)
            {
                MessageBox.Show("데이터 추가 오류: " + e.Message);
            }
        }

        public void updateQuantityDB(Material mat)
        {
            try
            {
                string sql = string.Format("UPDATE warehouse set inventory=inventory+{0} " +
                    "where wno=(SELECT w.wno from warehouse w, material m where w.wno=m.wno and m.mcode='{1}')", 
                    mat.Invertory, mat.Code);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string sql2 = string.Format("INSERT into import " +
                    "values (IMPORT_SEQ.nextval, {0}, " +
                    "(SELECT w.wno from warehouse w, material m where w.wno=m.wno and m.mcode='{1}'), " +
                    "TO_char(sysdate,'YYYY-MM-DD HH24:MI:SS'))", 
                    mat.Wearing, mat.Code);
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public List<Employee> getEmployeeVo()
        {
            string sql = "SELECT * FROM employee";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Employee> list = new List<Employee>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Employee emp= new Employee
                        (
                        rd["ENAME"].ToString(),
                        rd["ESEX"].ToString(),
                        rd["ETEL"].ToString(),
                        rd["EDEPAR"].ToString(),
                        rd["ERANK"].ToString(),
                        rd["ETASK"].ToString()
                        );
                    list.Add(emp);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<Material> getMaterialPlusVo()
        {
            string sql = "select * from material";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Material> list = new List<Material>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Material mat = new Material
                        (
                        rd["MCODE"].ToString(),
                        rd["MNAME"].ToString(),
                        rd["MPRICE"].ToString(), null, null
                        );
                    list.Add(mat);
                }
            }
            else
            {
                Console.WriteLine("자재 정보가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<Material> getMaterialVo()
        {
            string sql = "select m.mcode as 코드,m.mname as 제품명, " +
                "m.mprice as 가격, i.iquantity as 입고수량, " +
                "sum(i.iquantity) over(partition by m.mcode order by i.time) 재고수량, " +
                "i.time as 자재출입고시간 from import i, warehouse w, material m " +
                "where i.wno = w.wno and w.wno = m.wno";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Material> list = new List<Material>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Material mat = new Material
                        (
                        rd["코드"].ToString(),
                        rd["제품명"].ToString(),
                        rd["가격"].ToString(),
                        rd["입고수량"].ToString(),
                        rd["재고수량"].ToString(),
                        rd["자재출입고시간"].ToString()
                        );
                    list.Add(mat);
                }
            }
            else
            {
                Console.WriteLine("자재 정보가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public void showDB()
        {
            string sql = "select * from(select * from line_env_data_t order by time desc) where rownum<=5";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            //int count = 1;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    /*Console.WriteLine("번호: " + count++);
                    Console.WriteLine("시간: " + rd["time"]);
                    Console.WriteLine("1라인 온도: " + rd["temp1"]);
                    Console.WriteLine("1라인 습도: " + rd["humi1"]);
                    Console.WriteLine("1라인 미세먼지: " + rd["dust1"]);
                    Console.WriteLine("==============================");*/
                }
            }
            else
            {
                Console.WriteLine("센서 데이터가 존재하지 않습니다.");
            }
            rd.Close();
        }

        public List<LineProduce> getLineProduceVo()
        {
            string sql = "select * from line_manag_data_t";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<LineProduce> list = new List<LineProduce>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    LineProduce lineProduce = new LineProduce
                        (
                        rd["TIME"].ToString(),
                        rd["FINISHED"].ToString(),
                        rd["DEFECTIVE"].ToString()
                        );
                    list.Add(lineProduce);
                }
            }
            else
            {
                Console.WriteLine("자재 정보가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

    }
}
