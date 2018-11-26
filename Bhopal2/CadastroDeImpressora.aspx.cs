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
            //carregando dados no dropDownList
            //Fornecedor
            var f = new FornecedorDAO();
            var fornecedores = f.GetAll();
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
            var filiais = filial.GetAll();
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

        void AtualizaFormulario(long Id)
        {
            var i = new ImpressoraDAO().getById(Id.ToString());

            txtId.Text = i.Id.ToString();
            txtTipo.Text = i.Tipo;
            txtCodigoImpressora.Text = i.Codigo;

            if (i.Fornecedor != null)
            {
                ddlFornecedor.SelectedValue = i.Fornecedor.Id.ToString();
            }

            if (i.Marca != null)
            {
                ddlMarca.SelectedValue = i.Marca.Id.ToString();
                ddlMarca_SelectedIndexChanged(this, EventArgs.Empty);
            }

            if (i.Modelo != null)
            {
                ddlModelo.SelectedValue = i.Modelo.Id.ToString();
            }

            if (i.Filial != null)
            {
                ddlFilial.SelectedValue = i.Filial.Id.ToString();
                ddlFilial_SelectedIndexChanged(this, EventArgs.Empty);
            }

            if (i.Departamento != null)
            {
                ddlDepartamento.SelectedValue = i.Departamento.Id.ToString();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Impressora imp = new Impressora();
            var dao = new ImpressoraDAO();

            //salvando os dados do cadastro de impressora
            if (txtId.Text != string.Empty)
            {
                imp = dao.getById(txtId.Text);
            }

            imp.Tipo = txtTipo.Text.ToString();
            imp.Codigo = txtCodigoImpressora.Text.ToString();

            if (ddlFornecedor.SelectedValue != "")
                imp.Fornecedor = new FornecedorBusiness().retornaId(long.Parse(ddlFornecedor.SelectedValue));

            if (ddlModelo.SelectedIndex > 0)
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

            if (ddlFilial.SelectedIndex > 0)
            {
                imp.Filial = new FilialBusiness().retornaId(long.Parse(ddlFilial.SelectedValue));
            }

            if (ddlDepartamento.SelectedIndex > 0)
            {
                imp.Departamento = new DepartamentoBusiness().retornaId(long.Parse(ddlDepartamento.SelectedValue));
            }

            dao.AdicionaImpressora(imp);

            Response.Redirect("Impressoras.aspx");
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
            var modelos = m.ObterTodos().Where(x => x.Marca.Id.ToString() == ddlMarca.SelectedValue).ToList();
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
            var departamentos = d.getByFilial(new FilialDAO().GetById(ddlFilial.SelectedValue));
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