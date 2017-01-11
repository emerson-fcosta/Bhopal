using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bhopal2.DAO;
using Bhopal2.Models;
using System.Activities.Expressions;
using Bhopal2.Business;

namespace Bhopal2
{
    public partial class CadastroToner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ImpressoraBusiness i = new ImpressoraBusiness();
                var IMPRESSORAS = i.retornaImpressoras();

                DropDownList1.DataTextField = "Nome";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataSource = IMPRESSORAS;
                DropDownList1.DataBind();
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
            t.Impressoras = new List<Impressora>() {
                new ImpressoraBusiness().GetByID(long.Parse(DropDownList1.SelectedValue))
            };
            //i.Id = 

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