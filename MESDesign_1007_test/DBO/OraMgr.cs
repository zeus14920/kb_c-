using MESDesign_code.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESDesign_code.DBO
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
                Console.WriteLine("제조 데이터 추가 오류: " + e.Message);
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
                    "into import values(IMPORT_SEQ.nextval, 0,WAREHOUSE_SEQ.nextval,TO_char(sysdate,'YYYY-MM-DD HH24:MI:SS')) " +
                    "into shipping values(SHIPPING_SEQ.nextval, 0, warehouse_seq.nextval, TO_char(sysdate, 'YYYY-MM-DD HH24:MI:SS')) " +
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

        public void updateAddQuantityDB(Material mat, MaterialAddSub matAddSub)
        {
            try
            {
                string sql = string.Format("UPDATE warehouse set inventory=inventory+{0} " +
                    "where wno=(SELECT w.wno from warehouse w, material m where w.wno=m.wno and m.mcode='{1}')",
                    matAddSub.Invertory, mat.Code);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string sql2 = string.Format("INSERT into import " +
                    "values (IMPORT_SEQ.nextval, {0}, " +
                    "(SELECT w.wno from warehouse w, material m where w.wno=m.wno and m.mcode='{1}'), " +
                    "TO_char(sysdate,'YYYY-MM-DD HH24:MI:SS'))",
                    matAddSub.Receiving, mat.Code);
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public void updateSubQuantityDB(Material mat, MaterialAddSub matAddSub)
        {
            try
            {
                string sql = string.Format("UPDATE warehouse set inventory=inventory+{0} " +
                    "where wno=(SELECT w.wno from warehouse w, material m where w.wno=m.wno and m.mcode='{1}')",
                    matAddSub.Invertory, mat.Code);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string sql2 = string.Format("INSERT into SHIPPING " +
                    "values (SHIPPING_SEQ.nextval, {0}, " +
                    "(SELECT w.wno from warehouse w, material m where w.wno = m.wno and m.mcode = '{1}'), " +
                    "TO_char(sysdate, 'YYYY-MM-DD HH24:MI:SS'))",
                    matAddSub.Shipping, mat.Code);
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
                        rd["MPRICE"].ToString()
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

        public void getMaterialVo(out List<Material> list, out List<MaterialAddSub> addSubList)
        {
            string sql = "select m.mcode as 코드,m.mname as 제품명, m.mprice as 가격,i.iquantity as 입고수량, s.snum as 출고수량, " +
                "case when i.time = s.time then i.time " +
                "when i.iquantity > 0 and s.snum = 0 then i.time " +
                "when s.snum > 0 and i.iquantity = 0 then s.time " +
                "ELSE null " +
                "end as 입출고시간 " +
                "from warehouse w, import i, material m, shipping s " +
                "where w.wno = i.wno and w.wno = m.wno and w.wno = s.wno and not(i.iquantity != 0 and s.snum != 0) order by 입출고시간";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            list = new List<Material>();
            addSubList = new List<MaterialAddSub>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Material mat = new Material
                        (rd["코드"].ToString(), rd["제품명"].ToString(), rd["가격"].ToString());
                    list.Add(mat);
                    MaterialAddSub matAddSub = new MaterialAddSub
                        (rd["입고수량"].ToString(), rd["출고수량"].ToString(), null, rd["입출고시간"].ToString());
                    addSubList.Add(matAddSub);
                }
            }
            else
            {
                Console.WriteLine("자재 정보가 존재하지 않습니다.");
            }
            rd.Close();
        }

        public void showDB()
        {
            string sql = "select * from(select * from line_env_data_t order by time desc) where rownum<=5";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            if (!rd.HasRows)
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
