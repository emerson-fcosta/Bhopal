using Bhopal2.Business;
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
        /// <summary>
        /// Metodo executado automaticamente ao carregar a pagina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            //Carregando os dados no dropdown list
            //Marca
            var marcaDAO = new MarcaDAO();
            var marcas = marcaDAO.GetAll();
            if (marcas.Count > 0)
            {
                ddlMarca.DataValueField = "Id";
                ddlMarca.DataTextField = "Nome";
                ddlMarca.DataSource = marcas;
                ddlMarca.DataBind();
                ddlMarca.Items.Insert(0, "Selecione");
            }
        }

        void AtualizaFormulario(long Id)
        {
            var i = new ModeloDAO().ObterPeloId(Id);

            txtId.Text = i.Id.ToString();
            txtModeloNome.Text = i.Nome;

            if (i.Marca != null)
            {
                ddlMarca.SelectedValue = i.Marca.Id.ToString();
            }
        }

        /// <summary>
        /// Salva o modelo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo mod = new Modelo();
            var dao = new ModeloDAO();

            //salvando os dados do cadastro de impressora
            if (txtId.Text != string.Empty)
            {
                mod= dao.ObterPeloId(long.Parse(txtId.Text));
            }

            mod.Nome = txtModeloNome.Text.ToString();

            if (ddlMarca.SelectedValue != "")
                mod.Marca = new MarcaBusiness().retornaId(long.Parse(ddlMarca.SelectedValue));

            dao.AdicionaModelo(mod);

            Response.Redirect("Modelos.aspx");

        }
    }
}