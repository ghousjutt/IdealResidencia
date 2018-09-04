/* ------------------------------------------------------------------ */
/* The 'IdealR.Helper.AllConstStrs' in C#                                */
/* ------------------------------------------------------------------ */
/* Copyright (c) Ideal Residencia, 2018.  All rights reserved.        */
/* ------------------------------------------------------------------ */
/* Version:     1.0.0.0                                               */
/* Author:      Ammar Baig                                            */                              
/* Date:        Sept, 2018                                             */
/* ------------------------------------------------------------------ */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Configuration;

namespace IdealR.Helper
{
    public static class AllConstStrs
    {
        public const string con_ConnectionStrName = "IdealRConStr";
        
        #region Email Templates Query string / Session Variables
        public const string em_title = "title";//title for all email pages
        public const string em_name = "name";//used as first name, name
        public const string em_designName = "designName";//used as (design name == project name )
        public const string em_friendName = "name";
        public const string em_email = "email";//NewAccount.aspx email address
        public const string em_password = "pass";//used in ForgotPassword.aspx Email template
        public const string em_id = "id";//used as orderid / design id , depend on page
        public const string em_quoteObj = "quteObj";//Session var for quote to be mailed
        public const string em_msg = "msg";//Session var for send to friend, txt that user sends to his friend 
        // I can't find any references to em_msg above, but I don't feel comfortable removing/changing it.
        // The message was missing from sendtofriend email, I'm adding this to get it working.
        public const string em_msg2 = "message";//Session var for send to friend, txt that user sends to his friend 
        public const string em_unique = "unique";  // Session var to prevent email from being double sent
        #endregion

        #region Products Query Strings
        public const string qs_catID = "cat";
        public const string qs_catName = "catName";//no longer used as query string only for storing perposes
        public const string qs_brandName = "brandName";//no longer used as query string
        public const string qs_brand = "brand";
        public const string qs_price = "price";
        public const string qs_color = "color";
        public const string qs_size = "size";
        public const string qs_sizeName = "sizeName";//no longer used as query string
        public const string qs_fabric = "fabric";
        public const string qs_weight = "weight";
        public const string qs_printType = "print";
        public const string qs_productID = "product";
        //is used for products master page to add bread crumbs home->product->parent cat->child cat
        public const string qs_parentCatID = "pCatID";//parent cat id
        public const string qs_parentCatName = "pCatName";//parent cat name

        #endregion

        #region Designer Query Strings
        //color and product ID is shared
        public const string qs_design = "design";
        public const string qs_template = "template";
        #endregion

        #region Testimonials Query Strings
        public const string qs_year = "year";
        #endregion

        #region Review Query Strings
        public const string qs_orderid = "o";
        public const string qs_custPersonID = "p";
        #endregion

        #region Search Query Strings
        //color and product ID is shared
        public const string qs_searchType = "t";
        public const string qs_searchKeyword = "q";
        #endregion


        #region Strings

        public const string BreadCrumbID = "map";
        public const string se_galleryCatIdStr = "galcatid";
        public const string se_galleryCatNameStr = "galcatName";
        public const string se_galleryParentCatIdStr = "galPcatid";
        public const string se_galleryParentCatNameStr = "galPcatName";

        #endregion
    }
}