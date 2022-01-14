using iotApp1005.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iotApp1005.DAO
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
        public void insertDB(LineEnvData env)
        {
            try
            {
                string sql = string.Format("insert into line_env_data_t1 values (" +
                    "'{0}', '{1}', '{2}', '{3}', '{4}')",
                    env.Time, env.Temp1, env.Humi1, env.Temp2, env.Humi2);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("센서 데이터 추가 오류: " + e.Message);
            }
        }

        public void showDB()
        {
            string sql = "select * from(select * from line_env_data_t1 order by time desc) where rownum<=5";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 1;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Console.WriteLine("번호: " + count++);
                    Console.WriteLine("시간: " + rd["TIME"]);
                    Console.WriteLine("1라인 온도: " + rd["TEMP1"]);
                    Console.WriteLine("1라인 습도: " + rd["HUMI1"]);
                    Console.WriteLine("2라인 온도: " + rd["TEMP2"]);
                    Console.WriteLine("2라인 습도: " + rd["HUMI2"]);
                    Console.WriteLine("==============================");
                }
            }
            else
            {
                Console.WriteLine("센서 데이터가 존재하지 않습니다.");
            }
            rd.Close();
        }
    }
}
