using Bhopal2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhopal2
{
    public partial class Toners : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var dao = new TonerDAO();
                var toneres = dao.GetAll();

                GridViewToners.DataSource = toneres;
                GridViewToners.DataBind();

                if(toneres.Count > 0)
                    GridViewToners.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}