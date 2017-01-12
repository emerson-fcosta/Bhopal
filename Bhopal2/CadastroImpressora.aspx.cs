using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bhopal2.DAO;

namespace Bhopal2
{
    public partial class CadastroImpressora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //carregando dados no dropDownList
                //Fornecedor
                var f = new FornecedorDAO();
                var IMPRESSORAS = f.getAll();
                ddlFornecedor.DataValueField = "Id";
                ddlFornecedor.DataTextField = "Nome";
                ddlFornecedor.DataSource = IMPRESSORAS;
                ddlFornecedor.DataBind();
                //Modelo
                var m = new ModeloDAO();
                var modelos = m.getAll();
                ddlModelo.DataValueField = "Id";
                ddlModelo.DataTextField = "Nome";
                ddlModelo.DataSource = IMPRESSORAS;
                ddlModelo.DataBind();
                //Departamento
                var d = new DepartamentoDAO();
                var departamentos = d.getAll();
                ddlDepartamento.DataValueField = "Id";
                ddlDepartamento.DataTextField = "Nome";
                ddlDepartamento.DataSource = IMPRESSORAS;
                ddlDepartamento.DataBind();
            }
        }
    }
}