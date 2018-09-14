using System;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace IdealResidencia
{
    public partial class Login : System.Web.UI.Page
    {
        private User _currentUser = new User();
        private const string _returnURL = "RETURNURL";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Request.QueryString[_returnURL] != null)
                {
                    ViewState.Add(_returnURL, Request.QueryString[_returnURL]);
                }
                else
                {
                    Response.Redirect("~/Dashboard.aspx");
                    Response.End();
                }
            }

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string entity = ((Button)sender).Text;
                if (Page.IsValid)
                {
                    string loginID = Server.HtmlEncode(tb_username.Text.Trim());
                    string pass = Server.HtmlEncode(tb_password.Text.Trim());

                    if (authenticated(loginID, pass))
                    {
                        //// Create a custom FormsAuthenticationTicket and encrypt it
                        FormsAuthenticationTicket ticket =
                             new FormsAuthenticationTicket(1, _currentUser.loginID,
                                        System.DateTime.Now,
                                        System.DateTime.Now.AddMinutes(300),//will expire in 300 min
                                        false, _currentUser.role,
                                        FormsAuthentication.FormsCookiePath);

                        // Encrypt the ticket, create the cookie, then redirect.
                        string encTicket = FormsAuthentication.Encrypt(ticket);
                        SetCookie(encTicket);

                        Session["IsIdealRAdmin"] = true;

                        if (ViewState[_returnURL] != null)
                            Response.Redirect(ViewState[_returnURL].ToString(), false);
                        else
                            Response.Redirect(FormsAuthentication.GetRedirectUrl(_currentUser.loginID, false), true);

                        //Response.Redirect(AllConstStrs.url_home, true);
                    }
                    else
                    {
                    //    ll_msg.CssClass = AllConstStrs.Error_Css;
                    //    ll_msg.Text = AllConstStrs.Login_Fail;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        // Setting Forms Authentication Cookie
        private void SetCookie(string encTicket)
        {
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket)
            {
                Secure = true,
                Domain = ".idealresidencia.com"
            };
            Response.Cookies.Add(cookie);
            HttpCookie cookie2 = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
            Response.Cookies.Add(cookie2);
        }

        private bool authenticated(string loginID, string password)
        {
            try
            {
                var ds = AdminUserModel.getUser(loginID);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    string passwordstring = ds.Tables[0].Rows[0]["password"].ToString();
                    if (password.Equals(passwordstring.Trim()))
                    {
                        _currentUser.ID = ((int)ds.Tables[0].Rows[0]["ID"]);
                        _currentUser.password = ((string)ds.Tables[0].Rows[0]["password"]).Trim();
                        _currentUser.name = ((string)ds.Tables[0].Rows[0]["name"]).Trim();
                        _currentUser.email = ((string)ds.Tables[0].Rows[0]["email"]).Trim();
                        _currentUser.role = ((string)ds.Tables[0].Rows[0]["role"]).Trim();
                        _currentUser.loginID = ((string)ds.Tables[0].Rows[0]["login_ID"]).Trim();

                        Session[AllConstStrs.se_currentUser] = _currentUser;
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

    }
}