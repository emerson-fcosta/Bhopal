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
    public partial class CadastroDeImpressora : System.Web.UI.Page
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
                    ddlFornecedor.Items.Insert(0, "Selecione");
                }
                //Modelo
                //var m = new ModeloDAO();
                //var modelos = m.getAll();
                //if (modelos.Count > 0)
                //{
                //    ddlModelo.DataValueField = "Id";
                //    ddlModelo.DataTextField = "Nome";
                //    ddlModelo.DataSource = modelos;
                //    ddlModelo.DataBind();
                //}
                //Filial
                var filial = new FilialDAO();
                var filiais = filial.getAll();
                if (filiais.Count > 0)
                {
                    ddlFilial.DataValueField = "Id";
                    ddlFilial.DataTextField = "Nome";
                    ddlFilial.DataSource = filiais;
                    ddlFilial.DataBind();
                    ddlFilial.Items.Insert(0, "Selecione");
                }
                //Departamento
                //var departamento = new DepartamentoDAO();
                //var departamentos = departamento.getAll();
                //if (departamentos.Count > 0)
                //{
                //    ddlDepartamento.DataValueField = "Id";
                //    ddlDepartamento.DataTextField = "Nome";
                //    ddlDepartamento.DataSource = departamentos;
                //    ddlDepartamento.DataBind();
                //}
                //Marca
                var mc = new MarcaDAO();
                var marcas = mc.GetAll();
                if (marcas.Count > 0)
                {
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataTextField = "Nome";
                    ddlMarca.DataSource = marcas;
                    ddlMarca.DataBind();
                    ddlMarca.Items.Insert(0, "Selecione");
                }

                //Toner
                //var t = new TonerDAO();
                //var toneres = t.getAll();
                //if (toneres.Count > 0)
                //{
                //    ddlToner.DataValueField = "Id";
                //    ddlToner.DataTextField = "Codigo";
                //    ddlToner.DataSource = toneres;
                //    ddlToner.DataBind();
                //}

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
            {
                imp.Modelo = new ModeloBusiness().retornaId(long.Parse(ddlModelo.SelectedValue));
                //imp.Marca = imp.Modelo.Marca;
            }
            //if (ddlToner.SelectedValue != "")
            //{
            //    imp.Toner = new TonerBusiness().retornaId(long.Parse(ddlToner.SelectedValue));
            //}

            //if (ddlMarca.SelectedValue != "")
            //    imp.Marca = new MarcaBusiness().retornaId(long.Parse(ddlMarca.SelectedValue));

            if (ddlFilial.SelectedValue != "")
            {
                imp.Filial = new FilialBusiness().retornaId(long.Parse(ddlFilial.SelectedValue));
            }

            if (ddlDepartamento.SelectedValue != "")
            {
                imp.Departamento = new DepartamentoBusiness().retornaId(long.Parse(ddlDepartamento.SelectedValue));
            }

            var dao = new ImpressoraDAO();
            dao.AdicionaImpressora(imp);

            Response.Redirect("CadastroDeImpressora.aspx");
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
            //Modelo
            var m = new ModeloDAO();
            var modelos = m.GetAll().Where(x => x.Marca.Id.ToString() == ddlMarca.SelectedValue).ToList();
            ddlModelo.DataValueField = "Id";
            ddlModelo.DataTextField = "Nome";
            ddlModelo.DataSource = modelos;
            ddlModelo.DataBind();
            ddlModelo.Items.Insert(0, "Selecione");
        }

        protected void ddlToner_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlFilial_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Departamento
            var d = new DepartamentoDAO();
            var departamentos = d.getByFilial(new FilialDAO().getById(ddlFilial.SelectedValue));
            if (departamentos.Count > 0)
            {
                ddlDepartamento.DataValueField = "Id";
                ddlDepartamento.DataTextField = "Nome";
                ddlDepartamento.DataSource = departamentos;
                ddlDepartamento.DataBind();
                ddlDepartamento.Items.Insert(0, "Selecione");
            }
        }

        protected void ddlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}