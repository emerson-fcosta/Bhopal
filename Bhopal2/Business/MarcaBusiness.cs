﻿using Bhopal2.Infra;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Business
{
    public class MarcaBusiness
    {

        public Marca retornaId(long id)
        {
            var session = NHibernateHelper.GetSession();
            return session.Get<Marca>(id);
        }
    }
}