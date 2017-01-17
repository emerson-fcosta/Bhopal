using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bhopal2.DAO;
using Bhopal2.Models;

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
                var impressoras = f.getAll();
                ddlFornecedor.DataValueField = "Id";
                ddlFornecedor.DataTextField = "Nome";
                ddlFornecedor.DataSource = impressoras;
                ddlFornecedor.DataBind();
                //Modelo
                var m = new ModeloDAO();
                var modelos = m.getAll();
                ddlModelo.DataValueField = "Id";
                ddlModelo.DataTextField = "Nome";
                ddlModelo.DataSource = modelos;
                ddlModelo.DataBind();
                //Departamento
                var d = new DepartamentoDAO();
                var departamentos = d.getAll();
                ddlDepartamento.DataValueField = "Id";
                ddlDepartamento.DataTextField = "Nome";
                ddlDepartamento.DataSource = departamentos;
                ddlDepartamento.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //salvando os dados do cadastro de impressora
            Impressora imp = new Impressora();
            imp.Codigo = txtModeloNome.Text;
            imp.Tipo = txtCodigoImpressora.Text;
            //falta completar o metodo - farei mais tarde
        }

        protected void txtModeloNome_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtCodigoImpressora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}