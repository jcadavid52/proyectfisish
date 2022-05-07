﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationSpiritualArt.Models;

namespace WebApplicationSpiritualArt.Logica_Negocio
{
    public class LogicaCategoria
    {
        //listar categoría
        public List<CATEGORIA> listarCategoria()
        {
            using (BD_SPIRITUAL_ARTEntities bd = new BD_SPIRITUAL_ARTEntities())
            {
                return bd.CATEGORIA.ToList();
            }
        }
    }
}