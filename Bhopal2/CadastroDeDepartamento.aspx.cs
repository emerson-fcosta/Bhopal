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
    public partial class CadastroDeDepartamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                //Carregando os dados no dropdown list
                //Departamento
                FilialDAO f = new FilialDAO();
                var filiais = f.getAll();
                if (filiais.Count > 0)
                {
                    ddlFilial.DataValueField = "Id";
                    ddlFilial.DataTextField = "Nome";
                    ddlFilial.DataSource = filiais;
                    ddlFilial.DataBind();
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //gravando os dados do departamento
            Departamento dep = new Departamento();
            dep.Nome = txtNomeDept.Text.ToString();

            if (ddlFilial.SelectedValue != "")
                dep.Filial = new FilialBusiness().retornaId(long.Parse(ddlFilial.SelectedValue));

            DepartamentoDAO gravardep = new DepartamentoDAO();
            gravardep.AdicionaDepartamento(dep);

            Response.Redirect("/");
        }
    }
}