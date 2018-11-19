using Bhopal2.DAO;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhopal2.scripts
{
    public partial class CadastroDeMarca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Marca m = new Marca();
            m.Nome = txtMarca.Text.ToString();

            MarcaDAO gravarMarca = new MarcaDAO();
            gravarMarca.AdicionaMarca(m);

            Response.Redirect("marcas.aspx");
        }
    }
}