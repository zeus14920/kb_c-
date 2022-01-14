using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oracleTest0820_my1.DAO
{
    class OraMgr
    {
        Random r = new Random();
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

        // 테이블 생성
        public void createTable()
        {
            try
            {
                string sql = "CREATE TABLE CUS_T (" +
                    "ID NUMBER NOT NULL," +
                    "NAME VARCHAR(20) NOT NULL," +
                    "AGE NUMBER NOT NULL," +
                    "TEL CHAR(11) NOT NULL," +
                    "ADDR VARCHAR(80) NOT NULL," +
                    "GENDER CHAR(1) NOT NULL," +
                    "CONSTRAINT PK_CUS_ID PRIMARY KEY(ID))";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                string seq = "CREATE SEQUENCE SEQ_ID " +
                    "INCREMENT BY 1 START WITH 1000";
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();
                MessageBox.Show("테이블 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                MessageBox.Show("테이블 시퀀스 생성 오류: " + e.Message);
            }
        }

        // 테이블 삭제
        public void dropTable()
        {
            try
            {
                string sql = "DROP TABLE CUS_T";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                string seq = "DROP SEQUENCE SEQ_ID";
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();
                MessageBox.Show("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {
                MessageBox.Show("테이블, 시퀀스 삭제 오류: " + e.Message);
            }
        }

        // 데이터 추가
        public bool addRandomDB()
        {
            try
            {
                string[] name = {"홍길동","이순신","유관순","김구","감강찬",
                    "심사임당", "전우치", "세종대왕" };
                int[] age = { 10, 20, 30, 40, 50, 60 };
                string[] addr = {"대구광역시","부산광역시","대전광역시","광주광역시",
                    "서울특별시","제주도" };
                string[] tel = { "01012341234", "01056785678", "01043214321",
                    "01087658765","01012345678","01087654321"};
                string[] gender = { "M", "F" };
                string sql = string.Format("insert into CUS_T values (" +
                    "sequ_id.nextval, '{0}', {1}, '{2}', '{3}', '{4}')",
                    name[r.Next(8)], age[r.Next(6)], tel[r.Next(6)], addr[r.Next(6)], gender[r.Next(2)]);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show("데이터 추가 에러: " + e.Message);
                return false;
            }
            return true;
        }

        public void allDateDB()
        {
            string sql = string.Format("SELECT * FROM CUS_T");
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            MessageBox.Show("모든 데이터 가져왔습니다.");
            Console.WriteLine(sql);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Console.WriteLine("ID: " + rd["id"]);
                    Console.WriteLine("이름: " + rd["name"]);
                    Console.WriteLine("나이: " + rd["age"]);
                    Console.WriteLine("전화번호: " + rd["tel"]);
                    Console.WriteLine("주소: " + rd["addr"]);
                    Console.WriteLine("성별: " + rd["gender"]);
                    Console.WriteLine("==============================");
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
        }


    }
}
