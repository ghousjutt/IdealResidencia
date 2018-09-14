/*Author:   Ammar Baig - 2018*/

using System.Web.Security;
using IdealResidencia.Shared;

namespace IdealResidencia
{


    // BP KI KAHANI KHATAMMMMMMMMMMMMMMMMMMMMMMMMmm
    // all base pages inherit from a root base page instead of system page
    public class BP : System.Web.UI.Page 
    {
        protected override void OnPreInit(System.EventArgs e)
        {
            base.OnPreInit(e);
            // if session goes away then consider the user logged out
            if (Session[AllConstStrs.se_currentUser] == null) 
            {
                FormsAuthentication.SignOut();
                SetErr.NotAuthenticated();
                System.Web.HttpContext.Current.Response.End();
            }
        }
    }

    // allow public access to page if request is properly signed
    public class SignedBP : System.Web.UI.Page
    {
        protected override void OnPreInit(System.EventArgs e)
        {
            base.OnPreInit(e);
            if (System.Web.HttpContext.Current.Request.QueryString["sig"] != null)
            {
                var req = System.Web.HttpContext.Current.Request;
                //"/checkout/checkout.aspx?customer="+_custID+"&design="+Eval("DesignID")+"&reorder="+Eval("OrderID")
                //Hmac.SignUrl(message, System.DateTime.UtcNow.AddMinutes(10));
                if (!Hmac.ValidateRequest(req.Url))
                {
                    SetErr.NotAuthenticated();
                    System.Web.HttpContext.Current.Response.End();
                }
            }
            // if session goes away then consider the user logged out
            else if (Session[AllConstStrs.se_currentUser] == null) 
            {
                FormsAuthentication.SignOut();
                SetErr.NotAuthenticated();
                System.Web.HttpContext.Current.Response.End();
            }
        }
    }
    //------------------------------------------------------------------------------------------------
    public class SuperAdminBP : BP
    {
        protected override void OnPreInit(System.EventArgs e)
        {
            base.OnPreInit(e);
            if (!CheckRole.IsAuthenticated())
                SetErr.NotAuthenticated();
            else if (!CheckRole.IsSuperAdmin())
            {
                SetErr.Redirect();
            }
        }
    }
    //------------------------------------------------------------------------------------------------
    public class AdminBP : BP
    {
        protected override void OnPreInit(System.EventArgs e)
        {
            base.OnPreInit(e);
            if (!CheckRole.IsAuthenticated())
                SetErr.NotAuthenticated();
            else if (!CheckRole.IsAdmin())
            {
                SetErr.Redirect();
            }
        }
    }
    //------------------------------------------------------------------------------------------------
    public class ManagementBP : BP
    {
        protected override void OnPreInit(System.EventArgs e)
        {
            base.OnPreInit(e);
            if (!CheckRole.IsAuthenticated())
                SetErr.NotAuthenticated();
            else if (!CheckRole.IsManagement())
            {
                // redirect to error page
                SetErr.Redirect();
            }
        }
    }
    //------------------------------------------------------------------------------------------------
    public class ProductBP : BP
    {
        protected override void OnPreInit(System.EventArgs e)
        {
            base.OnPreInit(e);
            if (!CheckRole.IsAuthenticated())
                SetErr.NotAuthenticated();
            else if (!CheckRole.IsProduct())
            {
                SetErr.Redirect();
            }

        }
    }
    //------------------------------------------------------------------------------------------------
    public class BasicBP : BP
    {
        protected override void OnPreInit(System.EventArgs e)
        {
            base.OnPreInit(e);
            if (!CheckRole.IsAuthenticated())
                SetErr.NotAuthenticated();
        }
    }
    public class SignedBasicBP : SignedBP
    {
    }
    //------------------------------------------------------------------------------------------------
    public class ArtBP : BP
    {
        protected override void OnPreInit(System.EventArgs e)
        {
            base.OnPreInit(e);
            if (!CheckRole.IsAuthenticated())
                SetErr.NotAuthenticated();
            else if (!CheckRole.IsArt())
            {
                SetErr.Redirect();
            }
        }
    }
    //------------------------------------------------------------------------------------------------
    public class CMSBP : BP
    {
        protected override void OnPreInit(System.EventArgs e)
        {
            base.OnPreInit(e);
            if (!CheckRole.IsAuthenticated())
                SetErr.NotAuthenticated();

            else if (!CheckRole.IsCMS())
            {
                SetErr.Redirect();
            }
        }
    }
    //------------------------------------------------------------------------------------------------
    public class OrderBP : BP
    {
        protected override void OnPreInit(System.EventArgs e)
        {
            base.OnPreInit(e);
            if (!CheckRole.IsAuthenticated())
                SetErr.NotAuthenticated();

            else if (!CheckRole.IsOrder())
            {
                SetErr.Redirect();
            }
        }
    }
    //------------------------------------------------------------------------------------------------
    public class CmsProdBP : BP
    {
        protected override void OnPreInit(System.EventArgs e)
        {
            base.OnPreInit(e);
            if (!CheckRole.IsAuthenticated())
                SetErr.NotAuthenticated();

            else if (!CheckRole.IsCMSAndProduct())
            {
                SetErr.Redirect();
            }
        }
    }
    //------------------------------------------------------------------------------------------------
    public static class SetErr
    {
        public static void Redirect()
        {
            System.Web.HttpContext.Current.Response.Redirect(AllConstStrs.url_login);
            //string[] msg = new string[] { AllConstStrs.InsufficentAccess };
            //System.Web.HttpContext.Current.Session[AllConstStrs.se_errorPageMsg] = msg;
            //System.Web.HttpContext.Current.Response.Redirect(AllConstStrs.url_err, true);
        }
        public static void NotAuthenticated()
        {
            //System.Web.HttpContext.Current.Response.Redirect(AllConstStrs.url_login);
            System.Web.HttpContext.Current.Response.Redirect(AllConstStrs.url_login + "?RETURNURL=" + System.Web.HttpContext.Current.Request.Url.PathAndQuery, false);
            //System.Web.HttpContext.Current.Response.Redirect(AllConstStrs.url_login + "?RETURNURL=" + System.Web.HttpContext.Current.Request.Url.OriginalString);
            //string[] msg = new string[] { AllConstStrs.NotAuthen };
            //System.Web.HttpContext.Current.Session[AllConstStrs.se_errorPageMsg] = msg;
            //System.Web.HttpContext.Current.Response.Redirect(AllConstStrs.url_err, true);
        }
    }
    //-------------------------------------------------------------------------------------------------
    /// <summary>
    /// All the other classes use this class static methods to check users role to see to which grup it belongs
    /// </summary>
    public static class CheckRole
    {
        public static bool IsAuthenticated()
        {
            return System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
        }
        public static bool IsSuperAdmin()
        {
            if (System.Web.HttpContext.Current.User.IsInRole("SA"))
                return true;
            else
                return false;
        }
        public static bool IsAdmin()
        {
            if (System.Web.HttpContext.Current.User.IsInRole("SA") ||
                System.Web.HttpContext.Current.User.IsInRole("A"))
                return true;
            else
                return false;
        }
        public static bool IsProduct()
        {
            if (System.Web.HttpContext.Current.User.IsInRole("SA") ||
                System.Web.HttpContext.Current.User.IsInRole("A") ||
                System.Web.HttpContext.Current.User.IsInRole("S") ||
                System.Web.HttpContext.Current.User.IsInRole("Ar") ||
                System.Web.HttpContext.Current.User.IsInRole("P"))
                return true;
            else
                return false;
        }
        public static bool IsArt()//same as supervisor, right now art and supervisor have same right
        {
            if (System.Web.HttpContext.Current.User.IsInRole("SA") ||
                System.Web.HttpContext.Current.User.IsInRole("A") ||
                System.Web.HttpContext.Current.User.IsInRole("S") ||
                System.Web.HttpContext.Current.User.IsInRole("Ar"))
                return true;
            else
                return false;
        }
        public static bool IsSupervisor()//same as supervisor
        {
            if (System.Web.HttpContext.Current.User.IsInRole("SA") ||
                System.Web.HttpContext.Current.User.IsInRole("A") ||
                System.Web.HttpContext.Current.User.IsInRole("S") ||
                System.Web.HttpContext.Current.User.IsInRole("Ar"))
                return true;
            else
                return false;
        }
        public static bool IsManagement()//most of add edit delete pages, right now art and supervisor have same rights 
        {
            if (System.Web.HttpContext.Current.User.IsInRole("SA") ||
                System.Web.HttpContext.Current.User.IsInRole("A") ||
                System.Web.HttpContext.Current.User.IsInRole("S") ||
                System.Web.HttpContext.Current.User.IsInRole("Ar"))
                return true;
            else
                return false;
        }
        public static bool IsCMS()
        {
            if (System.Web.HttpContext.Current.User.IsInRole("CMS") ||
                System.Web.HttpContext.Current.User.IsInRole("A") ||
                System.Web.HttpContext.Current.User.IsInRole("SA") ||
                System.Web.HttpContext.Current.User.IsInRole("S") ||
                System.Web.HttpContext.Current.User.IsInRole("Ar"))
                return true;
            else
                return false;
        }
        public static bool IsOrder()//ppl that can see orders
        {
            if (System.Web.HttpContext.Current.User.IsInRole("A") ||
                System.Web.HttpContext.Current.User.IsInRole("SA") ||
                System.Web.HttpContext.Current.User.IsInRole("S") ||
                System.Web.HttpContext.Current.User.IsInRole("W") ||
                System.Web.HttpContext.Current.User.IsInRole("Ar"))

                return true;
            else
                return false;
        }
        public static bool IsCMSAndProduct()//like product banner should be viewd by both product role and cms role
        {
            if (System.Web.HttpContext.Current.User.IsInRole("CMS") ||
                System.Web.HttpContext.Current.User.IsInRole("P") ||
                System.Web.HttpContext.Current.User.IsInRole("A") ||
                System.Web.HttpContext.Current.User.IsInRole("SA") ||
                System.Web.HttpContext.Current.User.IsInRole("S") ||
                System.Web.HttpContext.Current.User.IsInRole("Ar"))
                return true;
            else
                return false;
        }
        public static bool IsWarehouse()
        {
            if (System.Web.HttpContext.Current.User.IsInRole("W"))

                return true;
            else
                return false;
        }
    }
}
