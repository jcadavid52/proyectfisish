using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationSpiritualArt.Models;
namespace WebApplicationSpiritualArt.Logica_Negocio
{
    public class LogicaPlanes
    {
        //listar planes
        public List<TIPO_PLAN> listarPlanes(int? id_tipoPlan)
        {
            using (BD_SPIRITUAL_ARTEntities bd = new BD_SPIRITUAL_ARTEntities())
            {
                var planes = bd.TIPO_PLAN.Where(P => P.PK_ID_TIPO_PLAN == id_tipoPlan).ToList();

                return planes;
            }
        }

        public List<TIPO_PLAN> listarPlanes()
        {
            using (BD_SPIRITUAL_ARTEntities bd = new BD_SPIRITUAL_ARTEntities())
            {
                return bd.TIPO_PLAN.ToList();

                
            }
        }
    }
}