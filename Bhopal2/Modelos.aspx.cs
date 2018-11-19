using Bhopal2.DAO;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhopal2
{
    public partial class Modelos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var dao = new ModeloDAO();
                var modelos = dao.GetAll();

                GridViewModelos.DataSource = modelos;
                GridViewModelos.DataBind();
                if (modelos.Count > 0)
                    GridViewModelos.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}