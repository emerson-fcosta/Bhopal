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
                //Carregando os dados no dropdown list
                //Marca
                var marcaDAO = new MarcaDAO();
                var marcas = marcaDAO.getAll();
                if (marcas.Count > 0)
                {
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataTextField = "Nome";
                    ddlMarca.DataSource = marcas;
                    ddlMarca.DataBind();
                }
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
            mod.Nome = txtModeloNome.Text.ToString();

            if (ddlMarca.SelectedValue != "")
                mod.Marca = new MarcaBusiness().retornaId(long.Parse(ddlMarca.SelectedValue));

            ModeloDAO gravamod = new ModeloDAO();
            gravamod.AdicionaModelo(mod);

            Response.Redirect("CadastroDeModelo.aspx");

        }
    }
}