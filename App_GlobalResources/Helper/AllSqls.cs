/*Author:   Nabil Assadi - 2010*/
namespace IdealResidencia
{
    public static class AllSqls
    {
        #region Users
        public const string getUsers = "SELECT ID, name, login_ID, password,email, role_ID,IsCustomerStaff FROM dbo.AdminUser";
        public const string getArtUsers = "SELECT ID, login_ID FROM dbo.AdminUser WHERE role_ID IN ('SA', 'A', 'Ar')";
        public const string getUserByID = "SELECT * FROM dbo.AdminUser Where Id =@ID";
        public const string getUserByUsername = "SELECT * FROM dbo.AdminUser Where login_ID =@login_ID";
        public const string insertUser = "INSERT INTO [dbo].[AdminUser] ([name], [login_ID], [password],[email], [role_ID]) VALUES (@name, @login_ID, @password,@email, @role_ID)";
        public const string updateUserByUserName = "UPDATE [dbo].[AdminUser] SET [name] = @name, [login_ID] = @login_ID, [password] = @password,[email]= @email, [role_ID] = @role_ID WHERE (([login_ID] = @Original_LoginID))";
        public const string updateUserByID = "UPDATE [dbo].[AdminUser] SET [name] = @name, [login_ID] = @login_ID, [password] = @password,[email]= @email, [role_ID] = @role_ID WHERE (([ID] = @Original_ID))";
        public const string deleteUser = "DELETE FROM [dbo].[AdminUser] WHERE (([ID] = @Original_ID))";
        public const string deleteByUsername = "DELETE FROM [dbo].[AdminUser] WHERE login_ID = @login_ID";
        public const string setCustomerStaff = "UPDATE [dbo].[AdminUser] SET [IsCustomerStaff] = @IsCustStaff WHERE ID = @ID";

        #endregion

        #region Coupon
        public const string getCoupons = "SELECT c.CouponID,c.CouponName,c.CouponCode,c.CouponDiscountAmt,c.CouponDiscountPC,c.CouponMinItemPurchase,c.CouponMaxItemPurchase,c.CouponStartdate,c.CouponExpiredate,c.CouponStatus,c.MinDollorAmt,c.CouponType,c.Maxalloweduses, (SELECT COUNT(*) FROM CustOrder WHERE CouponID = c.CouponID) AS UsageCount  FROM dbo.Coupon c  WHERE c.[ArchiveFlag] = 0 and CouponName NOT LIKE 'tra%' and CouponName NOT LIKE 't1a%' AND CouponName NOT LIKE 't1r%' ORDER BY c.[CouponID] DESC, c.[CouponName]";
        public const string getCouponByCode = "SELECT CouponName,CouponCode,CouponDiscountAmt,CouponDiscountPC,CouponMinItemPurchase,CouponMaxItemPurchase,CouponStartdate,CouponExpiredate,CouponStatus,MinDollorAmt,CouponType,Maxalloweduses  FROM dbo.Coupon WHERE [CouponCode]=@couponCode AND [ArchiveFlag] = 0";

        public const string insertCoupon = "INSERT INTO [dbo].[Coupon] ([CouponCode], [CouponName], [CouponMinItemPurchase], [CouponMaxItemPurchase], [CouponDiscountAmt]," +
            "[CouponDiscountPC], [last_update], [ArchiveFlag], [CouponStartdate], [CouponExpiredate], [CouponStatus], [Maxalloweduses]," +
            "[MinDollorAmt], [CouponType]) VALUES (@CouponCode, @CouponName, @CouponMinItemPurchase, @CouponMaxItemPurchase, @CouponDiscountAmt," +
            "@CouponDiscountPC, @last_update, 0, @CouponStartdate, @CouponExpiredate, @CouponStatus, @Maxalloweduses, " +
            "@MinDollorAmt, @CouponType)";

        public const string deleteCoupon = "DELETE FROM [dbo].[Coupon] WHERE (([CouponCode] = @code))";
        public const string archiveCoupon = "UPDATE [dbo].[Coupon] SET [ArchiveFlag] = 1 Where [CouponCode] = @code";
        public const string updateCoupon = "UPDATE [dbo].[Coupon] SET [CouponName] = @CouponName,[CouponMinItemPurchase] =@CouponMinItemPurchase, [CouponMaxItemPurchase]=@CouponMaxItemPurchase," +
            " [CouponDiscountAmt] = @CouponDiscountAmt, [CouponDiscountPC] = @CouponDiscountPC, [last_update] = @last_update, " +
            " [CouponStartdate] = @CouponStartdate, [CouponExpiredate]= @CouponExpiredate,  [Maxalloweduses]= @Maxalloweduses," +
            " [MinDollorAmt]= @MinDollorAmt, [CouponType]= @CouponType, [CouponStatus] =@CouponStatus WHERE (([CouponCode] = @CouponCode))";

        #endregion

        #region Freight Costs
        //FCID
        //WebsiteID
        //FCgeoZone
        //MaxVol
        //FreightCost
        //FCMargin
        //row_added
        //last_update
        //by_whom
        //appl_name
        //ArchiveFlag
        public const string getFreights = "SELECT FCID,MaxVol,FreightCost,FCMargin FROM dbo.FreightCost  WHERE [ArchiveFlag] = 0 ORDER BY [MaxVol]";
        public const string getFreightByID = "SELECT FCID,MaxVol,FreightCost,FCMargin FROM dbo.FreightCost  WHERE [FCID]=@FCID AND [ArchiveFlag] = 0";
        public const string insertFreight = "INSERT INTO [dbo].[FreightCost] ([MaxVol],[FreightCost],[FCMargin],[row_added],[last_update],[ArchiveFlag] )" +
            " VALUES (@MaxVol,@FreightCost,@FCMargin , GetDate(),GetDate(),0)";
        public const string deleteFreight = "DELETE FROM [dbo].[FreightCost] WHERE (([FCID] = @FCID))";
        public const string archiveFreight = "UPDATE [dbo].[FreightCost] SET [ArchiveFlag] = 1, [last_update] =GetDate() Where [FCID] = @FCID";
        public const string updateFreight = "UPDATE [dbo].[FreightCost] SET [MaxVol] = @MaxVol,[FreightCost] =@FreightCost,[FCMargin]= @FCMargin, [last_update]=GetDate() WHERE (([FCID] = @FCID))";

        #endregion

        #region Additional Costs
        //AddCostID
        //AddCostName
        //Cost
        //row_added
        //last_update
        //ArchiveFlag
        public const string getAdditionals = "SELECT AddCostID,AddCostName,Cost FROM dbo.AdditionalCost  WHERE [ArchiveFlag] = 0 ORDER BY [AddCostName]";
        public const string getAdditionalByID = "SELECT AddCostID,AddCostName,Cost FROM dbo.AdditionalCost WHERE [AddCostID]=@AddCostID AND [ArchiveFlag] = 0";
        public const string insertAdditional = "INSERT INTO [dbo].[AdditionalCost] ([AddCostName],[Cost],[row_added],[last_update],[ArchiveFlag] )" +
            "VALUES (@AddCostName,@Cost,GetDate(),GetDate(),0)";
        public const string deleteAdditional = "DELETE FROM [dbo].[AdditionalCost] WHERE (([AddCostID] = @AddCostID))";
        public const string archiveAdditional = "UPDATE [dbo].[AdditionalCost] SET [ArchiveFlag] = 1, [last_update]= GetDate() Where [AddCostID] = @AddCostID";
        public const string updateAdditional = "UPDATE [dbo].[AdditionalCost] SET [AddCostName] = @AddCostName,[Cost] =@Cost, [last_update]=GetDate() WHERE (([AddCostID] = @AddCostID))";

        #endregion

        #region Screen Print
        //PCSPID
        //WebsiteID
        //PCSPnbrSides
        //PCSPnbrInks
        //PCSPmaxVol
        //PCSPcost
        //row_added
        //last_update
        //by_whom
        //appl_name
        //ArchiveFlag
        public const string getSPInksBySide = "SELECT PCSPID,PCSPnbrSides,PCSPnbrInks,PCSPmaxVol,PCSPcost FROM dbo.PrintCostSP  WHERE [PCSPnbrSides]=@PCSPnbrSides AND [ArchiveFlag] = 0 ";
        //public const string updateScreenPrintCost = "UPDATE [dbo].[AdditionalCost] SET [AddCostName] = @AddCostName,[Cost] =@Cost, [last_update]=GetDate() WHERE (([AddCostID] = @AddCostID))";
        public const string updateSPInks = "UPDATE [dbo].[PrintCostSP] SET [PCSPcost] = @PCSPcost,[last_update]=GetDate() WHERE (([PCSPID] = @PCSPID))";
        #endregion

        #region Print Cost Fix
        //PCfixID
        //WebsiteID
        //PCfixDscr
        //PCfixCost
        //PCfixPerUnitYorN
        //PCScreenFixMargin
        //PCfixMargin
        //row_added
        //last_update
        //by_whom
        //appl_name
        //ArchiveFlag

        public const string getAllFixPC = "SELECT PCfixID,PCfixCost,PCScreenFixMargin,PCfixMargin FROM dbo.PrintCostFix  WHERE [ArchiveFlag] = 0 ";
        public const string getFixPCByID = "SELECT PCfixID,PCfixCost,PCScreenFixMargin,PCfixMargin FROM dbo.PrintCostFix WHERE [PCfixID]=@PCfixID AND [ArchiveFlag] = 0";
        //sides
        public const string getScreenPCSides = "SELECT PCfixID,PCfixCost,PCScreenFixMargin,PCfixMargin FROM dbo.PrintCostFix WHERE ([PCfixDscr]='Screen #1' OR [PCfixDscr]='Screen #2') AND [ArchiveFlag] = 0";
        public const string getDigitalPCSides = "SELECT PCfixID,PCfixMargin FROM dbo.PrintCostFix WHERE ([PCfixDscr]='Digital #1' OR [PCfixDscr]='Digital #2') AND [ArchiveFlag] = 0";
        //update
        public const string updateScreenPCFix = "UPDATE [dbo].[PrintCostFix] SET [PCfixCost] = @PCfixCost,[PCScreenFixMargin] =@PCScreenFixMargin,[PCfixMargin]=@PCfixMargin, [last_update]=GetDate() WHERE (([PCfixID] = @PCfixID))";
        public const string updateDigitalPCFix = "UPDATE [dbo].[PrintCostFix] SET [PCfixMargin]=@PCfixMargin, [last_update]=GetDate() WHERE (([PCfixID] = @PCfixID))";

        #endregion

        #region Digital Print
        //PCDGID
        //PCDGnbrSides
        //PCDGnbrInks
        //PCDGmaxVol
        //PCDGcost
        //row_added
        //last_update
        //ArchiveFlag
        public const string getDigitalInksBySide = "SELECT PCDGID,PCDGnbrSides,PCDGnbrInks,PCDGmaxVol,PCDGcost FROM dbo.PrintCostDigital  WHERE [PCDGnbrSides]=@PCDGnbrSides AND [ArchiveFlag] = 0 ";
        public const string updateDigitalInks = "UPDATE [dbo].[PrintCostDigital] SET [PCDGcost] = @PCDGcost,[last_update]=GetDate() WHERE (([PCDGID] = @PCDGID))";

        #endregion

        #region Clip Art Category Clipart-TemplateCategory

        //ClipCatID
        //ClipCatTypeCode
        //ClipCatHavCode
        //ClipCatHavSubcode
        //ClipCatDscr
        //ClipCatParentID
        //ClipCatSortOrder
        //row_added
        //last_update
        //by_whom
        //appl_name
        //ArchiveFlag

        public const string getAllClipArts = "SELECT ClipCatID,ClipCatDscr,ClipCatParentID,ClipCatSortOrder FROM [dbo].[Clipart-TemplateCategory]  WHERE ClipCatTypeCode='CART'AND [ArchiveFlag] = 0 ORDER BY [ClipCatSortOrder],[ClipCatDscr]";
        public const string getClipArtByID = "SELECT ClipCatID,ClipCatDscr,ClipCatParentID,ClipCatSortOrder FROM [dbo].[Clipart-TemplateCategory] WHERE ClipCatTypeCode='CART'AND [ClipCatID]=@ClipCatID AND [ArchiveFlag] = 0";
        public const string getSubClipArt = "SELECT  ClipCatID,ClipCatDscr,ClipCatParentID,ClipCatSortOrder FROM [dbo].[Clipart-TemplateCategory] WHERE ClipCatTypeCode='CART'AND [ClipCatParentID]=@ClipCatParentID AND [ArchiveFlag] = 0 ORDER BY [ClipCatSortOrder],[ClipCatDscr]";


        public const string insertClipArt = "INSERT INTO [dbo].[Clipart-TemplateCategory] (ClipCatTypeCode,[ClipCatDscr],[ClipCatParentID],[ClipCatSortOrder],[row_added],[last_update],[ArchiveFlag] )" +
            " VALUES ('CART',@ClipCatDscr,@ClipCatParentID,@ClipCatSortOrder , GetDate(),GetDate(),0)";

        public const string deleteClipArt = "DELETE FROM [dbo].[Clipart-TemplateCategory] WHERE [ClipCatID] = @ClipCatID";

        public const string getClipartsCountBelongToCat =
"SElECT COUNT(*) FROM dbo.ClipartTemplateClipCat  Where ArchiveFlag = 0 and ClipCatID = @CatID";

        public const string archiveClipArt = "UPDATE [dbo].[Clipart-TemplateCategory] SET [ArchiveFlag] = 1, [last_update] =GetDate() Where [ClipCatID] = @ClipCatID";
        public const string updateClipArt = "UPDATE [dbo].[Clipart-TemplateCategory] SET [ClipCatSortOrder] = @ClipCatSortOrder,[ClipCatDscr] =@ClipCatDscr,[ClipCatParentID]= @ClipCatParentID, [last_update]=GetDate() WHERE (([ClipCatID] = @ClipCatID))";

        #endregion

        #region Font

        //FontID
        //FontCatID
        //FontName
        //FontLongName
        //FontImageFile
        //FontImageServer
        //TTFfile
        //Protected
        //FontSortOrder
        //row_added
        //last_update
        //by_whom
        //appl_name
        //ArchiveFlag


        public const string getAllFonts =
            "SELECT FontID,FontCatID,(Select FontCatDscr from dbo.FontCategory  where FontCategory.FontCatID = Font.FontCatID) as FontCatName" +
",FontName, FontLongName,FontImageFile,TTFfile,FontSortOrder,ArchiveFlag FROM [dbo].[Font] ORDER BY [ArchiveFlag],[FontSortOrder],[FontName]";

        // "SELECT FontID,FontCatID as ,FontName,TTFfile,FontLongName,FontImageServer,FontSortOrder FROM [dbo].[Font]  WHERE  [ArchiveFlag] = 0 ORDER BY [FontSortOrder],[FontName]";

        public const string insertFont = "INSERT INTO [dbo].[Font] ([FontName],[FontLongName],[FontCatID],[FontImageFile],[TTFfile],[FontSortOrder],[row_added],[last_update],[ArchiveFlag] )" +
            " VALUES (@FontName,@FontLongName,@FontCatID,@FontImageFile,@TTFfile,@FontSortOrder , GetDate(),GetDate(),0)";

        public const string deleteFont = "DELETE FROM [dbo].[Font] WHERE (([FontID] = @FontID))";

        public const string archiveFont = "UPDATE [dbo].[Font] SET [ArchiveFlag] = 1, [last_update] =GetDate() Where [FontID] = @FontID";

        public const string restoreFont = "UPDATE [dbo].[Font] SET [ArchiveFlag] = 0, [last_update] =GetDate() Where [FontID] = @FontID";

        public const string updateFont = "UPDATE [dbo].[Font] SET [FontName] = @FontName,[FontLongName] = @FontLongName ,[FontCatID] = @FontCatID,[FontImageFile] =@FontImageFile,[TTFfile]= @TTFfile,[FontSortOrder]= @FontSortOrder, [last_update]=GetDate() WHERE (([FontID] = @FontID))";

        #endregion

        #region FontCategory

        //FontCatID
        //FontCatDscr
        //FontCatSortOrder
        //row_added
        //last_update
        //by_whom
        //appl_name
        //ArchiveFlag

        public const string getAllFontCats =
"SELECT FontCatID,FontCatDscr,FontCatSortOrder FROM [dbo].[FontCategory] WHERE  [ArchiveFlag] = 0 ORDER BY [FontCatSortOrder],[FontCatDscr]";

        // "SELECT FontID,FontCatID as ,FontName,TTFfile,FontLongName,FontImageServer,FontSortOrder FROM [dbo].[Font]  WHERE  [ArchiveFlag] = 0 ORDER BY [FontSortOrder],[FontName]";

        public const string insertFontCat =
            "INSERT INTO [dbo].[FontCategory] ([FontCatDscr],[FontCatSortOrder],[row_added],[last_update],[ArchiveFlag] )" +
            " VALUES (@FontCatDscr,@FontCatSortOrder,GetDate(),GetDate(),0)";

        public const string deleteFontCat =
            "DELETE FROM [dbo].[FontCategory] WHERE [FontCatID] = @FontCatID";


        public const string getFountsCountBelongsToCat =
"SElECT COUNT(*) FROM dbo.Font Where ArchiveFlag = 0 and FontCatID = @CatID";

        public const string archiveFontCat =
            "UPDATE [dbo].[FontCategory] SET [ArchiveFlag] = 1, [last_update] =GetDate() Where [FontCatID] = @FontCatID";
        public const string updateFontCat =
            "UPDATE [dbo].[FontCategory] SET [FontCatDscr] = @FontCatDscr,[FontCatSortOrder] =@FontCatSortOrder, [last_update]=GetDate() WHERE (([FontCatID] = @FontCatID))";

        #endregion

        #region Design Category Clipart-TemplateCategory (Template categories)

        //ClipCatID
        //ClipCatTypeCode
        //ClipCatHavCode
        //ClipCatHavSubcode
        //ClipCatDscr
        //ClipCatParentID
        //ClipCatSortOrder
        //row_added
        //last_update
        //by_whom
        //appl_name
        //ArchiveFlag

        public const string getAllTemplateCats = "SELECT ClipCatID,ClipCatDscr,ClipCatParentID,ClipCatSortOrder FROM [dbo].[Clipart-TemplateCategory]  WHERE ClipCatTypeCode='DART'AND [ArchiveFlag] = 0 ORDER BY [ClipCatSortOrder],[ClipCatDscr]";
        public const string getTemplateCatByID = "SELECT ClipCatID,ClipCatDscr,ClipCatParentID,ClipCatSortOrder FROM [dbo].[Clipart-TemplateCategory] WHERE ClipCatTypeCode='DART'AND [ClipCatID]=@ClipCatID AND [ArchiveFlag] = 0";
        public const string getSubTemplateCat = "SELECT  ClipCatID,ClipCatDscr,ClipCatParentID,ClipCatSortOrder FROM [dbo].[Clipart-TemplateCategory] WHERE ClipCatTypeCode='DART'AND [ClipCatParentID]=@ClipCatParentID AND [ArchiveFlag] = 0 ORDER BY [ClipCatSortOrder],[ClipCatDscr]";


        public const string insertTemplateCat = "INSERT INTO [dbo].[Clipart-TemplateCategory] (ClipCatTypeCode,[ClipCatDscr],[ClipCatParentID],[ClipCatSortOrder],[row_added],[last_update],[ArchiveFlag] )" +
            " VALUES ('DART',@ClipCatDscr,@ClipCatParentID,@ClipCatSortOrder , GetDate(),GetDate(),0)";

        public const string deleteTemplateCat = "DELETE FROM [dbo].[Clipart-TemplateCategory] WHERE (([ClipCatID] = @ClipCatID))";

        public const string archiveTemplateCat = "UPDATE [dbo].[Clipart-TemplateCategory] SET [ArchiveFlag] = 1, [last_update] =GetDate() Where [ClipCatID] = @ClipCatID";
        public const string updateTemplateCat = "UPDATE [dbo].[Clipart-TemplateCategory] SET [ClipCatSortOrder] = @ClipCatSortOrder,[ClipCatDscr] =@ClipCatDscr,[ClipCatParentID]= @ClipCatParentID, [last_update]=GetDate() WHERE (([ClipCatID] = @ClipCatID))";

        #endregion

        #region  Clipart-Template

        public const string insertClipartSP = "[dbo].[usp_Admin_Insert_ClipArtTemplate]";
        public const string insertTemplateSP = "[dbo].[usp_Admin_Insert_Template]";
        public const string updateTemplateSP = "[dbo].[usp_Admin_Update_Template]";
        public const string getTemplateSP = "[dbo].[usp_Admin_Get_Template]";
        //public const string searchClipartSP = "[dbo].[usp_Admin_Search_ClipArtTemplate_By_paging]";//not working properly based on sort order
        public const string searchClipartSP = "dbo.usp_Admin_Paged_Search_ClipArtTemplate";


        public const string getClipartByIDSP = "[dbo].[usp_Admin_Get_ClipArt_By_ID]";
        public const string editClipartByIDSP = "[dbo].[usp_Admin_Edit_ClipArtTemplate]";
        public const string archiveClipartByIDSP = "[dbo].[usp_Admin_Archive_ClipArtTemplate]";
        public const string UpdateClipartCatsSP = "[dbo].[usp_Admin_Update_ClipArtTemplate_Cats]";
        #endregion

        #region Paging for any table or view
        //@TableOrView = N'ClipartTemplate',
        //@Columns = N'*',-- N'x,y,z'
        //@OrderByColumn = N'ClipartName',
        //@OrderByDirection = N'ASC',
        //@SelectedPage = 2,
        //@PageSize = 3,
        //@WhereClause = "archiveflag=0 and cliparttypecode='C'"
        //public const string selectDataByPagingSP = "[dbo].[usp_Admin_Get_Data_Page]";//works just with sorting on identity column

        public const string selectDataByPagingSP2 = "[dbo].[usp_Admin_Get_Paged_Data]";//works with any sorting



        #endregion

        #region Featured template and featured banner
        //child sub cat template click
        public const string InsertFeaturedTemplate = "[dbo].[usp_Admin_Insert_FeaturedTemplate]";//its featured banner table 
        //"INSERT INTO [dbo].[FeaturedTemplate]([ImageName],[ImageFile],[FeaturedCategoryID],[ClipCatID],[ClipSubCatID],[ClipartID],[row_added],[last_update],[isBanner])   VALUES"+
        //"(<@ImageName, varchar(250),>,<@ImageFile, varchar(250),>,<@FeaturedCategoryID, int,> ,<@ClipCatID, int,>,<@ClipSubCatID, int,>,<@ClipartID, int,>,<GetDate(), datetime,>,<GetDate(), datetime,>"+
        //   ",<'N', char(1),>)";

        //child sub cat template click
        public const string SelectFeaturedTemplates =
            "SELECT mapper.[ClipartClipCatID] ,mapper.[FeaturedDesign],C.[ClipartName],C.[ClipartRasterPath]  FROM [dbo].[ClipartTemplateClipCat]  as mapper inner join ClipartTemplate as C on " +
            "C.ClipartID = mapper.ClipartID where mapper.[ArchiveFlag] = 0 and C.[ArchiveFlag] = 0 and mapper.ClipCatID = @ClipCatID order by [FeaturedDesign] desc";

        //parent cat click for selecting a banner
        public const string SelectFeaturedBanner =
            "SELECT [FeaturedTemplateID],[ImageName],[ImageFile],[ClipCatID],[ClipSubCatID],[ClipartID],[isDefaultCatgeoryBanner] FROM [dbo].[FeaturedTemplate] where [ClipCatID] = @parentID";
        //"SELECT ft.[FeaturedTemplateID],ft.[ImageName],ft.[ImageFile],ft.[ClipCatID],ft.[ClipSubCatID],ft.[ClipartID],ft.[isDefaultCatgeoryBanner]" +
        //"FROM [dbo].[FeaturedTemplate] as ft	inner join [dbo].[Clipart-TemplateCategory] as c on ft.[ClipCatID] = c.[ClipCatID]" +
        //"where c.[ClipCatParentID] = @parentID";
        //radio button for one of featured banner is selected and save clicked 
        public const string setDefaultFeaturedBannerYes =
    "Update [dbo].[FeaturedTemplate] SET [isDefaultCatgeoryBanner] =@isDefaultCatgeoryBanner  ,[last_update]=GetDate()  where [FeaturedTemplateID] = @FeaturedTemplateID";

        public const string GetFeaturedBannerByTemplateCatID =
 "SELECT     FeaturedTemplateID, ImageName, ImageFile,isDefaultCatgeoryBanner FROM FeaturedTemplate where  isBanner = 'Y' and ClipSubCatID = @tempCatID";


        //parent cat select template click
        public const string SelectFeaturedYesTemplates = "[dbo].[usp_Admin_Get_Featured_Templates]";
        //"SELECT C.[ClipartID,ct.[ClipartClipCatID] ,ct.[FeaturedDesign],C.[ClipartName],C.[ClipartRasterPath]  " +
        //"FROM [dbo].[ClipartTemplateClipCat]  as ct inner join ClipartTemplate as C on C.ClipartID = ct.ClipartID where ct.[ArchiveFlag] = 0 and ct.[FeaturedDesign] = 'Y' 	and ct.ClipCatID in (select [ClipCatID] as id from [dbo].[Clipart-TemplateCategory] where  ClipCatParentID = @ClipCatID and [ArchiveFlag] = 0 )";

        public const string SetFeaturedTemplate = "[dbo].[usp_Admin_Set_FeaturedTemplate]";//its assigning the featured template



        #endregion

        #region Vendors
        //CompanyID	    int	            Unchecked
        //VendorName	varchar(250)	Unchecked
        //VendorAcctNo	varchar(20)	    Checked
        //VendorPhone	varchar(50)	    Checked
        //VendorFax	    varchar(50)	    Checked
        //VendorEmail	varchar(250)	Checked
        //VendorWebsite	varchar(300)	Checked
        //websitelogin	varchar(100)	Checked
        //password	    varchar(100)	Checked
        //row_added	    datetime	    Unchecked
        //last_update	datetime	    Unchecked
        //ArchiveFlag	bit	            Unchecked

        public const string getVendors = "SELECT CompanyID,VendorName,VendorAcctNo,VendorPhone,VendorFax,VendorEmail,VendorWebsite,websitelogin,password FROM dbo.Vendor  WHERE [ArchiveFlag] = 0 ORDER BY [VendorName]";
        public const string getVendorByCode =
            "SELECT CompanyID,VendorName,VendorAcctNo,VendorPhone,VendorFax,VendorEmail,VendorWebsite,websitelogin,password FROM dbo.Vendor  WHERE [ArchiveFlag] = 0 and CompanyID= @CompanyID ORDER BY [VendorName]";

        public const string insertVendor =
            "INSERT INTO [dbo].[Vendor] (VendorName,VendorAcctNo,VendorPhone,VendorFax,VendorEmail,VendorWebsite,ArchiveFlag)" +
            "VALUES (@VendorName, @VendorAcctNo, @VendorPhone, @VendorFax, @VendorEmail, @VendorWebsite, 0 )";

        public const string deleteVendor = "DELETE FROM [dbo].[Vendor] WHERE (([CompanyID] = @CompanyID))";
        public const string archiveVendor = "UPDATE [dbo].[Vendor] SET [ArchiveFlag] = 1 Where [CompanyID] = @CompanyID";

        public const string updateVendor =
            "UPDATE [dbo].[Vendor] SET [VendorName] = @VendorName,[VendorAcctNo] =@VendorAcctNo, [VendorPhone]=@VendorPhone," +
            "[VendorFax] = @VendorFax, [VendorEmail] = @VendorEmail,[VendorWebsite] = @VendorWebsite,  [last_update] = GetDate() " +
            "WHERE (([CompanyID] = @CompanyID))";

        public const string updateVendorWebsite =
    "UPDATE [dbo].[Vendor] SET [websitelogin] = @websitelogin,[password] =@password,  [last_update] = GetDate() WHERE (([CompanyID] = @CompanyID))";

        #endregion

        #region Manufacturer

        public const string getManuFacturersNameID =
"SELECT companyID AS ID,ManufName AS [Name] FROM   dbo.Manufacturer WHERE (ArchiveFlag = 0) order by ManufSortOrder ";


        public const string getManuFacturers =
"SELECT m.CompanyID AS ID,m.ManufName AS [Name],m.AcctNo AS [AccNum],m.ManufSortOrder AS [Order], dbo.Concatenate(v.VendorName) AS [Vendors]" +
"FROM   dbo.Manufacturer AS m LEFT OUTER JOIN    dbo.ManufacturerVendor AS mv ON m.CompanyID = mv.CompanyID LEFT OUTER JOIN dbo.Vendor AS v " +
"ON mv.VenCompanyID = v.CompanyID WHERE     (m.ArchiveFlag = 0) GROUP BY m.CompanyID,m.ManufName,m.ManufSortOrder,m.AcctNo  order by m.ManufSortOrder";

        public const string getManuFacturerVendorsByID =
 "select mv.ManufVendorID,mv.PrimaryVendor,v.CompanyID ,v.VendorName from dbo.ManufacturerVendor mv inner join dbo.Vendor as v on mv.VenCompanyID = v.CompanyID where mv.CompanyID = @ManuID and mv.ArchiveFlag = 0";

        //public const string getManuFacturerDefaultVendor =
        //"select VenCompanyID from dbo.ManufacturerVendor where ArchiveFlag = 0 and CompanyID=@CompanyID and PrimaryVendor = 'Y' ";
        public const string insertManufacturer = "[dbo].[usp_Admin_Insert_Manufacturer]";

        // public const string deleteManufacturer = "DELETE FROM [dbo].[Manufacturer] WHERE (([CompanyID] = @CompanyID))";
        // public const string deleteManuVen = "DELETE FROM [dbo].[ManufacturerVendor] WHERE (([CompanyID] = @CompanyID))";
        public const string archiveManufacturer = "UPDATE [dbo].[Manufacturer] SET [ArchiveFlag] = 1 Where [CompanyID] = @CompanyID";
        public const string archiveManuVen = "UPDATE [dbo].[ManufacturerVendor] SET [ArchiveFlag] = 1 Where [CompanyID] = @CompanyID";

        public const string updateManufacturer =
 "UPDATE [dbo].[Manufacturer]  SET	[ManufName] = @ManufName, [ManufSortOrder] = @ManufSortOrder,[last_update] = GETDATE() WHERE CompanyID = @CompanyID";

        //-----------------------------------------------------------------------------ManuColor ColorcatID = 5 for all Manufacturer color 
        public const string getManufacturerColors =
"SELECT [ColorID],[CompanyID],[ColorName],[ColorSwatchFile],[ColorSortOrder],[colorshade]" +
" FROM [dbo].[Color] where [ArchiveFlag] = 0 and [CompanyID] = @CompanyID order by ColorSortOrder,ColorName";

        public const string archiveManufactColor =
            "UPDATE [dbo].[Color] SET [ArchiveFlag] = 1, [last_update]=GETDATE() Where [ColorID] = @ColorID";

        public const string archiveManufactProductColor =
            "UPDATE [dbo].[ProductColors] SET [ArchiveFlag] = 1 Where [ColorID] = @ColorID";

        public const string updateManufactColor =
 "UPDATE [dbo].[Color]  SET	[ColorName] = @ColorName, [colorshade] = @colorshade,[ColorSortOrder] = @ColorSortOrder, [ColorSwatchFile] = @ColorSwatchFile,[last_update] = GETDATE() WHERE  ColorID= @ColorID";

        public const string insertManufactColor =
"INSERT INTO [dbo].[Color] (CompanyID,ColorName, ColorcatID,colorshade,ColorSortOrder,ColorSwatchFile,ArchiveFlag)" +
"VALUES (@CompanyID, @ColorName,@ColorcatID, @colorshade, @ColorSortOrder, @ColorSwatchFile, 0 )";

        public const string getColorShades = "SELECT [colorname]  FROM [dbo].[ColorShade]";
        #endregion

        #region Product Category
        //ProdCatID	        int	        Unchecked
        //ProdCatDscr	    varchar(40)	Unchecked
        //ProdCatParentID	int	        Checked
        //ProdCatSortOrder	smallint	Unchecked
        //row_added	        datetime	Unchecked
        //last_update	    datetime	Unchecked
        //ArchiveFlag	    bit	        Unchecked

        public const string getAllProductsCats =
"SELECT  ProdCatID, ProdCatDscr, ProdCatParentID, ProdCatSortOrder FROM   dbo.ProductCategory WHERE [ArchiveFlag] = 0 ORDER BY [ProdCatSortOrder],[ProdCatDscr]";
        //        public const string getProductCatByID = "SELECT ClipCatID,ClipCatDscr,ClipCatParentID,ClipCatSortOrder FROM [dbo].[Clipart-TemplateCategory] WHERE ClipCatTypeCode='CART'AND [ClipCatID]=@ClipCatID AND [ArchiveFlag] = 0";
        //        public const string getSubCatProducts = "SELECT  ClipCatID,ClipCatDscr,ClipCatParentID,ClipCatSortOrder FROM [dbo].[Clipart-TemplateCategory] WHERE ClipCatTypeCode='CART'AND [ClipCatParentID]=@ClipCatParentID AND [ArchiveFlag] = 0 ORDER BY [ClipCatSortOrder],[ClipCatDscr]";

        public const string insertProductCat =
"INSERT INTO [dbo].[ProductCategory] ([ProdCatDscr],[ProdCatParentID],[ProdCatSortOrder],[row_added],[last_update],[ArchiveFlag] )" +
            " VALUES (@ProdCatDscr,@ProdCatParentID,@ProdCatSortOrder , GetDate(),GetDate(),0)";

        public const string deleteProductCat =
"DELETE FROM [dbo].[ProductCategory] WHERE (([ProdCatID] = @ProdCatID))";

        public const string archiveProductCat =
"UPDATE [dbo].[ProductCategory] SET [ArchiveFlag] = 1, [last_update] =GetDate() Where [ProdCatID] = @ProdCatID";

        public const string getProductsCountBelongToCat =
"SElECT COUNT(*) FROM dbo.ProductProdCat Where ArchiveFlag = 0 and ProdCatID = @CatID";

        public const string updateProductCat =
"UPDATE [dbo].[ProductCategory] SET [ProdCatSortOrder] = @ProdCatSortOrder,[ProdCatDscr] =@ProdCatDscr,[ProdCatParentID]= @ProdCatParentID, [last_update]=GetDate() WHERE (([ProdCatID] = @ProdCatID))";

        #endregion

        #region Products
        public const string getAllProductsSP = "[dbo].[usp_Admin_Get_Products]";
        //public const string deleteProduct = "DELETE FROM dbo.Product  WHERE (([ProdID] = @ProdID))";
        //public const string archiveProduct = "UPDATE dbo.Product  SET [ArchiveFlag] = 1 Where [ProdID] = @ProdID";
        public const string archiveProduct = "[dbo].[usp_Admin_Archive_Product_By_ID]";

        //------------Product Colors

        public const string productInsertUpdateSP = "[dbo].[usp_Admin_Insert_Update_Product2]";
        public const string getProductByIDSP = "[dbo].[usp_Admin_Get_Product_By_ID2]";

        public const string getProdValues =
       "SELECT ltrim(rtrim([ProdValueCode]))+' - '+ rtrim(ltrim([ProdValueDscr])) As [txt],ProdValueCode as [value]  FROM [dbo].[ProdValue] where ArchiveFlag= 0 order by ProdValueSortOrder";

        public const string getProdWeights =
        "SELECT [WeightType] as weight FROM [dbo].[ProductWeight] order by [priority]";

        public const string getProdFabric =
        "SELECT [Fabrictype] as fabric FROM [dbo].[ProductFabric] order by [priority]";


        //assign cats to product
        public const string getProdCatIDs =
        "SELECT pc.ProdCatID AS CatID FROM dbo.Product AS p left join dbo.ProductProdCat  AS pc" +
        " on p.ProdID = pc.ProdID left outer join dbo.ProductCategory AS c on pc.ProdCatID = c.ProdCatID " +
        "WHERE  p.ArchiveFlag = 0 and c.ArchiveFlag = 0 and pc.ArchiveFlag = 0 and p.ProdID = @ProdID ";

        public const string updateProductCatsSP = "[dbo].[usp_Admin_Update_Product_Cats]";

        public const string getProductColors =
"SELECT c.[ColorID],c.[CompanyID],c.[ColorName],(Select ProdColorID  From dbo.ProductColors where  ProdID = @ProdID and  ColorID = c.ColorID and archiveflag = 0) as IsSelectedProdColorID, " +
"(Select ManufName From dbo.Manufacturer where CompanyID = (Select CompanyID from dbo.Product where ProdID = @ProdID)) AS Manufacturer FROM [dbo].[Color] as c " +
"where c.[ArchiveFlag] = 0 and c.[CompanyID] = (Select CompanyID from dbo.Product where ProdID = @ProdID) order by IsSelectedProdColorID DESC,c.ColorSortOrder,c.ColorName";

        public const string getProdSelectedColors =
"SELECT p.ProdColorID,p.ColorID,(Select ManufName From dbo.Manufacturer where CompanyID = (Select CompanyID from dbo.Product where ProdID = @ProdID)) AS Manufacturer , (Select [ColorName] From dbo.[Color] where ColorID = p.ColorID) AS [ColorName] " +
 "from ProductColors p where p.archiveflag = 0 and p.ProdID = @ProdID ";


        public const string updateProductColorsSP = "[dbo].[usp_Admin_Update_Product_Colors]";


        //product Color : assign front back image 
        public const string getFrontBackImg =
"select top 1 ProdImageID,ProdImageFile from dbo.ProductPix where prodId = @prodId and ProdColorID = @ProdColorID and ProdPixCode = @ProdPixCode and archiveflag = 0 order by last_update DESC";
        public const string updateFrontBackImg =
"UPDATE [dbo].[ProductPix] SET ProdImageFile = @ProdImageFile ,last_update = GETDATE() WHERE  ProdImageID = @ProdImageID";
        public const string insertFrontBackImg =
"INSERT INTO [dbo].[ProductPix]([ProdID],[ProdColorID],[ProdImageName],[ProdImageFile],[ProdPixCode],[ArchiveFlag],[row_added],[last_update])" +
" VALUES (@ProdID ,@ProdColorID  ,@ProdImageName ,@ProdImageFile, @ProdPixCode,0 ,GETDATE(),GETDATE()) ";



        //product Size and Prices
        public const string getProductDetailsByProdID =
"select ProdDetailID,ProdID,ColorID,ProdColorID,SizeTypeCode from productdetail where prodid = @ProdId and ArchiveFlag = 0";

        public const string getProductSizePrices =
"Select st.SizeTypeName , st.SizeTypeDscr,st.SizeTypeCode , " +
"(Select ProdDetailID from dbo.ProductDetail as p where p.ProdID = @prodid and p.ProdColorID =  @ProdColorID and  st.SizeTypeCode=p.SizeTypeCode  and p.archiveflag = 0) as ProdDetailID, " +
"(Select ProdDetailPrice from dbo.ProductDetail as p where p.ProdID = @prodid and p.ProdColorID =  @ProdColorID and  st.SizeTypeCode=p.SizeTypeCode  and p.archiveflag = 0) as RegularPrice, " +
"(Select ProdDetailSalePrice from dbo.ProductDetail as p where p.ProdID = @prodid and p.ProdColorID= @ProdColorID and  st.SizeTypeCode=p.SizeTypeCode  and p.archiveflag = 0 ) as DiscountedPrice, " +
"(Select ProdDetailAvailable from dbo.ProductDetail as p where p.ProdID = @prodid and p.ProdColorID= @ProdColorID and  st.SizeTypeCode=p.SizeTypeCode  and p.archiveflag = 0 ) as Available " +
"from dbo.sizetype as st where st.archiveflag = 0 order by SizeSortOrder";

        public const string updateProductSizePrices =
"UPDATE [dbo].[ProductDetail]  SET [ProdID] = @ProdID ,[ColorID] = @ColorID ,[ProdColorID] = @ProdColorID  ,[SizeTypeCode] = @SizeTypeCode,[ProdDetailPrice] = @ProdDetailPrice " +
",[ProdDetailSalePrice] = @ProdDetailSalePrice ,[ProdDetailAvailable] = @ProdDetailAvailable ,[last_update] = GETDATE() WHERE ProdDetailID = @ProdDetailID";

        public const string insertProductSizePrices =
"INSERT INTO [dbo].[ProductDetail] ([ProdID],[ColorID] ,[ProdColorID] ,[SizeTypeCode], [ProdDetailPrice] ,[ProdDetailSalePrice]  ,[ProdDetailAvailable]" +
" ,[ProdDetailSortOrder],[ArchiveFlag],[row_added],[last_update]) VALUES " +
"(@ProdID ,@ColorID,@ProdColorID ,@SizeTypeCode ,@ProdDetailPrice ,@ProdDetailSalePrice ,@ProdDetailAvailable ,999 ,0 ,GETDATE()  ,GETDATE())";

        public const string deleteProductSizePrices =
"DELETE FROM [dbo].[ProductDetail] WHERE [ProdID] = @ProdID and [ColorID] = @ColorID and [ProdColorID] = @ProdColorID  and [SizeTypeCode] = @SizeTypeCode and [ProdDetailID] = @ProdDetailID";

        //Product Cat assign Image
        public const string getProductCatImgs =
"SELECT [FeaturedProductID],[ImageName],[ImageFile],[FeaturedCategoryID],[ProdCatID],[DefaultFeaturedImage],[ProdPixCodeOrder] " +
"FROM [dbo].[FeaturedProduct] Where ProdCatID = @ProdCatID";

        public const string insertProductCatImgs =
"INSERT INTO [dbo].[FeaturedProduct] ([ImageName],[ImageFile],[FeaturedCategoryID],[ProdCatID],[ProdSubCatID],[ProdID],[row_added],[last_update],[DefaultFeaturedImage],[isBanner],[ProdPixCodeOrder]) " +
"VALUES(@ImageName,@ImageFile,@FeaturedCategoryID,@ProdCatID,@ProdSubCatID,@ProdID,GetDate(),GetDate(),@DefaultFeaturedImage,@isBanner,@ProdPixCodeOrder) ";
        public const string updateProductCatImgs =
"UPDATE [dbo].[FeaturedProduct] SET [ImageName] = @ImageName,[ImageFile] = @ImageFile,[DefaultFeaturedImage] = @DefaultFeaturedImage " +
",[last_update] = GetDAte() WHERE [FeaturedProductID] = @FeaturedProductID";
        #endregion

        #region Templates Browser

        public const string getTemplatesForACategory =
            "SELECT t.ClipartClipCatID,c.ClipartID,c.ClipartName as [Name] ,ClipartRasterPath as Img ,DefaultCategory ,FeaturedDesign  FROM dbo.[ClipartTemplateClipCat]  as t inner join dbo.ClipartTemplate c on c.ClipartID = t.ClipartID " +
            " where [ClipCatID] = @ClipCatID and c.ClipartTypeCode = @type and c.ArchiveFlag = 0 and t.ArchiveFlag = 0 order by FeaturedDesign DESC, c.ClipartSortOrder,c.ClipartName";
        //old select 
        //"SELECT [ClipartClipCatID] ,[ClipartID] ,(Select top 1 ClipartName from dbo.ClipartTemplate where ClipartID = t.ClipartID) as Name " +
        //",(Select top 1 ClipartRasterPath from dbo.ClipartTemplate where ClipartID = t.ClipartID) as Img  ,[DefaultCategory] ,[FeaturedDesign] " +
        // " FROM [dbo].[ClipartTemplateClipCat]  as t where [ClipCatID] = @ClipCatID and [ArchiveFlag] = 0";

        #endregion

        #region Vendor Confirmation

        public const string getVendorConfsByOrderID =
"SELECT [VendorConfID] ,[VenCompanyID],(select VendorName from dbo.Vendor where CompanyID = v.VenCompanyID) as VendorName , [ConfNo],[ConfNotes],[Status] FROM [dbo].[VendorConfirmation] as v where [OrderID] = @OrderID ";

        public const string getVendorConfByID =
"SELECT [VendorConfID] ,[VenCompanyID],(select VendorName from dbo.Vendor where CompanyID = v.VenCompanyID) as VendorName , [ConfNo],[ConfNotes],[Status] FROM [dbo].[VendorConfirmation] as v where [VendorConfID] = @VendorConfID ";


        public const string getVendorsNameID = "SELECT CompanyID,VendorName FROM dbo.Vendor  WHERE [ArchiveFlag] = 0 ORDER BY [VendorName]";

        public const string insertVendorConf =
"INSERT INTO [dbo].[VendorConfirmation] ([OrderID],[VenCompanyID],[ConfNo],[ConfNotes],[Status],[row_added],[last_update]) " +
"OUTPUT Inserted.VendorConfID " +
"VALUES (@OrderID,@VenCompanyID,@ConfNo ,@ConfNotes,@Status,GetDate(),GetDate())";

        /*    public const string updateOrderProduction =
    "UPDATE dbo.OrderProduction SET OrderProdDscr = 'Check-in Due '+ convert(varchar, (select OrderDate+1 from dbo.CustOrder where OrderID = @OrderID ), 101) ,OrderProdStatusDate= getDate()  WHERE OrderID = @OrderID AND ProdStatusCode = 'N'";
    */
        //updating orderproduction table status @status='Check-in Due'+'08/14/2010'===>Due date should be (nextday of entering vendorconf)

        public const string updateOrderProduction =
"UPDATE dbo.OrderProduction SET OrderProdDscr = 'Check-in Due '+ convert(varchar, getDate()+1, 101) ,OrderProdStatusDate= getDate()  WHERE OrderID = @OrderID AND ProdStatusCode = 'N'";


        public const string deleteVendorConf =
"Delete from [dbo].[VendorConfirmation]  where [VendorConfID] = @VendorConfID";

        public const string updateVendorConf =
"UPDATE [dbo].[VendorConfirmation]  SET [VenCompanyID] = @VenCompanyID,[ConfNo] = @ConfNo,[ConfNotes] = @ConfNotes,[last_update] = getdate() WHERE [VendorConfID] = @VendorConfID";

        public const string getVendorConfProdInfoSP = "[dbo].[usp_Admin_Get_VendorConf_Prod_Info]";
        #endregion

        #region OrderIssues
        public const string insertOrderIssue =
"INSERT INTO [dbo].[CustOrderIssues] ([OrderID],[CustEmail],[CustName],[Issuecategory],[IssueSummary],[IssueDetailDesc],[status],[IssuereportDate],[last_update],[CustomerStaff],[ResolveOrderID],[ResloutionNote],[OrderAmount],[Severity],[NumShirts],[Printer],[Printed],[SignedOff],[QC] )" +
" VALUES (@OrderID, @CustEmail,@CustName,@Issuecategory,@IssueSummary,@IssueDetailDesc,@status,@IssuereportDate ,GetDate(),@CustomerStaff ,@ResolveOrderID ,@ResloutionNote ,@OrderAmount,@Severity ,@NumShirts, @Printer, @Printed, @SignedOff, @QC)";

        public const string getLastInsertedIssueID = "SELECT MAX(OrderIssueID) AS LastID FROM dbo.CustorderIssues";


        public const string updateOrderIssue =
"UPDATE [dbo].[CustOrderIssues] SET [OrderID] = @OrderID,[CustEmail] = @CustEmail,[CustName] = @CustName, [NumShirts] = @NumShirts, [Issuecategory] = @Issuecategory,[IssueSummary] = @IssueSummary, [Printer] = @Printer, [Printed] = @Printed, [SignedOff] = @SignedOff, [QC] = @QC " +
" ,[IssueDetailDesc] = @IssueDetailDesc,[status] = @status ,[IssuereportDate] = @IssuereportDate ,[last_update] = GetDate(),[CustomerStaff] = @CustomerStaff  ,[ResolveOrderID] = @ResolveOrderID,[ResloutionNote] = @ResloutionNote,[OrderAmount] = @OrderAmount,[Severity] = @Severity" +
" WHERE OrderIssueID = @OrderIssueID";

        public const string deleteOrderIssue =
"Delete from [dbo].[CustOrderIssues]  WHERE OrderIssueID = @OrderIssueID";

        public const string getOrderIssueByID =
"Select * from [dbo].[CustOrderIssues]  WHERE OrderIssueID = @OrderIssueID";

        //----------------------------search order issue
        public const string getOrderIssueByOrderID =
"Select * from [dbo].[CustOrderIssues]  WHERE OrderID = @OrderID order by IssuereportDate DESC";

        public const string getOrderIssueByEmail =
"Select * from [dbo].[CustOrderIssues]  WHERE CustEmail Like '%'+ @CustEmail+'%' order by IssuereportDate DESC";

        public const string getOrderIssueByIssueSummary =
"Select * from [dbo].[CustOrderIssues]  WHERE IssueSummary Like '%'+@IssueSummary+'%' order by IssuereportDate DESC";


        public const string getOrderIssueByOrderDate = "[dbo].[usp_Admin_Get_Order_Issues_By_Order_Date]";
        //----------------------------search order issue

        public const string getOrderIssues =
"Select * from [dbo].[CustOrderIssues] order by IssuereportDate DESC";
        public const string getStaff =
        "SELECT [name],[email]  FROM [dbo].[AdminUser] where [IsCustomerStaff] = N'Y'";

        #endregion

        #region Approve PO/Check
        public const string getOrderApproveInfo =
"Select c.PaymentMethod,c.OrderGrandTotal,p.PayStatus ,p.PayDetailID,p.Paynotes, c.PayTransno, s.BillAddrCountry,s.BillAddrPostalCode,s.BillAddrStateCode,s.BillAddrCity, s.BillAddrPOBox, s.BillAddrStreet " +
",s.POChkNum,s.BillName,s.BillCompany,s.BillPhone,s.BillFax,s.BillEmailAddress from dbo.CustOrder c left outer join dbo.CustOrderShipBillInfo s on c.OrderID=s.OrderID left outer join dbo.PaymentDetail p on c.shopcartId=p.shopCartID where c.OrderID = @OrderID and c.archiveflag = 0 and  c.Orderdate is not null ";

        public const string updateOrderApproveInfo =
        "dbo.[usp_Admin_Update_Order_Approve]";
        //"Update dbo.PaymentDetail SET PayStatus = @PayStatus, Paynotes= @Paynotes where PayDetailID= @PayDetailID ";
        public const string Admin_Order_OnHold = "dbo.[usp_Admin_Order_OnHold]";



        #endregion

        #region  Customer Interactions

        public const string getCustInterActs = "SELECT *  FROM [dbo].[CustomerInteraction] order by ContactDate DESC";
        public const string getCustInterActsByOrderID = "SELECT *  FROM [dbo].[CustomerInteraction] where OrderID = @OrderID order by ContactDate DESC";
        public const string getCustInterActsByMail = "SELECT *  FROM [dbo].[CustomerInteraction] where CustEmail Like '%'+ @CustEmail+'%' order by ContactDate DESC";
        public const string getCustInterActsByCustName = "SELECT *  FROM [dbo].[CustomerInteraction] where CustomerName Like '%'+ @CustName+'%' order by ContactDate DESC";

        public const string getCustInterActsByOrderDate = "[dbo].[usp_Admin_Get_Cust_InterAct_By_Order_Date]";
        public const string getCustInterActsByContactDate = "[dbo].[usp_Admin_Get_Cust_InterAct_By_Contact_Date]";

        public const string getCustInterActsByID = "SELECT *  FROM [dbo].[CustomerInteraction] where [CustomerInteractionID] = @ID";

        public const string insertCustInterActs =
"INSERT INTO [dbo].[CustomerInteraction]([ContactMethod],[CustStaff],[CustEmail],[ContactReasonType],[OrderID],[CustomerName] ,[ContactPhone],[Comments] ,[CustMessage],[Action],[ContactDate],[last_update],[DesignID],[by_whom]) " +
"VALUES (@ContactMethod,@CustStaff,@CustEmail,@ContactReasonType,@OrderID,@CustomerName,@ContactPhone,@Comments,@CustMessage,@Action,@ContactDate, GetDate(),@DesignID,@ByWhom);SELECT @@IDENTITY";

        public const string deleteCustInterActs =
"Delete  FROM [dbo].[CustomerInteraction] where [CustomerInteractionID] = @ID";

        public const string updateCustInterActs =
"UPDATE [dbo].[CustomerInteraction] SET [ContactMethod] = @ContactMethod,[CustStaff] = @CustStaff,[CustEmail] = @CustEmail ,[ContactReasonType] = @ContactReasonType,[OrderID] = @OrderID ,[CustomerName] = @CustomerName ,[ContactPhone] = @ContactPhone ,[Comments] = @Comments ,[CustMessage] = @CustMessage ,[Action] = @Action ,[ContactDate] = @ContactDate ,[last_update] = GetDate(),[DesignID] = @DesignID WHERE [CustomerInteractionID] = @ID";
        #endregion

        #region Goods Checkin

        public const string getGoodsCheckinByOrderID =
"SELECT (select ltrim(rtrim((Select ltrim(rtrim(ManufName)) from  dbo.Manufacturer where p.CompanyID = companyID )+' '+p.ProdName +' '+ p.ProdManufCode)) from dbo.product as p where p.ProdID = ol.ProdID and p.archiveflag = 0) as ProdName" +
" ,co.ProdTypeCode,(select ColorName from dbo.color where colorid =  ol.OrderLineColorID and archiveflag = 0) as color ,(select ltrim(rtrim(SizeTypeName)) from dbo.SizeType where SizeTypeCode = ol.OrderLineSizeTypeCode) as size, ol.OrderLineQuantity as Qty " +
" ,co.OrderDate ,co.ShippingDate,co.ExpectedDeliveryDate,co.ActualDeliveryDate,co.SubstituteProductNotes " +
",(Select OrderProdDscr from dbo.OrderProduction where Prodstatuscode='N' and OrderProdActivated='Y' and OrderID =   @OrderID) as GoodStatus " +
",(Select OrderProdnotes from dbo.OrderProduction where Prodstatuscode='N' and OrderProdActivated='Y' and OrderID =  @OrderID) as GoodsProblemNotes " +
",(Select OrderProdID from dbo.OrderProduction where Prodstatuscode='N' and OrderProdActivated='Y' and OrderID =  @OrderID) as OrderProdID " +
" FROM [dbo].[CustOrder] co inner join dbo.OrderLine ol on co.[OrderID] = ol.[OrderID] where co.[OrderID] =  @OrderID";//co.[ArchiveFlag] = 0 

        public const string getGoodsVendorConfByID =
"SELECT [VendorConfID],(select VendorName from dbo.vendor where companyID = [VenCompanyID]) as vendor,[OrderID],[ConfNo],[ConfNotes],[Status] FROM [dbo].[VendorConfirmation] where orderid = @orderid";

        public const string getGoodsVendorConfByConfID =
"SELECT [VendorConfID],(select VendorName from dbo.vendor where companyID = [VenCompanyID]) as vendor,[OrderID],[ConfNo],[ConfNotes],[Status] FROM [dbo].[VendorConfirmation] WHERE ConfNo = @ConfNo";

        public const string findGoodsVendorConfByConfID =
"SELECT [VendorConfID],(select VendorName from dbo.vendor where companyID = [VenCompanyID]) as vendor,[OrderID],[ConfNo],[ConfNotes],[Status] FROM [dbo].[VendorConfirmation] WHERE ConfNo like '%' + @ConfNo + '%'";

        public const string updateGoodsCheckinProbInProd =
"update dbo.OrderProduction SET OrderProdNotes =@OrderProdNotes,last_update = GETDATE() where OrderProdID =  @OrderProdID";

        public const string updateGoodsCheckinVendorConfs =
            "[dbo].[usp_Admin_Update_Goods_Checkin_Confs]";

        #endregion

        #region Report Production Problem (CustOrder table)
        public const string updateCustOrderProdProblemNotes =
       "UPDATE [dbo].[CustOrder] SET [last_update]=GETDATE(),[OrderProblemNotes] = @OrderProblemNotes WHERE OrderID = @OrderID and ArchiveFlag = 0 and OrderDate is not null";
        public const string getCustOrderProdProblemNotes =
"SELECT OrderProblemNotes from [dbo].[CustOrder] WHERE OrderID = @OrderID and ArchiveFlag = 0 and OrderDate is not null";

        #endregion

        #region Order Category
        public const string getOrderCategories =
        "SELECT (Select top 1 DesignName from dbo.Design as d  inner join dbo.orderline as ol on d.DesignID = ol.DesignID where ol.orderID = @OrderID) as Design,[OrderCategoryId],[ClipCatParentID],[ClipSubCatID],[CategoryName],[last_update] FROM [dbo].[OrderCategory] where [OrderID] = @OrderID;Select top 1 DesignName from dbo.Design as d  inner join dbo.orderline as ol on d.DesignID = ol.DesignID where ol.orderID =@OrderID";

        public const string UpdateOrderCatsSP = "[dbo].[usp_Admin_Update_Order_Categories]";
        #endregion

        #region Print Label
        public const string getPintLabel = "[dbo].[usp_Admin_Get_Print_label_Info]";
        #endregion

        #region Do Shipment
        public const string getShippingCompanies = "SELECT [ShipperName] FROM [dbo].[ShippingCompany] where [ArchiveFlag] = 0 order by [ShipCoFavorite] DESC";
        public const string getShippingInfo = "SELECT (select top 1 TrackingUrl from ShippingCompany c where	ShipCarrier = c.ShipperName)  + Trackingno as TrackURL,OrderShipmentID,ShipMethod,ShipCarrier,Trackingno,ShipDate,ShipmentStatus,AdminInternalShipNotes FROM dbo.OrderShipment where OrderID = @OrderID";
        public const string getCustOrderShipInfo =
         "SELECT dbo.Get_Production_Status_Name (CustOrderStatus)  AS Status , ShippingDate FROM dbo.CustOrder WHERE OrderDate	IS NOT NULL AND ArchiveFlag = 0	 AND OrderID = @OrderID";

        public const string setOrderShippingInfo = "[dbo].[usp_Admin_Set_Order_Shipment]";

        #endregion

        #region Order Status / Art Status
        public const string getOrdersSatus = "[dbo].[usp_Admin_Get_Orders_Status]";
        public const string getOrdersArtSatus = "[dbo].[usp_Admin_Get_Orders_Art_Status]";
        public const string updateOtherTablesBasedOnArtStatus = "[dbo].[usp_Admin_Update_On_Art_Status]";

        #endregion

        #region Job Overview
        public const string getJobOverviewOrders = "[dbo].[usp_Admin_Get_Job_Overview]";
        public const string getVoidOrders = "[dbo].[usp_Admin_Get_Job_Void_Orders]";
        public const string VoidOrder = "[dbo].[usp_Admin_Archive_Order]";
        public const string UpdateOrderStatus = "[dbo].[usp_Admin_Update_OrderStatus]";
        #endregion

        #region worksheet
        public const string getOrderWorksheet = "[dbo].[usp_Admin_Get_Order_Worksheet]";
        public const string getEditOrderWorksheet = "[dbo].[usp_Admin_Get_Edit_Order_Worksheet]";
        public const string getPackingSlip = "[dbo].[usp_Admin_Get_Packing_Slip]";
        public const string getPricingSheet = "[dbo].[usp_Admin_Get_Pricing_Sheet]";
        public const string UpdateWorksheet = "[dbo].[usp_Admin_Update_OrderWorksheet]";
        public const string UpdateWorkSheetGoods = "[dbo].[usp_Admin_Update_OrderGoods]";
        public const string GetDesignDetails = "[dbo].[usp_Admin_Get_Design_Details]";
        public const string GetNamesNumbersInkSize = "[dbo].[usp_Admin_Get_Design_InkSizeNamesNumbers]";
        public const string InsertOrderEditHistory = "[dbo].[usp_Admin_Insert_CustOrderEditHistory]";
        public const string GetOrderEditHistory = "[dbo].[usp_Admin_Get_Order_EditHistory]";
        #endregion

        #region Today Sales
        public const string getSalesReport = "[dbo].[usp_Admin_Get_Sales_Report]";
        #endregion

        #region Today Shippings
        public const string getShippingReport = "[dbo].[usp_Admin_Get_Shippings_Report]";
        #endregion

        #region Today Designs
        public const string getDesignsReport = "[dbo].[usp_Admin_Get_Designs_Report]";
        #endregion

        #region Admin Email
        public const string insertAdminEmail =
            "INSERT INTO [dbo].[AdminEmail] ([OrderID],[EmailTypeCode],[row_added],[Sent],[Date_Sent],[EmailNotes],[AdditionalNotes]) VALUES (@OrderID,@EmailTypeCode,GetDate(),0,null,@EmailNotes,@AdditionalNotes)";
        #endregion

        #region Product Custom Banners

        public const string getProdCustomBanners =
"SELECT [FeaturedProductID] AS ID ,[ImageName] AS Name,[ProdPixCodeOrder] AS Priority, [customURL] AS URL FROM [dbo].[FeaturedProduct] Where isBanner = 'Y' and FeaturedCategoryID IS null and ProdCatID IS null";


        public const string DeleteProdCustomBanner = "DELETE FROM [dbo].[FeaturedProduct] where FeaturedProductID = @ID";

        public const string getProdCustomBannersByProdCatID =
"SELECT TOP 1 [FeaturedProductID] AS ID FROM [dbo].[FeaturedProduct] Where isBanner = 'Y' and  FeaturedCategoryID = @CatID and ProdCatID = @CatID ORDER BY last_update DESC";


        public const string getFeaturedProduct = "SELECT * FROM [dbo].[FeaturedProduct] Where FeaturedProductID = @FeaturedProductID ";

        public const string insertProdCustomBanner =
"INSERT INTO [dbo].[FeaturedProduct] ([ImageName],[ImageFile],[FeaturedCategoryID],[ProdCatID],[row_added],[last_update],[DefaultFeaturedImage],[isBanner],[ProdPixCodeOrder],[customURL]) " +
"VALUES(@ImageName,@ImageFile,@CatID,@CatID,GetDate(),GetDate(),0,'Y',@ProdPixCodeOrder,@customURL) ";

        public const string updateProdCustomBanner =
"UPDATE [dbo].[FeaturedProduct] SET [ImageName] = @ImageName,[ImageFile] = @ImageFile,[ProdPixCodeOrder] =@ProdPixCodeOrder " +
",[last_update] = GetDate(), [customURL]=@customURL WHERE [FeaturedProductID] = @FeaturedProductID";

        #endregion

        #region Template Custom Banners

        public const string getTemplatesBanners =
"SELECT [FeaturedTemplateID] AS ID,[ImageName] AS Name,[Priority],[customURL] AS URL FROM [dbo].[FeaturedTemplate] Where isBanner = 'Y' and FeaturedCategoryID IS null and ClipCatID IS null";

        public const string DeleteTemplateBanner = "DELETE FROM [dbo].[FeaturedTemplate] where FeaturedTemplateID = @ID";

        public const string getTemplateBannerByTemplateCatID =
"SELECT TOP 1 [FeaturedTemplateID] AS ID FROM [dbo].[FeaturedTemplate] Where isBanner = 'Y' and FeaturedCategoryID = @CatID and ClipCatID = @CatID ORDER BY last_update DESC";

        public const string getFeaturedTemplate = "SELECT * FROM [dbo].[FeaturedTemplate] Where FeaturedTemplateID = @ID ";

        public const string insertTemplateBanner =
"INSERT INTO [dbo].[FeaturedTemplate] ([ImageName],[ImageFile],[FeaturedCategoryID],[ClipCatID],[row_added],[last_update],[isDefaultImage],[isBanner],[Priority],[customURL]) " +
"VALUES(@ImageName,@ImageFile,@CatID,@CatID,GetDate(),GetDate(),0,'Y',@Priority,@customURL) ";


        public const string updateTemplateBanner =
"UPDATE [dbo].[FeaturedTemplate] SET [ImageName] = @ImageName,[ImageFile] = @ImageFile,[Priority] =@Priority " +
",[last_update] = GetDate(), [customURL]=@customURL WHERE [FeaturedTemplateID] = @ID";

        #endregion

        #region Template Cat assign Image
        public const string getTemplateImgByTemplateCatID =
       "SELECT TOP 1 * FROM [dbo].[FeaturedTemplate] Where isBanner = 'N' and FeaturedCategoryID = @CatID and ClipCatID = @CatID and isDefaultImage=1 ORDER BY last_update DESC";

        public const string insertTemplateCategoryImg =
"INSERT INTO [dbo].[FeaturedTemplate] ([ImageName],[ImageFile],[FeaturedCategoryID],[ClipCatID],[row_added],[last_update],[isDefaultImage],[isBanner],[Priority]) " +
"VALUES(@ImageName,@ImageFile,@CatID,@CatID,GetDate(),GetDate(),1,'N',@Priority) ";

        public const string updateTemplateCategoryImg =
"UPDATE [dbo].[FeaturedTemplate] SET [ImageName] = @ImageName,[ImageFile] = @ImageFile,[Priority] =@Priority " +
",[last_update] = GetDate() WHERE [FeaturedTemplateID] = @ID";

        #endregion

        #region Products cats SEO

        public const string getProduCatSeo = "SELECT TOP 1 * FROM dbo.ProductCategorySEO s where s.ArchiveFlag = 0 and s.ProdCatID = @catID order by last_update DESC";


        public const string getProdCatNameInfo = "SELECT ProdCatDscr as catName,(SELECT TOP 1 ProdCatDscr FROM ProductCategory WHERE ProdCatID = c.ProdCatParentID) as ParentCatName" +
                                                 " FROM ProductCategory c WHERE ProdCatID = @catID";

        public const string getProdNameInfo = "SELECT ProdName as ProdName, (SELECT TOP 1 rtrim(ltrim(ManufName)) FROM dbo.Manufacturer AS m WHERE m.CompanyID = p.CompanyID AND m.ArchiveFlag = 0 ) as Company FROM dbo.Product p WHERE ProdID = @id";

        //public const string DeleteProductSeo = "DELETE FROM [dbo].[ProductCategorySEO] where  ProductCategorySEOID= @ID";
        //public const string ArchiveProductSeo = "Update [dbo].[ProductCategorySEO] set last_update=getDate(), archiveflag=1 where ProductCategorySEOID= @ID";

        public const string InsertProductCatsSeo =
"INSERT INTO [dbo].[ProductCategorySEO]([ProdCatID],[TitleTag],[URL],[HeaderAltTag],[FooterAnchorTitleText],[MetaDescription],[MetaKeywords],[robotsindex]" +
",[robotsfollow],[googlebotindex],[googlebotfollow],[msnbot],[ArchiveFlag],[row_added],[last_update],[OldURL]) VALUES" +
"(@ProdCatID,@TitleTag,@URL,@HeaderAltTag,@FooterAnchorTitleText,@MetaDescription ,@MetaKeywords,@robotsindex,@robotsfollow ,@googlebotindex" +
",@googlebotfollow,@msnbot,0,GetDAte(),GetDate(),@OldURL)";

        public const string UpdateProductCatsSeo =
"Update [dbo].[ProductCategorySEO] SET [TitleTag] =@TitleTag ,[URL]=@URL ,[HeaderAltTag] = @HeaderAltTag,[FooterAnchorTitleText] =@FooterAnchorTitleText ,[MetaDescription] =@MetaDescription ,[MetaKeywords]= @MetaKeywords,[robotsindex]=@robotsindex" +
",[robotsfollow]=@robotsfollow,[googlebotindex]=@googlebotindex,[googlebotfollow]=@googlebotfollow ,[msnbot] =@msnbot,[last_update]=GetDAte() ,[OldURL]= @OldURL where ProductCategorySEOID = @ID";
        #endregion

        #region Template SEO

        public const string getTemplateCatSeo =
            "SELECT TOP 1 * FROM dbo.TemplateCategorySEO where ArchiveFlag = 0 and TemplateCatID = @catID order by last_update DESC";

        public const string getClipartCatNameInfo =
        "SELECT ClipCatDscr as catName,(SELECT TOP 1 ClipCatDscr FROM DBO.[Clipart-TemplateCategory] WHERE ClipCatID = c.ClipCatParentID) as ParentCatName FROM dbo.[Clipart-TemplateCategory] c WHERE ClipCatID =  @catID";

        public const string InsertTemplateCatsSeo =
"INSERT INTO [dbo].[TemplateCategorySEO]([TemplateCatID],[TitleTag],[URL],[HeaderAltTag],[FooterAnchorTitleText],[MetaDescription],[MetaKeywords],[robotsindex]" +
",[robotsfollow],[googlebotindex],[googlebotfollow],[msnbot],[ArchiveFlag],[row_added],[last_update],[OldURL]) VALUES" +
"(@TemplateCatID,@TitleTag,@URL,@HeaderAltTag,@FooterAnchorTitleText,@MetaDescription ,@MetaKeywords,@robotsindex,@robotsfollow ,@googlebotindex" +
",@googlebotfollow,@msnbot,0,GetDAte(),GetDate(),@OldURL)";

        public const string UpdateTemplateCatsSeo =
"Update [dbo].[TemplateCategorySEO] SET [TitleTag] =@TitleTag ,[URL]=@URL ,[HeaderAltTag] = @HeaderAltTag,[FooterAnchorTitleText] =@FooterAnchorTitleText ,[MetaDescription] =@MetaDescription ,[MetaKeywords]= @MetaKeywords,[robotsindex]=@robotsindex" +
",[robotsfollow]=@robotsfollow,[googlebotindex]=@googlebotindex,[googlebotfollow]=@googlebotfollow ,[msnbot] =@msnbot,[last_update]=GetDAte() ,[OldURL]= @OldURL where TemplateCategorySEOID = @ID";
        #endregion

        #region Product Browser

        public const string getProductsBelongsToCategory =
           "SELECT p.ProdID,(SELECT TOP 1 ManufName FROM dbo.Manufacturer WHERE CompanyID = p.CompanyID) As Manufacturer,p.ProdName,p.ProdManufCode FROM dbo.Product AS p INNER JOIN dbo.ProductProdCat AS pc ON p.ProdID = pc.ProdID	WHERE pc.ProdCatID = @CatID AND p.ArchiveFlag = 0 AND pc.ArchiveFlag = 0 ORDER BY p.ProdSortOrder";

        //public const string getAllProductsInfo =
        //"SELECT ProdID,(SELECT TOP 1 ProdCatID FROM dbo.ProductProdCat WHERE ProdID = p.ProdID) AS CatID ,(SELECT TOP 1 ManufName FROM dbo.Manufacturer WHERE CompanyID = p.CompanyID) As Manufacturer,ProdName,ProdManufCode FROM dbo.Product AS p WHERE p.Archiveflag = 0";

        public const string getAllProductColorsFrontBackImages =
"SELECT DISTINCT ProdColorID,ProdImageFile,ProdPixCode,(SELECT TOP 1 c.ColorName FROM  dbo.Color AS c Inner JOIN dbo.ProductColors as pc ON c.ColorID = pc.ColorID WHERE pc.ProdColorID = pp.ProdColorID AND pc.ArchiveFlag = 0 ) AS ColorName " +
" FROM dbo.ProductPix AS pp WHERE prodId = @ProdID AND ArchiveFlag = 0 AND ( ProdPixCode = 'PFI' OR ProdPixCode = 'PBI') order by ColorName";
        #endregion

        #region Products SEO
        public const string getProductsSeo =
        "SELECT p.ProdID,p.ProdName,p.CompanyID,p.ProdManufCode,(SELECT TOP 1 ManufName FROM dbo.Manufacturer AS m WHERE m.CompanyID = p.CompanyID AND m.ArchiveFlag = 0 )	AS ManufName,p.ProdSortOrder" +
         " FROM dbo.Product AS p  WHERE  p.ArchiveFlag = 0 order by p.CompanyID ,p.ProdSortOrder";

        public const string getProductSeo = "SELECT TOP 1 * FROM dbo.ProductCategorySEO where ArchiveFlag = 0 and ProdID = @ID order by last_update DESC";

        public const string InsertProductSeo =
"INSERT INTO [dbo].[ProductCategorySEO]([ProdCatID],[TitleTag],[URL],[HeaderAltTag],[FooterAnchorTitleText],[MetaDescription],[MetaKeywords],[robotsindex]" +
",[robotsfollow],[googlebotindex],[googlebotfollow],[msnbot],[ArchiveFlag],[row_added],[last_update],[OldURL],[ProdID]) VALUES" +
"(null,@TitleTag,@URL,@HeaderAltTag,@FooterAnchorTitleText,@MetaDescription ,@MetaKeywords,@robotsindex,@robotsfollow ,@googlebotindex" +
",@googlebotfollow,@msnbot,0,GetDAte(),GetDate(),@OldURL,@ProdID)";




        #endregion

        #region Order Search
        public const string searchOrdersSP = "[dbo].[usp_Admin_Order_search]";
        public const string getShippingMethods = "SELECT ShipMethodCode,ShipMethodName FROM dbo.ShipMethod WHERE ArchiveFlag = 0";
        #endregion

        #region Customer Search
        public const string searchCustomersSP = "[dbo].[usp_Admin_Customer_search]";
        public const string getCustomersTypes = "SELECT CustomerTypeName,priority FROM dbo.CustomerType ORDER BY priority";
        #endregion

        #region Customer DEtails
        public const string getCustomerByIDSP = "[dbo].[usp_Admin_Customer_Detail_By_ID]";
        public const string updateCustomerDetails = "UPDATE dbo.Customer  SET CustRepNotes = @CustRepNotes ,CustomerType = @CustomerType, last_update = GETDATE() WHERE CustPersonID = @custID";


        public const string updateCustomerDetailsAll = "UPDATE [dbo].[Customer]  SET [CustomerEmail] = @CustomerEmail, [FirstName] = @FirstName,[LastName] = @LastName,[Title] = @Title,[Organization] = @Organization " +
            " ,[Phone] = @Phone,[PhoneExt] = @PhoneExt,[AltPhone] = @AltPhone ,[AltPhoneExt] = @AltPhoneExt ,[Fax] = @Fax ,[CustNewsletterSubscriber] = @CustNewsletterSubscriber ,[BlackListFlag] = @BlackListFlag " +
            " ,[CustRepNotes] = @CustRepNotes,[CustomerType] = @CustomerType , last_update=getdate() WHERE CustPersonID = @CustPersonID";
        //public const string updateCustomerPreferences = " UPDATE [dbo].[CustomerPreferences]   SET [PreferredContactMethod] = @PreferredContactMethod  ,[EmailOption] = @EmailOption WHERE CustomerPreferenceID = @CustomerPreferenceID";
        public const string deleteCustomerPreferences = "DELETE FROM [dbo].[CustomerPreferences]  WHERE [CustPersonID] = @CustPersonID";
        public const string insertCustomerPreferences = "INSERT INTO [dbo].[CustomerPreferences]([CustPersonID],[PreferredContactMethod],[EmailOption]) VALUES (@CustPersonID,@PreferredContactMethod,@EmailOption)";

        public const string archiveCustomerDesign = "UPDATE dbo.Design  SET ArchiveFlag = 1 WHERE DesignID = @designID";
        public const string UpdateCustomerEmail = "[dbo].[usp_Admin_UpdateCustomer_Email_By_ID]";


        #endregion

        #region Product reviews
        public const string getProdReviews = "[dbo].[usp_Admin_Get_Products_Reviews]";
        public const string updateProdReviewApproveStatus = "UPDATE [dbo].[ProductReview]  SET [last_update] = getdate(),[isApproved] = @isApproved where ProductReviewId = @id";
        public const string getProdReviewByID = "SELECT * from [dbo].[ProductReview]  WHERE ProductReviewId = @id";
        public const string getProductsNameList =
        "SELECT p.ProdID,(SELECT TOP 1 ManufName FROM dbo.Manufacturer WHERE CompanyID = p.CompanyID) +' '+ p.ProdName+' '+p.ProdManufCode as [Name] FROM dbo.Product p WHERE p.ArchiveFlag = 0 and p.ProdAvailable = 'Y' order by p.CompanyID";
        public const string updateProductReview =
        "UPDATE [dbo].[ProductReview]  SET [Comments] = @comment,[ReviewRatingId] = @rating ,[Name] = @name ,[last_update] = getdate() WHERE ProductReviewId = @id";

        public const string addProductReview =
        "INSERT INTO [dbo].[ProductReview]([ProdId],[Comments],[ReviewRatingId],[Name],[row_added],[last_update],[isApproved]) VALUES(@prodId,@comments,@rating,@name,getdate(),getdate(),1);";

        public const string archiveProductReview = "UPDATE [dbo].[ProductReview]  SET [isApproved]=0,[ArchiveFlag] = 1  where ProductReviewId = @id";


        #endregion

        #region Testimonials
        public const string getTestimonials = "[dbo].[usp_Admin_Get_Testimonials]";
        public const string updateTestimonialsApproveStatus = "UPDATE [dbo].[Testimonials]  SET [Approved] = @isApproved where TestimonialID = @id";

        public const string getTestimonialByID = "SELECT * from [dbo].[Testimonials]  WHERE TestimonialID = @id and ArchiveFlag = 0";

        public const string updateTestimonial =
        "UPDATE [dbo].[Testimonials]  SET [PostDate] = @PostDate,[ReviewRatingId] = @rating,[Testimonialcomment] = @comment,[OrderID] = @orderID,[CustomerName] = @name,[EmailAddress] = @email WHERE TestimonialID = @id";
        public const string addTestimonial =
        "INSERT INTO [dbo].[Testimonials]([PostDate],[ReviewRatingId],[Testimonialcomment],[OrderID],[CustomerName],[Approved],[ArchiveFlag],[EmailAddress],[PrintQuality],[ShippingDelivery],[CustomerService],[RecommendFriend],[Packaging]) VALUES ( @PostDate,@rating,@comment,@orderID,@name,1,0,@email,5,5,5,5,5)";

        public const string archiveTestimonial = "UPDATE [dbo].[Testimonials]  SET [ArchiveFlag] = 1 where TestimonialID = @id";

        #endregion

        #region Reports
        public const string getCouponsReport = "[dbo].[usp_Admin_Get_Coupons_Report]";
        public const string getCustomersReport = "[dbo].[usp_Admin_Get_Customer_Report]";
        public const string getTopCustomersReport = "[dbo].[usp_Admin_Get_Top_Customer_Report]";
        public const string getSalesReport2 = "[dbo].[usp_Admin_Get_Sales_Report2]";
        public const string getOrderDesignsReport = "[dbo].[usp_Admin_Get_OrderDesign_Report]";
        public const string getOrderSummaryReport = "[dbo].[usp_Admin_Get_Order_Summary_By_Date]";
        public const string getPrintCostReport = "[dbo].[usp_Admin_Get_PrintCost_Report]";
        public const string getPrintThisWeekReport = "[dbo].[usp_Admin_Get_PrintThisWeek_Report]";
        public const string getGoodsNotCheckedInReport = "[dbo].[usp_Admin_Get_GoodsNotCheckedIn_Report]";
        public const string getShipCostReport = "[dbo].[usp_Admin_Get_ShippingCost_Report]";
        #endregion

        #region Design

        public const string getDesignByIDSP = "[dbo].[usp_Admin_Get_Design]";

        #endregion

        #region Order Pricing sheet
        public const string getOrderPricingInfo = "[dbo].[usp_Admin_Get_Order_Pricing_Info]";
        #endregion

        #region Quickbook Export
        public const string getQuickBookOredrsInfo = "[dbo].[usp_Admin_QuickBook_Export_Orders]";
        #endregion

        #region Print Color
        public const string getPrintColors = "SELECT * FROM dbo.Color WHERE ColorCatID = 1 AND ArchiveFlag = 0 ORDER BY ColorSortOrder";
        #endregion

        #region Production
        public const string insertProductionHistory = "[dbo].[usp_Admin_Insert_Order_ProductionHistory]";
        public const string getProductionHistory = "[dbo].[usp_Admin_Get_Order_ProductionHistory]";
        #endregion

        #region Art
        public const string insertArtHistory = "[dbo].[usp_Admin_Insert_Order_ArtHistory]";
        public const string getArtHistory = "[dbo].[usp_Admin_Get_Order_ArtHistory]";
        public const string assignArtist = "[dbo].[usp_Admin_AssignArt]";
        #endregion

        #region  ExternalPrinters
        public const string updateCustOrderExternalPrinter =
   "UPDATE [dbo].[CustOrder]  SET [Outsourced] = @outsourced, [ExternalPrinter] = @externalprinter,[last_update] = GETDATE() WHERE OrderID = @orderID";




        #endregion


    }
}
