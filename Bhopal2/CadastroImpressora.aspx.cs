using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bhopal2.DAO;
using Bhopal2.Models;
using Bhopal2.Business;

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
                var fornecedores = f.getAll();
                if (fornecedores.Count > 0)
                {
                    ddlFornecedor.DataValueField = "Id";
                    ddlFornecedor.DataTextField = "Nome";
                    ddlFornecedor.DataSource = fornecedores;
                    ddlFornecedor.DataBind();
                }
                //Modelo
                var m = new ModeloDAO();
                var modelos = m.getAll();
                if (modelos.Count > 0)
                {
                    ddlModelo.DataValueField = "Id";
                    ddlModelo.DataTextField = "Nome";
                    ddlModelo.DataSource = modelos;
                    ddlModelo.DataBind();
                }
                //Departamento
                var d = new FilialDAO();
                var departamentos = d.getAll();
                if (departamentos.Count > 0)
                {
                    ddlDepartamento.DataValueField = "Id";
                    ddlDepartamento.DataTextField = "Nome";
                    ddlDepartamento.DataSource = departamentos;
                    ddlDepartamento.DataBind();
                }
                //Marca
                var mc = new MarcaDAO();
                var marcas = mc.getAll();
                if (marcas.Count > 0)
                {
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataTextField = "Nome";
                    ddlMarca.DataSource = marcas;
                    ddlMarca.DataBind();
                }
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //salvando os dados do cadastro de impressora
            Impressora imp = new Impressora();
            imp.Tipo = txtTipo.Text.ToString();
            imp.Codigo = txtCodigoImpressora.Text.ToString();

            if (ddlFornecedor.SelectedValue != "")
                imp.Fornecedor = new FornecedorBusiness().retornaId(long.Parse(ddlFornecedor.SelectedValue));

            if (ddlModelo.SelectedValue != "")
                imp.Modelo = new ModeloBusiness().retornaId(long.Parse(ddlModelo.SelectedValue));

            if (ddlMarca.SelectedValue != "")
                imp.Marca = new MarcaBusiness().retornaId(long.Parse(ddlMarca.SelectedValue));

            if (ddlDepartamento.SelectedValue != "")
                imp.Departamento = new DepartamentoBusiness().retornaId(long.Parse(ddlDepartamento.SelectedValue));

            var gravarImpressora = new ImpressoraDAO();
            gravarImpressora.AdicionaImpressora(imp);

            Response.Redirect("/");
        }

        protected void txtModeloNome_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtCodigoImpressora_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlToner_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}