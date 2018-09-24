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
    public partial class InsertBlocks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowData();
            }

        }

        protected void ShowData()
        {
            string sql = "SELECT * FROM Block";
            DataSet ds = DBUtility.GetResultSets(sql, new Hashtable(), AllConstStrs.Con_IdealRConStr);
            if(ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();

            }
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Getting "BLOCKS" data from the form and inserting it to db.
            string sql = "INSERT INTO BLOCK(BlockName, BlockMarketName, BlockParkName, BlockHospitalName, BlockMasjidName, BlockSchoolName)" +
                "VALUES(@BlockName, @BlockMarketName, @BlockParkName, @BlockHospitalName, @BlockMasjidName, @BlockSchoolName)";
            IDictionary sqlParamMap = new Hashtable
            {
                { "@BlockName", BlockNameTextBox.Text },
                { "@BlockMarketName", MarketNameTextBox.Text },
                { "@BlockParkName", ParkNameTextBox.Text },
                { "@BlockHospitalName", HospitalNameTextBox.Text },
                { "@BlockMasjidName", MasjidNameTextBox.Text},
                { "@BlockSchoolName", SchoolNameTextBox.Text }
            };

            int rowsEffected = DBUtility.ModifyDatabase(sql, sqlParamMap, AllConstStrs.Con_IdealRConStr, "InsertCommand");
            if(rowsEffected == 0)
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
            Label BlockID = GridView1.Rows[e.RowIndex].FindControl("BlockIDLabel") as Label;
            TextBox blockName = GridView1.Rows[e.RowIndex].FindControl("BlockNameTextBox") as TextBox;
            TextBox blockMarketName = GridView1.Rows[e.RowIndex].FindControl("MarketNameTextBox") as TextBox;
            TextBox blockParkName = GridView1.Rows[e.RowIndex].FindControl("ParkNameTextBox") as TextBox;
            TextBox blockHospitalName = GridView1.Rows[e.RowIndex].FindControl("HospitalNameTextBox") as TextBox;
            TextBox blockMasjidName = GridView1.Rows[e.RowIndex].FindControl("MasjidNameTextBox") as TextBox;
            TextBox blockSchoolName = GridView1.Rows[e.RowIndex].FindControl("SchoolNameTextBox") as TextBox;

            //creating update query
            string sql = "UPDATE Block SET BlockName = @BlockName, BlockMarketName = @BlockMarketName, BlockParkName = @BlockParkName, " +
                "BlockHospitalName = @BlockHospitalName, BlockMasjidName = @BlockMasjidName, BlockSchoolName = @BlockSchoolName " +
                "WHERE BlockID = @BlockID;";

            // Assigning parameter values
            IDictionary sqlParamMap = new Hashtable
            {
                { "@BlockID", Convert.ToInt32(BlockID.Text) },
                { "@BlockName", blockName.Text },
                { "@BlockMarketName", blockMarketName.Text },
                { "@BlockParkName", blockParkName.Text },
                { "@BlockHospitalName", blockHospitalName.Text },
                { "@BlockMasjidName", blockMasjidName.Text },
                { "@BlockSchoolName", blockSchoolName.Text }
            };

            // Attemptimg to update the DB
            int rowsEffected = DBUtility.ModifyDatabase(sql, sqlParamMap, AllConstStrs.Con_IdealRConStr, "UpdateCommand");
            if( rowsEffected == 1 )
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