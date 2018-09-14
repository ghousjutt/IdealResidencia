using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Configuration;
using System.Data;

namespace IdealResidencia
{
    public static class AllConstStrs
    {
            #region Connection String 
            public const string Con_IdealRConStr = "IdealRConStr";
            #endregion

            #region Urls

            public const string qs_returnURL = "returnurl";

            public const string url_err = "~/Error.aspx";

            public const string url_AddUser = "~/AddUser.aspx";
            public const string url_editUser = "~/EditUser.aspx";
            public const string url_adminPanel = "~/AdminPanel.aspx";
            public const string url_userManagement = "~/UserManagement.aspx";
            public const string url_login = "~/Login.aspx";

            public const string url_changePassword = "~/ChangePassword.aspx";
            public const string url_home = "~/Home.aspx";

            public const string url_coupons = "~/Coupons.aspx";
            public const string url_AddCoupon = "~/AddCoupon.aspx";
            public const string url_EditCoupon = "~/EditCoupon.aspx";

            //after mixing edit and add pages
            public const string url_FreightAdditoionalCosts = "~/FreightAdditionalCosts.aspx";
            public const string url_PrintingCosts = "~/PrintingCosts.aspx";
            public const string url_PrintCostDisplay = "~/PrintCostDisplay.aspx";

            public const string url_FreightCost = "~/FreightCost.aspx";
            public const string url_AdditionalCost = "~/AdditionalCost.aspx";

            public const string url_ClipArts = "~/Cliparts.aspx";
            public const string url_ClipArt = "~/Clipart.aspx";
            public const string url_ClipArtTempCat = "~/ClipartTemplateCat.aspx";

            public const string url_ClipArtCats = "~/ClipartsCats.aspx";
            public const string url_ClipArtCat = "~/ClipartCat.aspx";

            public const string url_Font = "~/Font.aspx";
            public const string url_Fonts = "~/Fonts.aspx";

            public const string url_FontCats = "~/FontCats.aspx";
            public const string url_FontCat = "~/FontCat.aspx";

            public const string url_TemplateCats = "~/TemplatesCats.aspx";
            public const string url_TemplateCat = "~/TemplateCat.aspx";
            public const string url_featuredTemeplate = "~/FeaturedTemplate.aspx";
            public const string url_featuredImgBanner = "~/FeaturedImageBanner.aspx";
            public const string url_selectFeaturedTemeplate = "~/SelectFeaturedTemplate.aspx";
            public const string url_selectFeaturedImgBanner = "~/SelectFeaturedBanner.aspx";

            public const string url_CATemplates = "~/Templates.aspx";
            public const string url_CATemplate = "~/Template.aspx";
            public const string url_CATemplateCreate = "~/Template.aspx?create=true";
            public const string url_CATemplatesCat = "~/CATemplateCat.aspx";

            public const string url_ProductCats = "~/ProductCats.aspx";
            public const string url_ProductCat = "~/ProductCat.aspx";
            public const string url_ProductCatAssign = "~/ProductCatAssign.aspx";


            public const string url_Products = "~/Products.aspx";
            public const string url_Product = "~/Product.aspx";
            public const string url_ProductColor = "~/ProductColors.aspx";
            public const string url_ProdCategories = "~/ProdSizeCats.aspx";
            public const string url_ProdColorFrontBack = "~/ProductColorFrontBack.aspx";
            public const string url_ProdColorSizePrice = "~/ProductColorSizePrice.aspx";
            public const string url_ProdAssignSizePrice = "~/ProductSizePrice.aspx";
            public const string url_ProdCatAssignImage = "~/ProductCatImg.aspx";
            //public const string url_ProductPopularity = "~/ProdPop.aspx";

            public const string url_manufacturers = "~/Manufacturers.aspx";
            public const string url_manufacturer = "~/Manufacturer.aspx";
            public const string url_manufacturerColors = "~/ManufacturerColors.aspx";
            public const string url_manufacturerColor = "~/ManufacturerColor.aspx";

            public const string url_vendors = "~/Vendors.aspx";
            public const string url_vendor = "~/Vendor.aspx";
            public const string url_vendorLogin = "~/VendorSiteLogin.aspx";
            public const string url_vendorconf = "~/VendorConf.aspx";


            public const string url_OrderIssues = "~/OrderIssues.aspx";
            public const string url_OrderIssuesWithoidQS = "~/OrderIssues.aspx?orderid=";
            public const string url_OrderIssueWithQS = "~/OrderIssue.aspx?issueid=";

            public const string url_OrderIssue = "~/OrderIssue.aspx";
            public const string url_ViewOrderIssue = "~/OrderIssueView.aspx";

            public const string url_ApprovePoCheck = "~/ApprovePOCheck.aspx";
            public const string url_ViewPaymentInfo = "~/ViewPaymentInfo.aspx";
            public const string url_ViewPaymentInfoWithQS = "~/ViewPaymentInfo.aspx?orderid=";

            public const string url_CustInteractions = "~/CustomerInteractions.aspx";
            public const string url_CustInteraction = "~/CustomerInteraction.aspx";

            public const string url_PrintLabel = "~/PrintLabel.aspx";
            public const string url_GoodsCheckin = "~/GoodsCheckin.aspx";
            public const string url_GoodsNotChecked = "~/GoodsNotChecked.aspx";

            public const string url_reportProdProblem = "~/ReportProdProblem.aspx";
            public const string url_reportProdProblemWithQS = "~/ReportProdProblem.aspx?orderid=";

            public const string url_orderCategory = "~/OrderCategory.aspx";
            public const string url_orderCategoryWithQS = "~/OrderCategory.aspx?orderid=";

            public const string url_doShipment = "~/DoShipment.aspx";
            public const string url_doShipmentWithQS = "~/DoShipment.aspx?orderid=";

            public const string url_workSheet = "~/Worksheet.aspx";
            public const string url_deleteorder = "~/DeleteOrder.aspx?orderid=";
            public const string url_outsourceorder = "~/SendToExternalPrinter.aspx?orderid=";
            public const string url_uploadoutsourceorder = "~/UploadFilesExternalPrinter.aspx?orderid=";

            public const string url_Sales = "~/Sales.aspx";

            public const string url_artStatus = "~/ArtStatus.aspx";

            public const string url_orderStatus = "~/OrderStatus.aspx";

            public const string url_shippings = "~/Shipping.aspx";

            public const string url_designs = "~/designs.aspx";


            public const string url_productBanners = "~/ProductBanners.aspx";
            public const string url_productBanner = "~/ProductBanner.aspx";
            public const string url_productCatSeo = "~/ProductCatsSeo.aspx";

            public const string url_templateBanners = "~/TemplatesBanners.aspx";
            public const string url_templateBanner = "~/TemplatesBanner.aspx";
            public const string url_templateSeo = "~/TemplateCatsSeo.aspx";

            public const string url_worksheet = "~/Worksheet.aspx";
            public const string url_editWorksheet = "~/EditWorksheet.aspx";
            //public const string url_packingslip = "~/PackingSlip.aspx";
            public const string url_pricingsheet = "~/PricingSheet.aspx";
            public const string url_printableworksheet = "~/PrintableWorksheet.aspx";
            public const string url_pricingsheetWithQS = "~/PricingSheet.aspx?orderid=";

            public const string url_new_packingslip = "/worksheets/index.html#slip/";
            public const string url_new_worksheet = "/worksheets/index.html#worksheet/";

            public const string url_templateCatAssignImage = "~/TemplateCatImg.aspx";

            public const string url_jobOverView = "~/JobOverview.aspx";

            public const string url_productSeo = "~/ProductSeo.aspx";
            public const string url_productsSeo = "~/ProductsSeo.aspx";


            public const string url_customerSearch = "~/CustomerSearch.aspx";
            public const string url_customerDetail = "~/CustomerDetail.aspx";
            public const string url_customerDetailWithQS = "~/CustomerDetail.aspx?custid=";

            public const string url_orderSearch = "~/OrderSearch.aspx";


            public const string url_productsReviews = "~/ProductReviews.aspx";
            public const string url_productReview = "~/ProductReview.aspx";
            public const string url_productReviewWithQS = "~/ProductReview.aspx?id=";


            public const string url_testimonials = "~/Testimonials.aspx";
            public const string url_testimonial = "~/Testimonial.aspx";
            public const string url_testimonialWithQS = "~/Testimonial.aspx?id=";


            //used by many pages order id link,  sales, shipping, order issue , report problem, goods chekin
            public const string url_worksheetWithQS = url_worksheet + "?orderid=";
            public const string url_editworksheetURLWithQS = url_editWorksheet + "?orderid=";
            public const string url_printableworksheetURLWithQS = url_printableworksheet + "?orderid=";
            public const string url_designworksheetWithQS = url_worksheet + "?designid=";


            //reports
            public const string url_reportCoupon = "~/ReportCoupon.aspx";
            public const string url_reportCustomer = "~/ReportCustomer.aspx";
            public const string url_reportTopCustomer = "~/ReportTopCustomer.aspx";
            public const string url_reportSales = "~/ReportSales.aspx";
            public const string url_reportOrderDesigns = "~/ReportOrderDesigns.aspx";

            public const string url_DesignerDatacomm = "/app/datacomm/datacomm.aspx";

            //public const string url_Designer = "/design-studio?designid=";

            public const string url_designstudio = "https://www.designashirt.com/design-studio?design=";

            public const string url_checkout = "/checkout/Checkout.aspx?design=";



            #endregion

            #region Strings

            public const string BreadCrumbID = "map";

            //public const string RowHCSS = "pnHeader";
            public const string RowBCSS = "pnBody";//dynamic collapsible panels style --> sample in Cliparts
            public const string RowHCSS = "Table1";//skin ID

            public const string upImgSkin = "upImg";
            public const string downImgSkin = "downImg";

            #region Upload

            public static string[] ImgUploadExtentions = new string[] { ".jpg", ".gif", ".png", ".bmp" };
            public const string TTFFileExtention = ".ttf";
            public const string VectorFileExtention = ".svg";
            public const string FlashFileExtention = ".swf";
            public const string OTFFileExtention = ".otf";


            public const string Err_UploadExtention = "Invalid upload file type.";
            public const string Err_Upload = "Upload Failed.";
            public const string Err_UploadEmpthy = "Please select a file to upload ";
            public const string Err_UploadSize = "Upload failed, file is too large.";
            #endregion


            #region Users

            public const string App_Err = "Sorry! An Internal System Error Occured. Please Try Again or Contact Admin.";
            public const string Dup_Username = "Username is already used. Select another username.";

            public const string Username_Hint = "Username must be alphanumeric, at least 7 characters, no more than 20 characters.";
            public const string Login_Fail = "Login failed. Please Enter correct Username/Password.";

            public const string LoginID_Empty = "Please fill login ID.";
            public const string Name_Hint = "Name Could be Up to 40 uppercase and lowercase characters and a few special characters that are common to some names.ex. John Doe O'Dell.";
            public const string New_Old_Pass_Same = "New passwrod is the same as old password. Please select another password.";
            public const string No_Access = "You don't have access to this page.";
            public const string Old_Pass_Incorrect = "Old password you entered is incorrect.";
            public const string Pass_Empthy = "Please fill password.";
            public const string Pass_Has_Username = "Password contains username. Please select another password.";
            public const string Pass_Hint = "Password must be at least 7 characters, no more than 20 characters, Must contain at least one one lower case letter, one upper case letter, one digit.";
            public const string Pass2_Hint = "Password must be at least 5 characters, no more than 20 characters";
            public const string Password_Conf_Mismatch = "Password and confirm Password doesnt match.";
            public const string Phone_Format = "{0:# (###) ###-####}";
            public const string Role_Empthy = "Please select a role.";
            #endregion

            #region MSG
            public const string couponMinMax = "Coupon max number of items must be greater than min number of items.";
            public const string couponStartEnd = "Coupon end date must be equal or greater than start date.";

            public const string GTZero = " must be greater than zero.";
            public const string GTOrEqualZero = " must be greater than or equal to zero.";
            public const string PlzFill = "Please fill ";
            public const string PlzSelect = "Please select ";
            public const string UnableToParse = "Incorrect format. Unable to parse ";
            public const string InsufficentAccess = "You do not have sufficient access to view this page.";
            public const string NotAuthen = "You are not logged in to the system. Please login again.";
            public const string DupCoupon = "Duplicate coupon code. Please try with new coupon code.";

            public const string Error_Css = "error";
            public const string Err_Add_User = "Failed To Add User.";
            public const string Err_Change_Pass = "Failed to change the password.";
            public const string Err_Delete_User = "Failed To Delete User.";
            public const string Err_Edit_User = "Failed To Update User Information.";
            public const string Err_Add_Coupon = "Failed To Add New Coupon.";
            public const string Err_Edit_Coupon = "Failed To Update Coupon.";
            public const string Err_Delete_Coupon = "Failed To Delete Coupon Information.";
            public const string Err_Add_Freight = "Failed To Add New Freight.";
            public const string Err_Edit_Freight = "Failed To Update Freight.";
            public const string Err_Delete_Freight = "Failed To Delete Freight Information.";

            public const string Err_Add = "Failed To Add New ";
            public const string Err_Edit = "Failed To Update ";
            public const string Err_Restore = "Failed To Restore ";
            public const string Err_Delete = "Failed To Delete ";
            public const string Err_Archive = "Failed To Archive ";
            public const string Err_Assign = "Failed To Assign ";
            public const string Err_QS = "Query string is not defined.";

            public const string Success_Css = "success";
            public const string Suc_Add_User = "User Added Successfully.";
            public const string Suc_Change_Pass = "Password changed successfully.";
            public const string Suc_Delete_user = "User Deleted Successfully.";
            public const string Suc_Edit_User = "User Updated Successfully.";
            public const string Suc_Add_Coupon = "Coupon Added Successfully.";
            public const string Suc_Edit_Coupon = "Coupon Updated Successfully.";
            public const string Suc_Delete_Coupon = "Coupon Deleted Successfully.";
            public const string Suc_Add_Freight = "Freight Added Successfully.";
            public const string Suc_Edit_Freight = "Freight Updated Successfully.";
            public const string Suc_Delete_Freight = "Freight Deleted Successfully.";

            public const string Suc_Add = "Added Successfully.";
            public const string Suc_Edit = "Updated Successfully.";
            public const string Suc_Restore = "Restored Successfully.";
            public const string Suc_Delete = "Deleted Successfully.";
            public const string Suc_Archive = "Archived Successfully.";


            public const string Err_LoadData = "Failed To Load Information From Database.";

            public const string Err_LoadDataNull = "No Info available to dispaly.";

            #endregion

            #endregion

            #region Regx
            public const string regx_Name = @"^[a-zA-Z-'\s]{1,50}$";//	Name Could be Up to 40 uppercase and lowercase characters and a few special characters that are common to some names.ex. John Doe O'Dell.
            public const string regx_Normal_Text = @"^([a-zA-Z0-9\s!?'-\.]{3,50})$";//	Only alphanumeric and '- and white space symbols are allowd.
            public const string regx_Password = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{7,20}$";//	Password must be at least 7 characters, no more than 20 characters, Must contain at least one one lower case letter, one upper case letter, one digit.
            public const string regx_Password2 = @"^.{5,20}$";//	Password must be at least 7 characters, no more than 20 characters

            public const string regx_URL = @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";//	Format should be http://www.example.com.
            public const string regx_username = @"^[a-zA-Z0-9_]{7,20}$";//	Username must be alphanumeric, at least 7 characters, no more than 20 characters.

            #endregion

            #region Session Strings

            public const string se_treeviewNodes = "usertree";

            public const string se_currentUser = "CurrentUser";
            public const string se_UserToEdit = "User";
            public const string se_UsersDataSet = "UsersDS";

            public const string se_couponsDataSet = "CouponsDS";
            public const string se_couponToEdit = "coupon";

            public const string se_frightDataSet = "frightDS";
            public const string se_frightToEdit = "fright";

            public const string se_clipArtCatDS = "clipArtCatDS";
            public const string se_clipCatToEdit = "clipCat";

            public const string se_clipArtDS = "clipArtDS";
            public const string se_clipartToEdit = "clipart";
            public const string se_CATemplateToEdit = "CATemplate";


            public const string se_FontsDS = "FontsDS";
            public const string se_fontToEdit = "fontCat";

            public const string se_fontCatDS = "fontCatDS";
            public const string se_fontCatToEdit = "fontCat";

            public const string se_templatesCatsDS = "templatesCatsDS";
            public const string se_templateCatToEdit = "templateCat";
            public const string se_templateCatToAssignBanner = "tempCatAssBnr";
            public const string se_templateCatToAssignTemplate = "tempCatAssTemp";

            public const string se_parentTemplateCat = "templateCatParent";

            public const string se_productsDS = "productsDS";
            public const string se_productsToEdit = "products";

            public const string se_additionalDataSet = "additionalDS";
            public const string se_additionalToEdit = "additional";

            //public const string se_printingDataSet = "printingDS";
            public const string se_printCostToEdit = "printing";
            public const string se_sideInksDS = "SideInksDS";

            public const string se_vendorsDS = "vendorsDS";
            public const string se_vendorToEdit = "vendor";

            public const string se_manufactDS = "manufactDS";
            public const string se_manufactToEdit = "manufact";

            public const string se_manufactColorDS = "manufactColorDS";
            public const string se_manufactColorToEdit = "manufactColor";

            public const string se_productDS = "productsDS";
            public const string se_productSeoDS = "productsSeoDS";
            public const string se_productToEdit = "product";


            public const string se_productCatToEdit = "productCat";
            public const string se_productCatsDS = "productCatsDS";// all product categories and thier name
            public const string se_productCatIds = "productCatsIDs";//list of Categorys ids belongs to a product
            public const string se_productColorsDS = "prodColorsDS";
            public const string se_productColorSizePriceDS = "prodColorSizePriceDS";
            public const string se_prodColorFBImgDS = "prodColorFBImgDS";
            public const string se_prodColorSizePriceDS = "prodColorSizePriceDS";//sizeprice
            public const string se_productsBrowserDS = "AllProdInfoDS";//Product Browser



            //product sizes and prices applying for several colors
            public const string se_colorID = "colorID";//used in product color size page (--view state init problem--)
            public const string se_productDetailsDS = "ProductDetailsDS";


            //public const string se_prodCatImgsDS = "prodCatImgsDS";//sizeprice

            public const string se_vendorsConfDS = "vendorsConfDS";

            public const string se_errorPageMsg = "Error";

            public const string se_orderIssuesDS = "OrderIssuesDS";
            public const string se_orderIssue = "OrderIssue";

            public const string se_custInteractionDS = "CustInterActDS";
            public const string se_custInteraction = "CustInterAct";

            public const string se_goodsCheckinDS = "GoodsCheckInDS";
            public const string se_goodsVendorConfDS = "GoodsVendorConfDS";

            public const string se_OrderCategoryDS = "orderCategoryDS";

            //public  const string se_shippingCompDS = "shippingCompDS";
            public const string se_orderShippingDS = "orderShippingDS";

            public const string se_orderStatusDS = "orderStatusDS";
            public const string se_artStatusDS = "artStatusDS";

            public const string se_salesDS = "salesDS";

            public const string se_shippingDS = "shippingDS";

            public const string se_orderSummaryDS = "orderSummaryDS";

            public const string se_designsDS = "designsDS";

            public const string se_goodsNotCheckedDS = "goodsNotCheckedDS";


            //FeaturedProduct Table- CMS
            public const string se_prodBannersDS = "prodBannersDS";
            public const string se_prodCustomBannersDS = "prodCustomBannersDS";

            //FeaturedTemplate Table - CMS
            public const string se_templateBannersDS = "templateBannersDS";
            public const string se_templateCustomBannersDS = "templateCustomBannersDS";


            public const string se_productCatsBrowserDS = "prodCatsBrowserDS";

            public const string se_JobOverviewDS = "JobOverviewDS";
            public const string se_OrderID = "orderid";


            //order search
            public const string se_orderSearchDS = "OrderSearchDS";

            //Customer search
            public const string se_customerSearchDS = "CustSearchDS";

            //customerDetials
            public const string se_customerDetailDS = "CustDetailDS";

            //Product Review
            public const string se_prodReviewDS = "ProdReviewDS";

            //Testimonials
            public const string se_testimonialsDS = "TestimonialsDS";

            //Report Coupon
            public const string se_reportCouponDS = "RepCouponDS";

            //Report Customer
            public const string se_reportCustomerDS = "RepCustomerDS";

            //Report Top Customer
            public const string se_reportTopCustomerDS = "RepTopCustomerDS";

            //Report Sales
            public const string se_reportSalesDS = "RepSalesDS";

            //Report Designs
            public const string se_reportOrderDesignDS = "OrderDesignDS";

            public const string se_printcostreportDS = "PrintCostReportDS";

            public const string se_printthisweekDS = "PrintThisWeekDS";
            public const string se_shipcostreportDS = "ShipCostReportDS";


            #endregion

            //#region View State Strings
            ////Screen Print Cost Sides
            //public const string se_s1 = "s1";
            //public const string se_s2 = "s2";
            ////Digital Print Cost Sides
            //public const string se_d1 = "d1";
            //public const string se_d2 = "d2";
            //#endregion

            public static string GetCommaDelimited(object txt)
            {
                char[] split = { ',' };
                var splitStr = txt.ToString().Split(split, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder sa = new StringBuilder();
                if (splitStr.Length == 1) return splitStr[0];
                for (int i = 1; i <= splitStr.Length; i++)
                {
                    sa.Append(i.ToString() + "- " + splitStr[i - 1] + "<br />");
                }
                return sa.ToString();
            }

            public static DataTable GetTrackingURLs(object txt)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("URL");
                dt.Columns.Add("TrackNum");
                DataRow dr;
                string tmp;
                int index;

                char[] split = { ',' };
                var splitStr = txt.ToString().Split(split, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder sa = new StringBuilder();

                for (int i = 0; i < splitStr.Length; i++)
                {
                    dr = dt.NewRow();
                    dr["TrackNum"] = dr["URL"] = splitStr[i];
                    index = splitStr[i].LastIndexOf("=") + 1;
                    if (index != -1)
                    {
                        tmp = splitStr[i].Substring(index, splitStr[i].Length - index);
                        dr["TrackNum"] = tmp;
                    }
                    dt.Rows.Add(dr);
                    // sa.Append(i.ToString() + "- " + splitStr[i - 1] + "<br />");
                }
                return dt;
            }

            public static string Rating(object txt)
            {
                try
                {
                    var i = int.Parse(txt.ToString());
                    switch (i)
                    {
                        case 1:
                            return "Poor";
                        case 2:
                            return "Fair";
                        case 3:
                            return "Neutral";
                        case 4:
                            return "Good";
                        case 5:
                            return "Excellent";

                        default:
                            return "";
                    }
                }
                catch { return ""; }
            }


            public static string CorrectURL(string url)
            {
                try
                {
                    return url.Trim().ToLower().Replace("/", "-").Replace(" ", "-").Replace("%", string.Empty).Replace("'", string.Empty).Replace("&", "and").Replace("`", string.Empty).Replace(".", string.Empty);
                }
                catch { return url; }
            }

            //public static string GetMoney(this object p)
            //{
            //    try
            //    {                
            //        return (p == null ? "" : Math.Round((decimal)p,2)); 
            //    }
            //    catch { return ""; }
            //}

            public static decimal GetMoneyRound(this decimal p)
            {
                try
                {
                    return Math.Round((decimal)p, 2);
                }
                catch { return 0; }
            }

            public static string UppercaseFirst(this object str)
            {
                return System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(str.ToString().Trim().ToLower());
            }



            //public static Bitmap ResizeImage (this System.Web.UI.WebControls.FileUpload fu, Size newSize)
            //{
            //    Bitmap originalBMP = null, newBMP = null;
            //    Graphics oGraphics = null;

            //    try
            //    {
            //        // Create a bitmap of the content of the fileUpload control in memory
            //        originalBMP = new Bitmap(fu.FileContent);

            //        // Calculate the new image dimensions
            //        int origWidth = originalBMP.Width;
            //        int origHeight = originalBMP.Height;
            //        //int sngRatio = origWidth / origHeight;

            //        // Create a new bitmap which will hold the previous resized bitmap
            //        newBMP = new Bitmap(originalBMP, newSize.Width,  newSize.Height);

            //        // Create a graphic based on the new bitmap
            //        oGraphics = Graphics.FromImage(newBMP);
            //        // Set the properties for the new graphic file
            //        oGraphics.SmoothingMode = SmoothingMode.AntiAlias; oGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //        // Draw the new graphic based on the resized bitmap
            //        oGraphics.DrawImage(originalBMP, 0, 0, newSize.Width, newSize.Height);

            //        return newBMP;
            //        // Save the new graphic file to the server
            //        //newBMP.Save(directory + "tn_" + filename);
            //    }
            //    catch 
            //    {
            //        return null;
            //    }
            //    finally
            //    {
            //        // Once finished with the bitmap objects, we deallocate them.
            //        originalBMP.Dispose();
            //        newBMP.Dispose();
            //        oGraphics.Dispose();
            //    }
            //}

            //public static string DesignImageURL(object designID, bool isBackImg = false, DateTime? lastModified = null)
            //{
            //    try
            //    {
            //        return MakeDesignImageURL(isBackImg, designID.ToString(), lastModified);
            //    }
            //    catch
            //    {
            //        return "";
            //    }
            //}

            // pulled from www/Helper/Utility
            //public static string MakeDesignImageURL(bool isBackImg = true, string designID = "", DateTime? lastModified = null)
            //{
            //    string suffix = "";
            //    if (lastModified != null)
            //    {
            //        string dt = Convert.ToDateTime(lastModified).ToString("yyyy'-'MM'-'dd HH':'mm':'ss'Z'");
            //        suffix = "?v=" + Md5Hash(dt);
            //    }

            //    try
            //    {
            //        return S3Manager.Instance.DesignPreviewImgReadPath + (isBackImg ? designID.Trim() + ".full.back.jpg" : designID.Trim() + ".full.front.jpg") + suffix;
            //    }
            //    catch
            //    {
            //        return "";
            //    }
            //}

            //public static string MakeSecureDesignImageURL(bool isBackImg = true, string designID = "", DateTime? lastModified = null)
            //{
            //    string suffix = "";
            //    if (lastModified != null)
            //    {
            //        string dt = Convert.ToDateTime(lastModified).ToString("yyyy'-'MM'-'dd HH':'mm':'ss'Z'");
            //        suffix = "?v=" + Md5Hash(dt);
            //    }

            //    try
            //    {
            //        return S3Manager.Instance.DesignPreviewImgReadPath + (isBackImg ? designID.Trim() + ".full.back.jpg" : designID.Trim() + ".full.front.jpg") + suffix;
            //    }
            //    catch
            //    {
            //        return "";
            //    }
            //}

            //public static string MakeSecureDesignImageSmallURL(bool isBackImg = true, string designID = "", DateTime? lastModified = null)
            //{
            //    string suffix = "";
            //    if (lastModified != null)
            //    {
            //        string dt = Convert.ToDateTime(lastModified).ToString("yyyy'-'MM'-'dd HH':'mm':'ss'Z'");
            //        suffix = "?v=" + Md5Hash(dt);
            //    }

            //    try
            //    {
            //        return S3Manager.Instance.DesignPreviewImgReadPath + (isBackImg ? designID.Trim() + ".full.small.back.jpg" : designID.Trim() + ".full.small.front.jpg") + suffix;
            //    }
            //    catch
            //    {
            //        return "";
            //    }
            //}

            public static string Md5Hash(string str)
            {
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

                byte[] bytes = System.Text.Encoding.ASCII.GetBytes(str);
                byte[] hash = md5.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }

                return sb.ToString();
            }

            public static DateTime GetStartOfCurrentWeek()
            {
                int DaysToSubtract = (int)DateTime.Now.DayOfWeek;
                DateTime dt = DateTime.Now.Subtract(TimeSpan.FromDays(DaysToSubtract));
                return new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
            }

            public static DateTime GetEndOfCurrentWeek()
            {
                DateTime dt = GetStartOfCurrentWeek().AddDays(6);
                return new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59, 999);
            }

            //adding function that return application hostname
            public static string GetRootUrl()
            {
                return GetRootUrl(false);
            }

            public static string GetRootUrl(bool secure)
            {
                // DAS-855 change to proto rel 
                // DAS-882 always do https now that pdf generation string replaces
                return "";
            }


            //public const string url_productsPublic = "/products";
            //public const string url_galleryPublic = "/design-ideas";

            //#region Product category URL Builder
            //public static string ProductParentCatURLBuilder(object catName, object catID)
            //{
            //    try
            //    {
            //        //products
            //        return url_productsPublic + CorrectURL(catName.ToString()) + "/?cat=" + catID.ToString();
            //    }
            //    catch { return url_productsPublic; }
            //}
            //public static string ProductChildCatURLBuilder(object parentName, object catName, object catID)
            //{
            //    try
            //    {
            //        //products
            //        return url_productsPublic + CorrectURL(parentName.ToString()) + "/" +
            //            CorrectURL(catName.ToString()) + "/?cat=" + catID.ToString();
            //    }
            //    catch { return url_productsPublic; }
            //}
            //#endregion
            //#region Idea Gallery Category URL builder
            //public static string GalleryParentCatURLBuilder(object catName, object catID)
            //{
            //    try
            //    {
            //        //design-ideas
            //        ///design-ideas/{0}/cat={1}
            //        return url_galleryPublic + "/" + CorrectURL(catName.ToString()) + "/cat=" + catID.ToString();
            //    }
            //    catch { return url_galleryPublic; }
            //}

            //public static string GalleryChildCatURLBuilder(object parentName, object catName, object catID)
            //{
            //    try
            //    {
            //        return url_galleryPublic + "/" + CorrectURL(parentName.ToString()) + "/" + CorrectURL(catName.ToString()) + "/cat=" + catID.ToString();
            //    }
            //    catch { return url_galleryPublic; }
            //}
            //#endregion
    }
}