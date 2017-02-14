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
    public partial class CadastroDeModelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo mod = new Modelo();
            mod.Nome = txtModeloNome.Text.ToString();

            ModeloDAO gravamod = new ModeloDAO();
            gravamod.AdicionaModelo(mod);

            Response.Redirect("/");

        }
    }
}