using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bhopal2.Business;
using Bhopal2.Models;
using Bhopal2.DAO;

namespace Bhopal2.scripts
{
    public partial class CadastroModelo : System.Web.UI.Page
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