﻿using Bhopal2.DAO;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhopal2
{
    public partial class Departamentos : System.Web.UI.Page
    {
        IList<Departamento> lista;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridView();
            }

            if (lista != null)
                GridViewDepartamentos.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        private void BindGridView()
        {
            lista = new DepartamentoDAO().ObterTodos();

            GridViewDepartamentos.DataSource = lista;
            GridViewDepartamentos.DataBind();
        }


        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //recupera o id da linha
            var i = int.Parse(e.CommandArgument.ToString());

            //capturando o id do registro na grid
            var id = GridViewDepartamentos.Rows[i].Cells.Cast<DataControlFieldCell>()
                            .Where(a => a.ContainingField.HeaderText == "Id")
                            .Select(a => a.Text).FirstOrDefault();

            switch (e.CommandName)
            {
                case "Edit":
                    Response.Redirect($"cadastrodedepartamento.aspx?id={id}");
                    break;

                case "Delete":
                    DeletarRegistro(long.Parse(id)); //apaga o registro
                    Response.Redirect($"departamentos.aspx"); //recarrega a pagina
                    break;

                default:
                    break;
            }
        }

        private void DeletarRegistro(long id)
        {
            new ModeloDAO().Deletar(id);
        }
    }
}