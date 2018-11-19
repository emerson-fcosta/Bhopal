using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bhopal2.DAO;

namespace Bhopal2
{
    public partial class Impressoras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var impressoras = new ImpressoraDAO().GetAll();
                GridViewImpressora.DataSource = impressoras;
                GridViewImpressora.DataBind();

                if (impressoras.Count > 0)
                    GridViewImpressora.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}