using Bhopal2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhopal2
{
    public partial class Departamentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var dao = new DepartamentoDAO();
                var modelos = dao.GetAll();

                GridViewDepartamentos.DataSource = modelos;
                GridViewDepartamentos.DataBind();
                if (modelos.Count > 0)
                    GridViewDepartamentos.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}