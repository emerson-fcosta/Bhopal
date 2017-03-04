using Bhopal2.DAO;
using Bhopal2.Infra;
using Bhopal2.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhopal2.scripts
{
    public partial class PedidoDeToner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var f = new FilialDAO();
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
            }

        }

        protected void ddlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Impressora
            var i = new ImpressoraDAO();
            var impressoras = i.getByDepartamento(new DepartamentoDAO().getById(ddlDepartamento.SelectedValue));
            if (impressoras.Count > 0)
            {
                ddlImpressora.DataValueField = "Id";
                ddlImpressora.DataTextField = "Nome";
                ddlImpressora.DataSource = impressoras;
                ddlImpressora.DataBind();
            }

        }

        protected void ddlImpressora_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Toner
            var t = new TonerDAO();
            var toneres = t.getByImpressora(new ImpressoraDAO().getById(ddlImpressora.SelectedValue));
            if (toneres.Count > 0)
            {
                ddlToner.DataValueField = "Id";
                ddlToner.DataTextField = "Codigo";
                ddlToner.DataSource = toneres;
                ddlToner.DataBind();
            }
            
        }
    }
}