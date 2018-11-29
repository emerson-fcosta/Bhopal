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

    public partial class CadastroDeDepartamento : System.Web.UI.Page
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
            //Carregando os dados no dropdown list
            //Departamento
            FilialDAO f = new FilialDAO();
            var filiais = f.ObterTodos();
            if (filiais.Count > 0)
            {
                ddlFilial.DataValueField = "Id";
                ddlFilial.DataTextField = "Nome";
                ddlFilial.DataSource = filiais;
                ddlFilial.DataBind();
                ddlFilial.Items.Insert(0, "Selecione");
            }
        }

        void AtualizaFormulario(long Id)
        {
            var i = new DepartamentoDAO().ObterPeloId(Id);

            txtId.Text = i.Id.ToString();
            txtNomeDept.Text = i.Nome;

            if (i.Filial != null)
            {
                ddlFilial.SelectedValue = i.Filial.Id.ToString();
            }
        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            //gravando os dados do departamento
            Departamento dep = new Departamento();
            var dao = new DepartamentoDAO();

            if (txtId.Text != string.Empty)
            {
                dep = dao.ObterPeloId(long.Parse(txtId.Text));
            }
            
            dep.Nome = txtNomeDept.Text.ToString();

            if (ddlFilial.SelectedValue != "")
                dep.Filial = new FilialDAO().ObterPeloId(ddlFilial.SelectedValue);

            dao.Salvar(dep);

            Response.Redirect("Departamentos.aspx");
        }
    }
}