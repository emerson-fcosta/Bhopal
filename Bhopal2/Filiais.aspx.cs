using Bhopal2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhopal2
{
    public partial class Filiais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var dao = new FilialDAO();
                var modelos = dao.GetAll();

                GridViewFiliais.DataSource = modelos;
                GridViewFiliais.DataBind();
                if (modelos.Count > 0)
                    GridViewFiliais.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}