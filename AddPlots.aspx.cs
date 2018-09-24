using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IdealResidencia
{
    public partial class AddPlots : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BlocksDropDown();
                ShowData();
            }
        }

        protected void ShowData()
        {
            string sql = "SELECT * FROM Plot";
            DataSet ds = DBUtility.GetResultSets(sql, new Hashtable(), AllConstStrs.Con_IdealRConStr);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();

            }
        }

        // Binding Drop Down from database
        protected void BlocksDropDown()
        {
            string sql = "SELECT BlockID, BlockName FROM Block";
            DataSet ds = DBUtility.GetResultSets(sql, new Hashtable(), AllConstStrs.Con_IdealRConStr);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlBlocks.DataSource = ds.Tables[0];
                ddlBlocks.DataBind();
                ddlBlocks.DataTextField = "BlockName";
                ddlBlocks.DataValueField = "BlockID";
                ddlBlocks.DataBind();

            }
        }

        // Adding Plots to the DB
        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Getting "BLOCKS" data from the form and inserting it to db.
            string sql = "INSERT INTO Plot(PlotSizeMarla, PlotArea, PlotStatus, PlotType, PlotCategory, PlotStreetNo1, PlotStreetNo2, PlotStreetNo3, BlockID) " +
                "VALUES(@PlotSizeMarla, @PlotArea, @PlotStatus, @PlotType, @PlotCategory, @PlotStreetNo1, @PlotStreetNo2, @PlotStreetNo3, @BlockID)";
            IDictionary sqlParamMap = new Hashtable
            {
                { "@PlotSizeMarla", SizeMarlaTextBox.Text },
                { "@PlotArea", AreaTextBox.Text },
                { "@PlotStatus", StatusTextBox.Text },
                { "@PlotType", TypeTextBox.Text },
                { "@PlotCategory", CategoryTextBox.Text },
                { "@PlotStreetNo1", StreetNo1TextBox.Text},
                { "@PlotStreetNo2", StreetNo2TextBox.Text },
                { "@PlotStreetNo3", StreetNo3TextBox.Text },
                { "@BlockID", ddlBlocks.SelectedValue }
            };

            int rowsEffected = DBUtility.ModifyDatabase(sql, sqlParamMap, AllConstStrs.Con_IdealRConStr, "InsertCommand");
            if (rowsEffected == 0)
            {
                Response.Write("Success");
            }
            else
            {
                Response.Write("Fail");
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.  
            GridView1.EditIndex = e.NewEditIndex;
            ShowData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update  
            Label PlotID = GridView1.Rows[e.RowIndex].FindControl("PlotIDLabel") as Label;
            TextBox PlotSizeMarla = GridView1.Rows[e.RowIndex].FindControl("PlotSizeMarlaTextBox") as TextBox;
            TextBox PlotAreaText = GridView1.Rows[e.RowIndex].FindControl("PlotAreaTextBox") as TextBox;
            TextBox PlotStatus = GridView1.Rows[e.RowIndex].FindControl("PlotStatusTextBox") as TextBox;
            TextBox PlotType = GridView1.Rows[e.RowIndex].FindControl("PlotTypeTextBox") as TextBox;
            TextBox PlotCategory = GridView1.Rows[e.RowIndex].FindControl("PlotCategoryTextBox") as TextBox;
            TextBox PlotStreetNo1 = GridView1.Rows[e.RowIndex].FindControl("PlotStreetNo1TextBox") as TextBox;
            TextBox PlotStreetNo2 = GridView1.Rows[e.RowIndex].FindControl("PlotStreetNo2TextBox") as TextBox;
            TextBox PlotStreetNo3 = GridView1.Rows[e.RowIndex].FindControl("PlotStreetNo3TextBox") as TextBox;

            //creating update query
            string sql = "UPDATE Plot SET PlotSizeMarla = @PlotSizeMarla, PlotArea = @PlotArea, PlotStatus = @PlotStatus, " +
                "PlotType = @PlotType, PlotCategory = @PlotCategory, PlotStreetNo1 = @PlotStreetNo1, PlotStreetNo2 = @PlotStreetNo2, " +
                "PlotStreetNo3 = @PlotStreetNo3 WHERE PlotID = @PlotID;";

            // Assigning parameter values
            IDictionary sqlParamMap = new Hashtable
            {
                { "@PlotID", Convert.ToInt32(PlotID.Text) },
                { "@PlotSizeMarla", PlotSizeMarla.Text },
                { "@PlotArea", PlotAreaText.Text },
                { "@PlotStatus", PlotStatus.Text },
                { "@PlotType", PlotType.Text },
                { "@PlotCategory", PlotCategory.Text },
                { "@PlotStreetNo1", PlotStreetNo1.Text },
                { "@PlotStreetNo2", PlotStreetNo2.Text },
                { "@PlotStreetNo3", PlotStreetNo3.Text }
            };

            // Attemptimg to update the DB
            int rowsEffected = DBUtility.ModifyDatabase(sql, sqlParamMap, AllConstStrs.Con_IdealRConStr, "UpdateCommand");
            if (rowsEffected == 1)
            {
                //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
                GridView1.EditIndex = -1;

                //Call ShowData method for displaying updated data  
                ShowData();

            }
            else
            {
                // display error
            }

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GridView1.EditIndex = -1;
            ShowData();
        }


    }
}