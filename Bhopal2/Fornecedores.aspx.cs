using Bhopal2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhopal2
{
    public partial class Fornecedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var dao = new FornecedorDAO();
                var fornecedores = dao.GetAll();

                GridViewFornecedores.DataSource = fornecedores;
                GridViewFornecedores.DataBind();

                if (fornecedores.Count > 0)
                    GridViewFornecedores.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}