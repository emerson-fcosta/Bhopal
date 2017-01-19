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
                //Marca
                var mc = new MarcaDAO();
                var marcas = mc.getAll();
                ddlMarca.DataValueField = "Id";
                ddlMarca.DataTextField = "Nome";
                ddlMarca.DataSource = marcas;
                ddlMarca.DataBind();
                //Toner
                var t = new TonerDAO();
                var toneres = t.getAll();
                ddlToner.DataValueField="Id";
                ddlToner.DataTextField = "Codigo";
                ddlToner.DataSource = toneres;
                ddlToner.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //salvando os dados do cadastro de impressora
            Impressora imp = new Impressora();
            imp.Tipo = txtTipo.Text.ToString();
            imp.Codigo = txtCodigoImpressora.Text.ToString();

            imp.Fornecedores = new List<Fornecedor>()
            {
                new FornecedorBusiness().retornaId(long.Parse(ddlFornecedor.SelectedValue))

            };

            imp.Modelos = new List<Modelo>()
            {
                new ModeloBusiness().retornaId(long.Parse(ddlModelo.SelectedValue))
            };

            imp.Marcas = new List<Marca>()
            {
                new MarcaBusiness().retornaId(long.Parse(ddlMarca.SelectedValue))
            };

            imp.Departamentos = new List<Departamento>()
            {
                new DepartamentoBusiness().retornaId(long.Parse(ddlDepartamento.SelectedValue))
            };

            imp.Toneres = new List<Toner>()
            {
                new TonerBusiness().retornaId(long.Parse(ddlToner.SelectedValue))
            };

            var gravaImpressora = new ImpressoraDAO();
            gravaImpressora.AdicionaImpressora(imp);
            

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