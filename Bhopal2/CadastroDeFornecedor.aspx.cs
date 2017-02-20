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
    public partial class CadastroDeFornecedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            Fornecedor f = new Fornecedor();
            Contato c = new Contato();
            f.Nome = txtFornecedor.Text.ToString();
            c.Nome = txtContato.Text.ToString();
            c.Telefone = txtTelefone.ToString();

            FornecedorDAO forn = new FornecedorDAO();
            ContatoDAO contato = new ContatoDAO();
            forn.AdicionaFornecedor(f);
            contato.AdicionaContato(c);
            
            //Response.Write("Cadastro realizado com sucesso");
            Response.Redirect("/CadastroDeFornecedor.aspx");
            
        }
    }
}