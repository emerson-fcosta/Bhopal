﻿using Bhopal2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhopal2
{
    public partial class Marcas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var dao = new MarcaDAO();
                var marcas = dao.GetAll();

                GridViewMarcas.DataSource = marcas;
                GridViewMarcas.DataBind();

                if (marcas.Count > 0)
                    GridViewMarcas.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}