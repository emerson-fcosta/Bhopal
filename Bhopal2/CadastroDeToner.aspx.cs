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
    public partial class CadastroDeToner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarDropDown();

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
            //Carregando dados no DropDownList
            //Impressora
            var i = new ImpressoraDAO();
            var impressoras = i.ObterTodos();
            if (impressoras.Count > 0)
            {
                ddlImpressora.DataValueField = "Id";
                ddlImpressora.DataTextField = "Codigo";
                ddlImpressora.DataSource = impressoras;
                ddlImpressora.DataBind();
                ddlImpressora.Items.Insert(0, "Selecione");
            }

        }

        void AtualizaFormulario(long Id)
        {
            var i = new TonerDAO().ObterPeloId(Id);

            txtId.Text = i.Id.ToString();
            txtCor.Text = i.Cor;
            txtCodigo.Text = i.Codigo;
            cbColorida.Checked = i.Colorido;

            if (i.Impressora != null)
            {
                ddlImpressora.SelectedValue = i.Impressora.Id.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Toner t = new Toner();
            var dao = new TonerDAO();

            //salvando os dados do cadastro de impressora
            if (txtId.Text != string.Empty)
            {
                t = dao.ObterPeloId(long.Parse(txtId.Text));
            }

            t.Cor = txtCor.Text;
            t.Codigo = txtCodigo.Text;
            t.Colorido = cbColorida.Checked;

            if (ddlImpressora.SelectedValue != "")
            {
                t.Impressora = new ImpressoraDAO().ObterPeloId(ddlImpressora.SelectedValue);
            }

            dao.AdicionaToner(t);

            Response.Redirect("toners.aspx");
        }


    }
}