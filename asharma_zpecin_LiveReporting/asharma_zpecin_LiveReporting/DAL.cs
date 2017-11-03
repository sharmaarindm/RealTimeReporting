/*
* FILE : DAL.cs
* PROJECT : Bussiness intelligence - Assignment #2
* PROGRAMMER : Arindm Sharma & Zivojin Pecin
* DESCRIPTION :
* The methods in application , so called data access layer. The methods here are called from the form in order to execute specific tasks.
* Not only that, but this layer holds the connection information of the application.
*/


using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asharma_zpecin_LiveReporting
{
    class DAL
    {
        DataTable binTable = new DataTable();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        SqlDataAdapter adapt = new SqlDataAdapter();
        public DAL()
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DALConnectString"].ConnectionString;
        }
        /*
        * FUNCTION : getConnection
        *
        * DESCRIPTION : getter
        * RETURNS : SqlConnection
        */
        public SqlConnection getConnection()
        {
            return conn;
        }
        /*
        * FUNCTION : getCommand
        *
        * DESCRIPTION : getter
        * RETURNS : SqlCommand
        */
        SqlCommand getCommand()
        {
            return cmd;
        }
        /*
        * FUNCTION : writeToProductionTable
        *
        * DESCRIPTION : inserts values into the main table
        * RETURNS : nothing
        */
        //WorkArea,a67f804e-3071-402a-abcf-c04898054ce9,Line0,MOLD,,10/1/2017 4:11:23 PM, 3
        public void writeToProductionTable(string WorkArea, string UID, string Line, string Status, string Reason,string dateTime, string ProductID)
        {
            //open connection and create a query, than run the query by running the reader.
            cmd.Connection = conn;
            cmd.CommandText = "Insert Into CurrentProduction(ProductID,WorkArea,Line,ProductStatus,ProductionDateTime,SerialNumber,Reason) values("+ProductID+",'"+WorkArea+"','"+Line+"','"+Status+"','"+dateTime+"','"+UID+"','"+Reason+"');";

            conn.Open();
            rdr = cmd.ExecuteReader();

            rdr.Close();
            conn.Close();
        }
        /*
        * FUNCTION : totalPartsMoldedDAL
        *
        * DESCRIPTION : inserts values into the main table
        * RETURNS : nothing
        */
        public void totalPartsMoldedDAL(int PartID)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            SqlCommand cmd2 = new SqlCommand("dbo.totalPartsMolded", conn);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();

            param = cmd2.Parameters.Add("@ProdID", SqlDbType.NVarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = PartID;

            SqlParameter retval = cmd2.Parameters.Add("@partCount", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;

            SqlDataReader reader = cmd2.ExecuteReader();
            string retunvalue = (string)cmd2.Parameters["@partCount"].Value.ToString();
            Form1.totalPartsModeled = Int32.Parse(retunvalue);

            reader.Close();
            conn.Close();

        }
        /*
        * FUNCTION : totalPartsSuccessfullyMoldedDAL
        *
        * DESCRIPTION : shows how many parts have been successfully molded
        * RETURNS : nothing
        */
        public void totalPartsSuccessfullyMoldedDAL(int PartID)
        {

            conn.Open();

            SqlCommand cmd2 = new SqlCommand("dbo.totalPartsSuccessfullyMolded", conn);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();

            param = cmd2.Parameters.Add("@ProdID", SqlDbType.NVarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = PartID;

            SqlParameter retval = cmd2.Parameters.Add("@totalPartsMolded", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;

            SqlDataReader reader = cmd2.ExecuteReader();
            string retunvalue = (string)cmd2.Parameters["@totalPartsMolded"].Value.ToString();
            Form1.totalPartsSuccessfullyModeled = Int32.Parse(retunvalue);

            reader.Close();
            conn.Close();

        }
        /*
        * FUNCTION : yieldAtMoldDAL
        *
        * DESCRIPTION : calculates yieldatmold
        * RETURNS : nothing
        */
        public void yieldAtMoldDAL(int PartID)
        {
            //y1/y2
            //get vals of both of the counts and calculate result yieldatmold
            double a= yieldFetch("yieldAtMoldY1", PartID);
            double b = yieldFetch("yieldAtMoldY1", PartID);
            double result = a / b;
            Form1.YieldAtMold = result;
        }
        /*
        * FUNCTION : yieldAtPaintDAL
        *
        * DESCRIPTION : get vals of both of the counts and calculate result yieldAtPaintDAL
        * RETURNS : nothing
        */
        public void yieldAtPaintDAL(int PartID)
        {
            //y1/y2
            double a = yieldFetch("yieldAtPaintY1",PartID);
            double b = yieldFetch("yieldAtPaintY2", PartID);
            double result = b / a;
            Form1.YieldAtPaint = result;
        }

        /*
        * FUNCTION : yieldAtAssebmlyDAL
        *
        * DESCRIPTION : calculates the yield of assembled products
        * RETURNS : nothing
        */
        public void yieldAtAssebmlyDAL(int PartID)
        {
            //y1/y2
            double a = yieldFetch("yieldAtAssebmlyY1",PartID);
            double b = yieldFetch("yieldAtAssebmlyY2", PartID);
            double result = a / b;
            Form1.YieldAtAssembly = result;
        }
        /*
        * FUNCTION : totalYieldDAL
        *
        * DESCRIPTION : get vals of both of the counts and calculate result 
        * RETURNS : nothing
        */
        public void totalYieldDAL(int PartID)
        {
            //y1/y2
            double a = yieldFetch("partsMoldedY1", PartID);
            double b = yieldFetch("partsMoldedY2",PartID);
            double result = b / a;
            Form1.totalYield = result;
        }
        /*
        * FUNCTION : yieldFetch
        *
        * DESCRIPTION : calculates the yield 
        * RETURNS : nothing
        */
        double yieldFetch(string procedure,int PartID)
        {
            int retVal;
            conn.Open();

            SqlCommand cmd2 = new SqlCommand("dbo."+procedure, conn);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();

            param = cmd2.Parameters.Add("@ProdID", SqlDbType.NVarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = PartID;

            SqlParameter retval = cmd2.Parameters.Add("@retVal", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;

            SqlDataReader reader = cmd2.ExecuteReader();
            string retunvalue = (string)cmd2.Parameters["@retVal"].Value.ToString();
            retVal = Int32.Parse(retunvalue);

            reader.Close();
            conn.Close();
            return retVal;
        }
        /*
        * FUNCTION : partsSuccessfullyPaintedDAL
        *
        * DESCRIPTION : calculates how many parts have been successfully painted
        * RETURNS : nothing
        */
        public void partsSuccessfullyPaintedDAL(int PartID)
        {

            conn.Open();

            SqlCommand cmd2 = new SqlCommand("dbo.partsSuccessfullyPainted", conn);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();

            param = cmd2.Parameters.Add("@ProdID", SqlDbType.NVarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = PartID;

            SqlParameter retval = cmd2.Parameters.Add("@partsSuccessfullyPainted", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;

            SqlDataReader reader = cmd2.ExecuteReader();
            string retunvalue = (string)cmd2.Parameters["@partsSuccessfullyPainted"].Value.ToString();
            Form1.totalPartsSuccessfullyPainted = Int32.Parse(retunvalue);
            reader.Close();
            conn.Close();

        }
        /*
        * FUNCTION : partsSuccessfullyAssembledDAL
        *
        * DESCRIPTION : calculates how many parts have been successfully assembled
        * RETURNS : nothing
        */
        public void partsSuccessfullyAssembledDAL(int PartID)
        {

            conn.Open();

            SqlCommand cmd2 = new SqlCommand("dbo.partsSuccessfullyAssembled", conn);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();

            param = cmd2.Parameters.Add("@ProdID", SqlDbType.NVarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = PartID;

            SqlParameter retval = cmd2.Parameters.Add("@partsSuccessfullyAssemlbd", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;

            SqlDataReader reader = cmd2.ExecuteReader();
            string retunvalue = (string)cmd2.Parameters["@partsSuccessfullyAssemlbd"].Value.ToString();
            Form1.totalPartsSuccessfullyAssembeled = Int32.Parse(retunvalue);
            reader.Close();
            conn.Close();

        }
        /*
        * FUNCTION : partsPackagedDAL
        *
        * DESCRIPTION : get vals of parts packaged
        * RETURNS : nothing
        */
        public void partsPackagedDAL(int PartID)
        {

            conn.Open();

            SqlCommand cmd2 = new SqlCommand("dbo.partsPackaged", conn);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();

            param = cmd2.Parameters.Add("@ProdID", SqlDbType.NVarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = PartID;

            SqlParameter retval = cmd2.Parameters.Add("@partsSuccessfullyPackaged", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;

            SqlDataReader reader = cmd2.ExecuteReader();
            string retunvalue = (string)cmd2.Parameters["@partsSuccessfullyPackaged"].Value.ToString();
            Form1.totalPartsPackaged = Int32.Parse(retunvalue);
            reader.Close();
            conn.Close();

        }
        /*
        * FUNCTION : howMany
        *
        * DESCRIPTION : get vals of parts at certain ID
        * PARAMETERS :string procName, int PartID
        * RETURNS : int 
        */
        public int howMany(string procName, int PartID)
        {

            conn.Open();

            SqlCommand cmd2 = new SqlCommand("dbo."+procName, conn);
            cmd2.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();

            param = cmd2.Parameters.Add("@ProdID", SqlDbType.NVarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = PartID;

            SqlParameter retval = cmd2.Parameters.Add("@retVal", SqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;

            SqlDataReader reader = cmd2.ExecuteReader();
            string retunvalue = (string)cmd2.Parameters["@retVal"].Value.ToString();
            
            reader.Close();
            conn.Close();
            int rets;
            bool ret = Int32.TryParse(retunvalue, out rets);
            return rets;
        }
    }
}
