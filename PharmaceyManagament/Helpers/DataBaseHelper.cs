using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PharmaceyManagament.Helpers
{
    class DataBaseHelper:IDisposable
    {
        SqlConnection sqlConnection;
        public DataBaseHelper()
        {
            string path = Directory.GetCurrentDirectory() + @"\pharmacyA.mdf";
            string connection = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True", path);
            sqlConnection = new SqlConnection(connection);
            OpenConnection();
            
        }

        private void OpenConnection()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        private void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public DataTable GetUsers()
        {
            string command = "exec dbo.getUsres";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }
        public DataTable ValidatUser(int uID,string upassword)
        {
            string command =String.Format("exec dbo.ValidateUserPssword {0},N'{1}'",uID,upassword);
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        public int GetLastLogoID()
        {
            string command = "select max(log_id) from LoginInfo";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            int LastID = sqlDataReader.GetInt32(0);
            CloseConnection();
            return LastID;
        }



        public int AddLogoDate(int uID,string logndate)
            {
            string command = String.Format(" execute dbo.AddLoginInfo {0},N'{1}'",uID,logndate);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowaffected;

        }
        public int AddLogoutDate(long opID, string logndate)
        {
            string command = String.Format(" exec dbo.AddLogoutInfo {0},N'{1}'", opID, logndate);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowaffected;

        }

        public DataTable GetUersInfo()
        {
            string command = "exec dbo.GetUsersInfo ";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        public int AddUser(string name,string phone,string password,string adress,string sex,string uType)
        {
            string command = String.Format(" execute dbo.AddUser N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}'",name,phone,password,adress,sex,uType);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowaffected;

        }
        public int AddCompName(string name)
        {
            string command = String.Format(" exec dbo.AddCompanyNames N'{0}'", name);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowaffected;

        }
        public DataTable GetCompNames()
        {
            string command = "select * from companiesNames ";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        public DataTable GetSuppliers()
        {
            string command = "exec dbo.GetSuppliersName ";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }
        public DataTable GetDrugs()
        {
            string command = "exec dbo.GetDrugsName ";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        public int AddSupplier(string name, string phone, string adress)
        {
            string command = String.Format(" execute dbo.AddSuplier N'{0}',N'{1}',N'{2}'", name, phone, adress);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowaffected;

        }

        public int AddPurchasesBill(string d,double to,int sup)
        {
            string command = String.Format(" execute dbo.AddPurchaBill N'{0}',{1},{2}", d,Convert.ToDecimal(to.ToString()) , sup);

            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowaffected;
           
        }


        public int AddPurchasesDetals(long billId,string dname,string dtype,string dcompany,string expDate,int quantity,double purchPrice,double saleprice)
        {

            string command = String.Format(" execute dbo.AddPurchaDetails {0},N'{1}',N'{2}',N'{3}',N'{4}',{5},{6},{7}", billId, dname, dtype, dcompany, expDate, quantity, Convert.ToDecimal(purchPrice.ToString()), Convert.ToDecimal(saleprice.ToString()));

            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowaffected;

        }




        public int GetLastPurchabillID()
        {
            string command = "select max(bill_id) from PurchasesBill";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            int LastID = sqlDataReader.GetInt32(0);
            CloseConnection();
            return LastID;
        }
        public DataTable GetAllDrugsDetails()
        {
            string command = "exec dbo.GetStoreDetails";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        public DataTable Getcustomers()
        {
            string command = "exec dbo.GetCutomersDetails ";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        public int AddCustomer(string cname,string cphone,string cadress)
        {
            string command =String.Format("exec dbo.AddCustomer N'{0}',N'{1}',N'{2}'",cname,cphone,cadress);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            int LastID = sqlDataReader.GetInt32(0);
            CloseConnection();
            return LastID;
        }

        public int AddSaleBill(string bdate,decimal total,decimal reciption,int cusomer,string btype,int sId,decimal paidmoy)
        {
            string command = String.Format("exec dbo.AddSaleBill  N'{0}',{1},{2},{3},{4},N'{5}',{6}", bdate, sId, total, reciption, cusomer, btype, paidmoy);

            //string command = String.Format("insert into SalesBill(bill_Date,bill_saler,bill_total,bill_rceiption,customer,bill_type,payedMony)  values( N'{0}',{1},{2},{3},{4},N'{5}',{6})", bdate, sId, total, reciption, cusomer, btype,  paidmoy);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowaffected;
        }

        public long GetLastSalillID()
        {
            string command = "select max(bill_id) from SalesBill";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            long LastID = sqlDataReader.GetInt64(0);
            CloseConnection();
            return LastID;
        }

        //  (@billID bigint, @drugId bigint,
        ////         @DrugType nvarchar(max),@drugQuantity int ,@drugOnePrice decimal(10,2)
        public int AddSaleBillDetails(long bill_id,long drugId,string dtype,int quantity,decimal onePrice)
        {
            string command = String.Format("exec dbo.AddSaleBillDetails {0},{1},N'{2}',{3},{4}", bill_id,drugId,dtype,quantity,onePrice);

            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowaffected;
        }









        public DataTable GetSalesBills()
        {
            string command = "exec dbo.GetSaleBill ";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }
        public DataTable GetSalesBillDetails(long billid )
        {
            string command = String.Format("exec dbo.GetSaleBillDetails {0}",billid);
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        public DataTable GetPurchasesBills()
        {
            string command = "exec dbo.GetPurchabills ";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }
        public DataTable GetPurhasesDetailes(long billid)
        {
            string command = String.Format("exec dbo.GetPurchabillDetails {0}", billid);
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }


        public DataTable GetNotCahSalesBill()
        {
            string command = "exec dbo.GetNotCashSaleBill";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        public int AddNotCashMony(long bill_id, decimal onePrice)
        {
            string command = String.Format("exec dbo.PayDebt {0},{1}", bill_id, onePrice);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();
            return rowaffected;
        }

        public int UpdateDData(long d_id,string dname,string dtyp,string dcomp,int dqunt ,decimal onePrice,string ddate)
        {
            string command = String.Format("exec dbo.UpdateDrugData {0},N'{1}',N'{2}',N'{3}',{4},{5},N'{6}'", d_id,dname,dtyp,dcomp,dqunt,onePrice,ddate);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();
            return rowaffected;
        }


        public DataTable GetTotalOfSales()
        {
            string command = "exec dbo.GetAllSalesTotal";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }
        public DataTable GetTotalOfSalesToday(string sdate)
        {
            string command =string.Format( "exec dbo.GetAllSalesTotalFroToday N'{0}'",sdate);
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }
        public DataTable GetTotalOfSalesByUser(int uId)
        {
            string command =string.Format( "exec dbo. GetAllSalesByUser {0}",uId);
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }
        public DataTable GetTotalOfSalesByUserTody(int uid,string sdate)
        {
            string command = string.Format("exec dbo.GetAllSalesTotalByUserFroToday {0},N'{1}'",uid,sdate);
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        public DataTable GetSupliersDetails()
        {
            string command = "exec dbo.GetSuppliersDetails";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        public int AlterSupplierData(int sid,string sname,string sphone,string saddress)
        {
            string command = String.Format("exec dbo.ApdateSuplier {0},N'{1}',N'{2}',N'{3}'", sid,sname,sphone,saddress);

            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowaffected;
        }
        public int AddNote(int uid,string ndate,string ntext)
        {
            string command = String.Format(" execute dbo.AddNotivication {0},N'{1}',N'{2}'",uid,ndate,ntext);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            int rowaffected = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowaffected;

        }
        public DataTable GetNotes()
        {
            string command = "exec dbo.getNotes";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }
        public DataTable GetLogoInfo()
        {
            string command = "exec dbo.UsersSessions";
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        /////////////////////////////////////////////////////////////////////
        #region   /////دالة لعمل نسخة احتياطية لقاعدة البيانات

        public bool BackUpDB(FolderBrowserDialog folder)
        {
            try
            {

                string NameDb = sqlConnection.Database;
                string NameDbBuckUp = "DB_RecordDebt" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm");
                var fullPath = folder.SelectedPath.ToString() + "\\" + NameDbBuckUp + ".bak";
                string QueryToBackUp = "BACKUP DATABASE [" + NameDb + "] TO DISK ='" + fullPath + "' WITH NOFORMAT, NOINIT, NAME = N'DB_RecordDept', SKIP, NOREWIND, NOUNLOAD, STATS =10";
               OpenConnection();
               SqlCommand command = new SqlCommand(QueryToBackUp,sqlConnection);
                int d = command.ExecuteNonQuery();
               CloseConnection();
                //  Microsoft.SqlServer.Server
                return true;
            }
            catch (Exception)
            {
                CloseConnection();
                MessageBox.Show(" فشلت عملية النسخ الاحتياطي تأكد من تشغيل البرنامج كمسؤول", "فـشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        #endregion
        //////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////
        #region    /////دالة لاستعادة النسخة الاحتياطية لقاعدة البيانات
        public bool RestoreDB(OpenFileDialog folder)
        {
            try
            {

                string NameDb =sqlConnection.Database;
                string pathDB = folder.FileName;
                string Query = String.Format(@"ALTER DATABASE [" + NameDb + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                OpenConnection();
                using (SqlCommand command = new SqlCommand(Query,sqlConnection))
                {
                    command.ExecuteNonQuery();
                }
                Query = String.Format(@"USE MASTER RESTORE DATABASE [" + NameDb + "] FROM DISK ='" + pathDB + "' WITH REPLACE;");
                using (SqlCommand command = new SqlCommand(Query, sqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                Query = String.Format(@"ALTER DATABASE [" + NameDb + "] SET MULTI_USER");
                using (SqlCommand command = new SqlCommand(Query, sqlConnection))
                {
                    command.ExecuteNonQuery();
                }
                CloseConnection();
                //  Microsoft.SqlServer.Server
                return true;
            }
            catch (Exception)
            {
                CloseConnection();
                MessageBox.Show(" فشلت عملية استعادة النسخ الاحتياطي تأكد من تشغيل البرنامج كمسؤول", "فـشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        #endregion
        //////////////////////////////////////////////////////////////////////



        #region
        /// <summary>
        /// refresh db
        /// </summary>
        public int ClearDB()
        {
            try {
                string command = " execute dbo.refreshDB";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                OpenConnection();
                int rowaffected = sqlCommand.ExecuteNonQuery();
                CloseConnection();

                return rowaffected+1;

            }
            catch
            {
                return 0;
            }

        }
        #endregion

        public DataTable getPassWord(int uid)
        {
            string command =string.Format("select user_password from Users Where user_id={0}",uid);
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            OpenConnection();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            CloseConnection();
            return dataTable;
        }

        public void Dispose()
        {
            
        }
    }
}
