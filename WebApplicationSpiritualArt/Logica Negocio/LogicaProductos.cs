using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationSpiritualArt.Models;

namespace WebApplicationSpiritualArt.Logica_Negocio
{
    public class LogicaProductos
    {
        
        //listar obras de los artistas premium
        public List<PRODUCTO> listarObrasPremium()
        {
            using (BD_SPIRITUAL_ARTEntities bd = new BD_SPIRITUAL_ARTEntities())
            {
                return bd.PRODUCTO.Include("REGISTRO_ARTISTA").Where(p => p.REGISTRO_ARTISTA.FK_TIPO_PLAN == 9).ToList();
            }
        }
        //Agregar obras

        public void AgregarObra(PRODUCTO nuevaObra)
        {
            using (BD_SPIRITUAL_ARTEntities bd = new BD_SPIRITUAL_ARTEntities())
            {
                bd.PRODUCTO.Add(nuevaObra);
                bd.SaveChanges();
            }
        }

        //método que consulta las obras específicas de un solo artista
        public List<PRODUCTO> consultarObra(int fk_artista)
        {
            using (BD_SPIRITUAL_ARTEntities bd = new BD_SPIRITUAL_ARTEntities())
            {
                return bd.PRODUCTO.Where(P => P.FK_ARTISTA == fk_artista).ToList();
            }
        }

        //listar todas las obras con los artistas

        public List<PRODUCTO> listarObras()
        {
            using (BD_SPIRITUAL_ARTEntities bd = new BD_SPIRITUAL_ARTEntities())
            {
                return bd.PRODUCTO.Include("REGISTRO_ARTISTA").ToList();
            }
        }

        public List<PRODUCTO> listarObras(int id_categoria)
        {
            using (BD_SPIRITUAL_ARTEntities bd = new BD_SPIRITUAL_ARTEntities())
            {
                return bd.PRODUCTO.Include("REGISTRO_ARTISTA").Where(P => P.FK_CATEGORIA == id_categoria).ToList();
            }
        }
    }
}