
using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace IdealResidencia
{
    public class DBUtility
    {
        #region Database Interaction

        /// <summary>
        /// private helper method that connects to database, runs given Select SQL query and returns the DataSet of results
        /// </summary>
        public static DataSet GetResultSets(String sql, IDictionary sqlParamMap, String connString)
        {
            DataSet ds = null;
            IDbDataAdapter dbadapter = null;
            IDbConnection dbcon = null;
            IDbCommand dbcmd = null;
            //reader = null;
            try
            {
                dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings[connString].ToString());
                dbcon.Open();
                dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = sql;
                dbadapter = new SqlDataAdapter();
                dbadapter.SelectCommand = dbcmd;
                foreach (DictionaryEntry de in sqlParamMap)
                {
                    dbadapter.SelectCommand.Parameters.Add(new SqlParameter(de.Key.ToString(), de.Value));
                }
                ds = new DataSet();
                dbadapter.Fill(ds);
                return ds;
            }
            catch (Exception exc)
            {
                CreateLog("getResultSets", sqlParamMap, ref connString, ref sql, ref exc);
                return null;
            }
            finally
            {
                if (ds != null)
                    ds = null;
                if (dbcmd != null) dbcmd.Dispose();
                dbcmd = null;
                if (dbcon != null) dbcon.Close();
                dbcon = null;
            }
        }

        private static void CreateLog(string funcName, IDictionary sqlParamMap, ref String connString, ref String query, ref Exception exc)
        {
            var str = new StringBuilder("DB-Err, Func Name: " + funcName + " \r\n");
            str.AppendLine("Connection Str:" + connString);
            str.AppendLine("Query:" + query);
            if (sqlParamMap != null)
            {
                str.AppendLine("Key - Value <----- Parameters");
                foreach (DictionaryEntry de in sqlParamMap)
                {
                    str.AppendLine((de.Key == null ? string.Empty : de.Key.ToString()) + "-" + (de.Value == null ? string.Empty : de.Value.ToString()));
                }
            }
            str.AppendLine("--------------------------------------");
            str.AppendLine("Exception Msg: " + exc.Message);
            str.AppendLine("Exception Source: " + exc.Source);
            //str.AppendLine("Exception Stack Trace: " + exc.StackTrace);
            //ErrLogger.Log(str.ToString());
            //WebUtility.ElmahLog(ref exc, str.ToString());

        }

        /// <summary>
        /// private database access helper method that inserts, updates and deletes data to CMS tables
        /// </summary>
        public static int ModifyDatabase(String sql, IDictionary sqlParamMap, String connString, String command)
        {
            int rowCount = -1;
            IDbDataAdapter dbadapter = null;
            IDbConnection dbcon = null;
            IDbCommand dbcmd = null;

            try
            {
                dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings[connString].ToString());
                dbcon.Open();
                dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = sql;
                dbadapter = new SqlDataAdapter();
                if (command.Equals("InsertCommand"))
                {
                    dbadapter.InsertCommand = dbcmd;
                    foreach (DictionaryEntry de in sqlParamMap)
                    {
                        var param = new SqlParameter();
                        if (de.Value == null)
                        {
                            param.IsNullable = true;
                            param.Value = DBNull.Value;
                        }
                        else
                            param.Value = de.Value;
                        param.ParameterName = de.Key.ToString();
                        dbadapter.InsertCommand.Parameters.Add(param);
                    }
                    rowCount = Convert.ToInt32(dbcmd.ExecuteScalar());
                }
                else if (command.Equals("UpdateCommand"))
                {
                    dbadapter.UpdateCommand = dbcmd;
                    foreach (DictionaryEntry de in sqlParamMap)
                    {
                        var param = new SqlParameter();
                        if (de.Value == null)
                        {
                            param.IsNullable = true;
                            param.Value = DBNull.Value;
                        }
                        else
                            param.Value = de.Value;
                        param.ParameterName = de.Key.ToString();
                        dbadapter.UpdateCommand.Parameters.Add(param);
                    }
                    rowCount = dbcmd.ExecuteNonQuery();
                }
                else if (command.Equals("DeleteCommand"))
                {
                    dbadapter.DeleteCommand = dbcmd;
                    foreach (DictionaryEntry de in sqlParamMap)
                    {
                        var param = new SqlParameter();
                        if (de.Value == null)
                        {
                            param.IsNullable = true;
                            param.Value = DBNull.Value;
                        }
                        else
                            param.Value = de.Value;
                        param.ParameterName = de.Key.ToString();
                        dbadapter.DeleteCommand.Parameters.Add(param);
                    }
                    rowCount = dbcmd.ExecuteNonQuery();
                }
                else if (command.Equals("SP"))// stored procedure
                {
                    dbadapter.DeleteCommand = dbcmd;
                    foreach (DictionaryEntry de in sqlParamMap)
                    {
                        var param = new SqlParameter();
                        if (de.Value == null)
                        {
                            param.IsNullable = true;
                            param.Value = DBNull.Value;
                        }
                        else
                            param.Value = de.Value;
                        param.ParameterName = de.Key.ToString();
                        dbadapter.DeleteCommand.Parameters.Add(param);
                    }
                    rowCount = dbcmd.ExecuteNonQuery();
                }

                //  Console.WriteLine("rowdeleted" + rowCount);
                return rowCount;
            }
            catch (Exception exc)
            {
                CreateLog("ModifyDatabase", sqlParamMap, ref connString, ref sql, ref exc);
                return -1;
            }
            finally
            {
                if (dbcmd != null) dbcmd.Dispose();
                dbcmd = null;
                if (dbcon != null) dbcon.Close();
                dbcon = null;
            }
        }

        /// <summary>
        /// private database access helper method that inserts, updates and deletes data to CMS tables
        /// </summary>
        public static void BatchModifyDatabase(List<string> sqls, string connString, string command)
        {
            int rowCount = -1;
            IDbDataAdapter dbadapter = null;
            IDbConnection dbcon = null;
            IDbCommand dbcmd = null;

            try
            {
                dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings[connString].ToString());
                dbcon.Open();
                dbcmd = dbcon.CreateCommand();

                for (int i = 0; i < sqls.Count; i++)
                {

                    dbcmd.CommandText = sqls[i];
                    dbadapter = new SqlDataAdapter();
                    if (command.Equals("InsertCommand"))
                    {
                        dbadapter.InsertCommand = dbcmd;
                        rowCount = Convert.ToInt32(dbcmd.ExecuteScalar());
                    }
                    else if (command.Equals("UpdateCommand"))
                    {
                        dbadapter.UpdateCommand = dbcmd;
                        rowCount = dbcmd.ExecuteNonQuery();
                    }
                    else if (command.Equals("DeleteCommand"))
                    {
                        dbadapter.DeleteCommand = dbcmd;
                        rowCount = dbcmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exc)
            {
                var str = new StringBuilder("DB-Err, Func Name: BatchModifyDatabase \r\n");
                str.AppendLine("Connection Str:" + connString);
                if (sqls != null)
                {
                    str.AppendLine("Total sqls:" + sqls.Count);
                    for (int i = 0; i < sqls.Count; i++)
                    {
                        str.AppendLine(sqls[i]);
                    }
                }
                //WebUtility.ElmahLog(ref exc, str.ToString());
            }
            finally
            {
                if (dbcmd != null) dbcmd.Dispose();
                dbcmd = null;
                if (dbcon != null) dbcon.Close();
                dbcon = null;
            }
        }

        public static DataSet ExecuteStoredProcedure(String spName, SqlParameter[] sqlParams, String connString)
        {
            SqlDataAdapter dbadapter = null;
            SqlConnection dbcon = null;
            SqlCommand dbcmd = null;
            DataSet result = null;

            try
            {
                dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings[connString].ToString());
                dbcon.Open();
                dbcmd = new SqlCommand(spName, dbcon);
                dbcmd.CommandType = CommandType.StoredProcedure;


                if (sqlParams != null)
                    for (int i = 0; i < sqlParams.Length; i++)
                    {
                        dbcmd.Parameters.Add(sqlParams[i]);
                    }

                dbadapter = new SqlDataAdapter(dbcmd);
                result = new DataSet();
                dbadapter.Fill(result);

                return result;
            }
            catch (Exception exc)
            {
                CreateLog("ExecuteStoredProcedure", null, ref connString, ref spName, ref exc);
                return null;
            }
            finally
            {
                if (result != null)
                    result = null;
                if (dbcmd != null) dbcmd.Dispose();
                dbcmd = null;
                if (dbcon != null) dbcon.Close();
                dbcon = null;
            }
        }

        /// <summary>
        /// Does not return dataset as result, or stored procedures that get parameters as output variables 
        /// </summary>
        public static void ExecuteScalarStoredProcedure(String spName, SqlParameter[] sqlParams, String connString)
        {
            SqlConnection dbcon = null;
            SqlCommand dbcmd = null;

            try
            {
                dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings[connString].ToString());
                dbcon.Open();
                dbcmd = new SqlCommand(spName, dbcon);
                dbcmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < sqlParams.Length; i++)
                {
                    dbcmd.Parameters.Add(sqlParams[i]);
                }
                dbcmd.ExecuteScalar();
            }
            catch (Exception exc)
            {
                CreateLog("ExecuteStoredProcedure", null, ref connString, ref spName, ref exc);
                return;
            }
            finally
            {
                if (dbcmd != null) dbcmd.Dispose();
                dbcmd = null;
                if (dbcon != null) dbcon.Close();
                dbcon = null;
            }
        }

        /// <summary>
        /// Does not return dataset as result, or stored procedures 
        /// </summary>
        public static int ExecuteNonQueryStoredProcedure(String spName, SqlParameter[] sqlParams, String connString)
        {
            SqlConnection dbcon = null;
            SqlCommand dbcmd = null;
            int rows = -1;

            try
            {
                dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings[connString].ToString());
                dbcon.Open();
                dbcmd = new SqlCommand(spName, dbcon);
                dbcmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < sqlParams.Length; i++)
                {
                    dbcmd.Parameters.Add(sqlParams[i]);
                }
                rows = dbcmd.ExecuteNonQuery();
                return rows;

            }
            catch (Exception exc)
            {
                CreateLog("ExecuteStoredProcedureNonquery", null, ref connString, ref spName, ref exc);
                return -1;
                
            }
            finally
            {

                if (dbcmd != null) dbcmd.Dispose();
                dbcmd = null;
                if (dbcon != null) dbcon.Close();
                dbcon = null;
            }
        }


        #endregion
    }
}
