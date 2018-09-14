/*Author:   Nabil Assadi - 2010*/

using System;
using System.Web;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace IdealResidencia
{
    [Serializable]
    public class User
    {
        public int ID { get; set; }
        public string loginID { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int roleIndex { get; set; }
    }


    public class AdminUserModel
    {
        #region Admin Users Management
        public static bool ValidateInputs(ref BulletedList bl_errors,
    ref User newUser,
    ref TextBox tb_userName,
    ref TextBox tb_name,
    ref TextBox tb_email,
    ref TextBox tb_password,
    ref TextBox tb_confpassword,
    ref RadioButtonList rbl_role, bool checkUsername)
        {
            bl_errors = new BulletedList();
            bool result = true;

            newUser.loginID = HttpContext.Current.Server.HtmlEncode(tb_userName.Text.Trim());
            newUser.name = HttpContext.Current.Server.HtmlEncode(tb_name.Text.Trim());
            newUser.email = HttpContext.Current.Server.HtmlEncode(tb_email.Text.Trim());
            newUser.role = HttpContext.Current.Server.HtmlEncode(rbl_role.SelectedValue.Trim());
            string confPass = HttpContext.Current.Server.HtmlEncode(tb_confpassword.Text.Trim());
            newUser.password = HttpContext.Current.Server.HtmlEncode(tb_password.Text.Trim());

            if (String.IsNullOrEmpty(newUser.loginID))
            {
                bl_errors.Items.Add(new ListItem(AllConstStrs.LoginID_Empty));
                result = false;
            }

            if (!String.IsNullOrEmpty(newUser.password))
            {
                //if (String.IsNullOrEmpty(newUser.password))
                //{
                //    bl_errors.Items.Add(new ListItem(AllConstStrs.Pass_Empthy));
                //    result = false;
                //}
                if (!Regex.IsMatch(newUser.password, AllConstStrs.regx_Password2))
                {
                    bl_errors.Items.Add(new ListItem(AllConstStrs.Pass2_Hint));
                    result = false;
                }
                //if (newUser.password.Contains(newUser.loginID.ToLower()))
                //{
                //    bl_errors.Items.Add(new ListItem(AllConstStrs.Pass_Has_Username));
                //    result = false;
                //}
                if (newUser.password != confPass)
                {
                    bl_errors.Items.Add(new ListItem(AllConstStrs.Password_Conf_Mismatch));
                    result = false;
                }
            }
            if (String.IsNullOrEmpty(newUser.role))
            {
                bl_errors.Items.Add(new ListItem(AllConstStrs.Role_Empthy));
                result = false;
            }

            //return upto here
            if (result == false) return result;

            if (checkUsername)
            {
                if (AdminUserModel.getUser(newUser.loginID).Tables[0].Rows.Count > 0)
                {
                    bl_errors.Items.Add(new ListItem(AllConstStrs.Dup_Username));
                    result = false;
                }
            }
            //if (!Regex.IsMatch(newUser.name, AllConstStrs.regx_Name))
            //{
            //    bl_errors.Items.Add(new ListItem(AllConstStrs.Name_Hint));
            //    result = false;
            //}
            return result;
        }

        public static DataSet getAllUsers()
        {
            //string command = "getUsers";
            //string sqlFile = HttpContext.Current.Server.MapPath(".") + "\\" + (string)ConfigurationManager.AppSettings["DASAdmin"];
            string sql = AllSqls.getUsers;
            String connString = "IdealRConStr";
            DataSet ds = null;
            IDictionary sqlParamMap = new Hashtable();
            ds = DBUtility.GetResultSets(sql, sqlParamMap, connString);
            return ds;
        }

        public static DataSet getArtUsers()
        {
            string sql = AllSqls.getArtUsers;
            String connString = "IdealRConStr";
            DataSet ds = null;
            IDictionary sqlParamMap = new Hashtable();
            ds = DBUtility.GetResultSets(sql, sqlParamMap, connString);
            return ds;
        }

        public static DataSet getUser(int userID)
        {
            string sql = AllSqls.getUserByID;
            String connString = "IdealRConStr";
            DataSet ds = null;
            IDictionary sqlParamMap = new Hashtable();
            ds = DBUtility.GetResultSets(sql, sqlParamMap, connString);
            return ds;
        }
        public static DataSet getUser(string loginID)
        {
            string sql = AllSqls.getUserByUsername;
            String connString = "IdealRConStr";
            DataSet ds = null;
            IDictionary sqlParamMap = new Hashtable();
            //@login_ID  
            sqlParamMap.Add("@login_ID", loginID);
            ds = DBUtility.GetResultSets(sql, sqlParamMap, connString);
            return ds;
        }
        public static int deleteUser(int OriginalID)
        {
            string sql = AllSqls.deleteUser;
            String connString = "IdealRConStr";
            IDictionary sqlParamMap = new Hashtable();
            //@Original_ID  
            sqlParamMap.Add("@Original_ID", OriginalID);
            return DBUtility.ModifyDatabase(sql, sqlParamMap, connString, "DeleteCommand");
        }
        public static int deleteUser(string loginID)
        {
            string sql = AllSqls.deleteByUsername;
            String connString = "IdealRConStr";
            IDictionary sqlParamMap = new Hashtable();
            //@login_ID  
            sqlParamMap.Add("@login_ID", loginID);
            return DBUtility.ModifyDatabase(sql, sqlParamMap, connString, "DeleteCommand");
        }
        public static int updateUser(string username, string name, string loginID, string password, string email, string roleID)
        {
            string sql = AllSqls.updateUserByUserName;
            String connString = "IdealRConStr";
            IDictionary sqlParamMap = new Hashtable();
            //@name, @login_ID, @password, @role_ID, @Original_ID
            sqlParamMap.Add("@name", name);
            sqlParamMap.Add("@login_ID", loginID);
            sqlParamMap.Add("@password", password);
            sqlParamMap.Add("@role_ID", roleID);
            sqlParamMap.Add("@email", email);
            sqlParamMap.Add("@Original_LoginID", username);
            return DBUtility.ModifyDatabase(sql, sqlParamMap, connString, "UpdateCommand");
        }
        public static int updateUser(int id, string name, string loginID, string password, string email, string roleID)
        {
            string sql = AllSqls.updateUserByID;
            String connString = "IdealRConStr";
            IDictionary sqlParamMap = new Hashtable();
            //@name, @login_ID, @password, @role_ID, @Original_ID
            sqlParamMap.Add("@name", name);
            sqlParamMap.Add("@login_ID", loginID);
            sqlParamMap.Add("@password", password);
            sqlParamMap.Add("@role_ID", roleID);
            sqlParamMap.Add("@email", email);
            sqlParamMap.Add("@Original_ID", id);
            return DBUtility.ModifyDatabase(sql, sqlParamMap, connString, "UpdateCommand");
        }
        public static int insertUser(string name, string loginID, string password, string email, string roleID)
        {
            //string command = "insert";
            //string sqlFile = HttpContext.Current.Server.MapPath(".") + "\\" + (string)ConfigurationManager.AppSettings["DASAdmin"];
            string sql = AllSqls.insertUser;
            String connString = "IdealRConStr";
            IDictionary sqlParamMap = new Hashtable();
            //@name, @login_ID, @password, @role_ID
            sqlParamMap.Add("@name", name);
            sqlParamMap.Add("@login_ID", loginID);
            sqlParamMap.Add("@password", password);
            sqlParamMap.Add("@email", email);
            sqlParamMap.Add("@role_ID", roleID);
            return DBUtility.ModifyDatabase(sql, sqlParamMap, connString, "InsertCommand");
        }
        public static int setStaff(int uID, string isStaff)
        {
            IDictionary sqlParamMap = new Hashtable();
            sqlParamMap.Add("@ID", uID);
            sqlParamMap.Add("@IsCustStaff", isStaff);
            return DBUtility.ModifyDatabase(AllSqls.setCustomerStaff, sqlParamMap, "IdealRConStr", "UpdateCommand");
        }
        #endregion
    }
}
