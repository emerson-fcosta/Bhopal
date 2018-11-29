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

        private void CarregarDropDown()
        {
            
        }

        void AtualizaFormulario(long Id)
        {
            var i = new FilialDAO().ObterPeloId(Id);
            txtId.Text = i.Id.ToString();

            txtNome.Text = i.Nome;
            txtDDD.Text = i.Ddd;
            txtCodigo.Text = i.Codigo;
        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            Filial f = new Filial();
            var dao = new FilialDAO();

            if (txtId.Text != string.Empty)
            {
                f = dao.ObterPeloId(long.Parse(txtId.Text));
            }

            f.Nome = txtNome.Text.ToString();
            f.Codigo = txtCodigo.Text.ToString();
            f.Ddd = txtDDD.Text.ToString();

            dao.Salvar(f);

            Response.Redirect("/Filiais.aspx");

        }
    }
}