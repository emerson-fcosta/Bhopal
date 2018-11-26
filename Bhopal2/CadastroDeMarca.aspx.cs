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
            if (!Page.IsPostBack)
            {
                var param = Request.QueryString["Id"];
                if (param != null)
                {
                    long id;
                    var i = long.TryParse(param, out id);
                    if (i)
                    {
                        AtualizaFormulario(id);
                    }
                }
            }
        }

        void AtualizaFormulario(long Id)
        {
            var i = new MarcaDAO().ObterPeloId(Id);

            txtId.Text = i.Id.ToString();
            txtMarca.Text = i.Nome;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Marca m = new Marca();
            var dao = new MarcaDAO();

            //salvando os dados do cadastro de impressora
            if (txtId.Text != string.Empty)
            {
                m = dao.ObterPeloId(long.Parse(txtId.Text));
            }

            m.Nome = txtMarca.Text.ToString();
            dao.AdicionaMarca(m);

            Response.Redirect("marcas.aspx");
        }
    }
}