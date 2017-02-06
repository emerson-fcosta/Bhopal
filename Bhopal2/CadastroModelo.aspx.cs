using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bhopal2.Business;

namespace Bhopal2.scripts
{
    public partial class CadastroModelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var i = new ImpressoraBusiness();
                var impressoras = i.retornaImpressoras();

                ddlImpressoras.DataTextField = "Nome";
                ddlImpressoras.DataValueField = "Id";
                ddlImpressoras.DataSource = impressoras;
                ddlImpressoras.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}