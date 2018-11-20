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
    public partial class CadastroDeFilial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            Filial f = new Filial();
            f.Nome = txtNome.Text.ToString();
            f.Codigo = txtCodigo.Text.ToString();
            f.Ddd = txtDDD.Text.ToString();

            FilialDAO gravarFilial = new FilialDAO();
            gravarFilial.AdicionaFilial(f);

            Response.Redirect("/Filiais.aspx");

        }
    }
}