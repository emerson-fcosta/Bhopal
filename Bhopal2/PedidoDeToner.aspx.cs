using Bhopal2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhopal2
{
    public partial class PedidoDeToner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
                {
                //carrega dados no drop down list
                //Filial
                var filial = new FilialDAO();
                var filiais = filial.GetAll();
                if (filiais.Count > 0)
                {
                    ddlFilial.DataValueField = "Id";
                    ddlFilial.DataTextField = "Nome";
                    ddlFilial.DataSource = filiais;
                    ddlFilial.DataBind();
                }
                //Departamento
                var departamento = new DepartamentoDAO();
                var departamentos = departamento.GetAll();
                if (departamentos.Count > 0)
                {
                    //ddlDepartamento.DataValueField = "Id";
                    ddlDepartamento.DataTextField = "Nome";
                    ddlDepartamento.DataSource = departamentos;
                    ddlDepartamento.DataBind();
                }
                //Marca
                var mc = new MarcaDAO();
                var marcas = mc.GetAll();
                if (marcas.Count > 0)
                {
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataTextField = "Nome";
                    ddlMarca.DataSource = marcas;
                    ddlMarca.DataBind();
                }

                //Toner
                var t = new TonerDAO();
                var toneres = t.ObterTodos();
                if (toneres.Count > 0)
                {
                    ddlToner.DataValueField = "Id";
                    ddlToner.DataTextField = "Codigo";
                    ddlToner.DataSource = toneres;
                    ddlToner.DataBind();
                }

            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            PedidoDeToner p = new PedidoDeToner();
            
        }
    }
}