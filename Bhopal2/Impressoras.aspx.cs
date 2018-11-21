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
    public partial class Impressoras : System.Web.UI.Page
    {
        IList<Impressora> lista;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }

            if (lista != null)
                GridViewImpressora.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //recupera o id da linha
            var i = int.Parse(e.CommandArgument.ToString());

            //capturando o id do registro na grid
            var id = GridViewImpressora.Rows[i].Cells.Cast<DataControlFieldCell>()
                            .Where(a => a.ContainingField.HeaderText == "Id")
                            .Select(a => a.Text).FirstOrDefault();

            switch (e.CommandName)
            {
                case "Edit":
                    Response.Redirect($"cadastrodeimpressora.aspx?id={id}");
                    break;

                case "Delete":
                    DeletarRegistro(long.Parse(id)); //apaga o registro
                    Response.Redirect($"impressoras.aspx"); //recarrega a pagina
                    break;

                default:
                    break;
            }
        }

        private void DeletarRegistro(long id)
        {
            new ImpressoraDAO().RemoveImpressora(id);
        }

        private void BindGridView()
        {
            lista = new ImpressoraDAO().GetAll();
            GridViewImpressora.DataSource = lista;
            GridViewImpressora.DataBind();
        }
    }
}