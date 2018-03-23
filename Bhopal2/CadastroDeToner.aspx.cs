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
    public partial class CadastroDeToner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Carregando dados no DropDownList
                //Impressora
                var i = new ImpressoraDAO();
                var impressoras = i.getAll();
                if (impressoras.Count > 0)
                {
                    ddlImpressora.DataValueField = "Id";
                    ddlImpressora.DataTextField = "Codigo";
                    ddlImpressora.DataSource = impressoras;
                    ddlImpressora.DataBind();
                    ddlImpressora.Items.Insert(0, "Selecione");
                }

            }

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Toner t = new Toner();
            t.Cor = TextBox1.Text.ToString();
            t.Codigo = TextBox2.Text.ToString();
            t.Colorido = CheckBox1.Checked;

            if (ddlImpressora.SelectedValue != "")
                t.Impressora = new ImpressoraBusiness().GetByID(long.Parse(ddlImpressora.SelectedValue));
            
            var gravaToner = new TonerDAO();
            gravaToner.AdicionaToner(t);

            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}