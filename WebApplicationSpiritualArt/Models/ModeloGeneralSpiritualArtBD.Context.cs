//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationSpiritualArt.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BD_SPIRITUAL_ARTEntities : DbContext
    {
        public BD_SPIRITUAL_ARTEntities()
            : base("name=BD_SPIRITUAL_ARTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<REGISTRO_ARTISTA> REGISTRO_ARTISTA { get; set; }
        public virtual DbSet<TIPO_PLAN> TIPO_PLAN { get; set; }
    
        public virtual int SP_REGISTRAR_ARTISTA(string nOMBRE_ARTISTA, string pRIMER_APELLIDO_ARTISTA, string sEGUNDO_APELLIDO_ARTISTA, string tELEFONO, string cORREO, string pAIS, string cIUDAD, string lOCALIDAD, string dIRECCION, Nullable<int> fK_TIPO_PLAN)
        {
            var nOMBRE_ARTISTAParameter = nOMBRE_ARTISTA != null ?
                new ObjectParameter("NOMBRE_ARTISTA", nOMBRE_ARTISTA) :
                new ObjectParameter("NOMBRE_ARTISTA", typeof(string));
    
            var pRIMER_APELLIDO_ARTISTAParameter = pRIMER_APELLIDO_ARTISTA != null ?
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", pRIMER_APELLIDO_ARTISTA) :
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", typeof(string));
    
            var sEGUNDO_APELLIDO_ARTISTAParameter = sEGUNDO_APELLIDO_ARTISTA != null ?
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", sEGUNDO_APELLIDO_ARTISTA) :
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", typeof(string));
    
            var tELEFONOParameter = tELEFONO != null ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var pAISParameter = pAIS != null ?
                new ObjectParameter("PAIS", pAIS) :
                new ObjectParameter("PAIS", typeof(string));
    
            var cIUDADParameter = cIUDAD != null ?
                new ObjectParameter("CIUDAD", cIUDAD) :
                new ObjectParameter("CIUDAD", typeof(string));
    
            var lOCALIDADParameter = lOCALIDAD != null ?
                new ObjectParameter("LOCALIDAD", lOCALIDAD) :
                new ObjectParameter("LOCALIDAD", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            var fK_TIPO_PLANParameter = fK_TIPO_PLAN.HasValue ?
                new ObjectParameter("FK_TIPO_PLAN", fK_TIPO_PLAN) :
                new ObjectParameter("FK_TIPO_PLAN", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_REGISTRAR_ARTISTA", nOMBRE_ARTISTAParameter, pRIMER_APELLIDO_ARTISTAParameter, sEGUNDO_APELLIDO_ARTISTAParameter, tELEFONOParameter, cORREOParameter, pAISParameter, cIUDADParameter, lOCALIDADParameter, dIRECCIONParameter, fK_TIPO_PLANParameter);
        }
    
        public virtual int SP_REGISTRAR_ARTISTA1(string nOMBRE_ARTISTA, string pRIMER_APELLIDO_ARTISTA, string sEGUNDO_APELLIDO_ARTISTA, string tELEFONO, string cORREO, string pAIS, string cIUDAD, string lOCALIDAD, string dIRECCION, Nullable<int> fK_TIPO_PLAN, Nullable<int> cLAVE)
        {
            var nOMBRE_ARTISTAParameter = nOMBRE_ARTISTA != null ?
                new ObjectParameter("NOMBRE_ARTISTA", nOMBRE_ARTISTA) :
                new ObjectParameter("NOMBRE_ARTISTA", typeof(string));
    
            var pRIMER_APELLIDO_ARTISTAParameter = pRIMER_APELLIDO_ARTISTA != null ?
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", pRIMER_APELLIDO_ARTISTA) :
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", typeof(string));
    
            var sEGUNDO_APELLIDO_ARTISTAParameter = sEGUNDO_APELLIDO_ARTISTA != null ?
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", sEGUNDO_APELLIDO_ARTISTA) :
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", typeof(string));
    
            var tELEFONOParameter = tELEFONO != null ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var pAISParameter = pAIS != null ?
                new ObjectParameter("PAIS", pAIS) :
                new ObjectParameter("PAIS", typeof(string));
    
            var cIUDADParameter = cIUDAD != null ?
                new ObjectParameter("CIUDAD", cIUDAD) :
                new ObjectParameter("CIUDAD", typeof(string));
    
            var lOCALIDADParameter = lOCALIDAD != null ?
                new ObjectParameter("LOCALIDAD", lOCALIDAD) :
                new ObjectParameter("LOCALIDAD", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            var fK_TIPO_PLANParameter = fK_TIPO_PLAN.HasValue ?
                new ObjectParameter("FK_TIPO_PLAN", fK_TIPO_PLAN) :
                new ObjectParameter("FK_TIPO_PLAN", typeof(int));
    
            var cLAVEParameter = cLAVE.HasValue ?
                new ObjectParameter("CLAVE", cLAVE) :
                new ObjectParameter("CLAVE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_REGISTRAR_ARTISTA1", nOMBRE_ARTISTAParameter, pRIMER_APELLIDO_ARTISTAParameter, sEGUNDO_APELLIDO_ARTISTAParameter, tELEFONOParameter, cORREOParameter, pAISParameter, cIUDADParameter, lOCALIDADParameter, dIRECCIONParameter, fK_TIPO_PLANParameter, cLAVEParameter);
        }
    
        public virtual int SP_REGISTRAR_ARTISTA2(string nOMBRE_ARTISTA, string pRIMER_APELLIDO_ARTISTA, string sEGUNDO_APELLIDO_ARTISTA, string tELEFONO, string cORREO, string pAIS, string cIUDAD, string lOCALIDAD, string dIRECCION, Nullable<int> fK_TIPO_PLAN, Nullable<int> cLAVE)
        {
            var nOMBRE_ARTISTAParameter = nOMBRE_ARTISTA != null ?
                new ObjectParameter("NOMBRE_ARTISTA", nOMBRE_ARTISTA) :
                new ObjectParameter("NOMBRE_ARTISTA", typeof(string));
    
            var pRIMER_APELLIDO_ARTISTAParameter = pRIMER_APELLIDO_ARTISTA != null ?
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", pRIMER_APELLIDO_ARTISTA) :
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", typeof(string));
    
            var sEGUNDO_APELLIDO_ARTISTAParameter = sEGUNDO_APELLIDO_ARTISTA != null ?
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", sEGUNDO_APELLIDO_ARTISTA) :
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", typeof(string));
    
            var tELEFONOParameter = tELEFONO != null ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var pAISParameter = pAIS != null ?
                new ObjectParameter("PAIS", pAIS) :
                new ObjectParameter("PAIS", typeof(string));
    
            var cIUDADParameter = cIUDAD != null ?
                new ObjectParameter("CIUDAD", cIUDAD) :
                new ObjectParameter("CIUDAD", typeof(string));
    
            var lOCALIDADParameter = lOCALIDAD != null ?
                new ObjectParameter("LOCALIDAD", lOCALIDAD) :
                new ObjectParameter("LOCALIDAD", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            var fK_TIPO_PLANParameter = fK_TIPO_PLAN.HasValue ?
                new ObjectParameter("FK_TIPO_PLAN", fK_TIPO_PLAN) :
                new ObjectParameter("FK_TIPO_PLAN", typeof(int));
    
            var cLAVEParameter = cLAVE.HasValue ?
                new ObjectParameter("CLAVE", cLAVE) :
                new ObjectParameter("CLAVE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_REGISTRAR_ARTISTA2", nOMBRE_ARTISTAParameter, pRIMER_APELLIDO_ARTISTAParameter, sEGUNDO_APELLIDO_ARTISTAParameter, tELEFONOParameter, cORREOParameter, pAISParameter, cIUDADParameter, lOCALIDADParameter, dIRECCIONParameter, fK_TIPO_PLANParameter, cLAVEParameter);
        }
    
        public virtual int SP_REGISTRAR_ARTISTA3(string nOMBRE_ARTISTA, string pRIMER_APELLIDO_ARTISTA, string sEGUNDO_APELLIDO_ARTISTA, string tELEFONO, string cORREO, string pAIS, string cIUDAD, string lOCALIDAD, string dIRECCION, Nullable<int> fK_TIPO_PLAN, Nullable<int> cLAVE)
        {
            var nOMBRE_ARTISTAParameter = nOMBRE_ARTISTA != null ?
                new ObjectParameter("NOMBRE_ARTISTA", nOMBRE_ARTISTA) :
                new ObjectParameter("NOMBRE_ARTISTA", typeof(string));
    
            var pRIMER_APELLIDO_ARTISTAParameter = pRIMER_APELLIDO_ARTISTA != null ?
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", pRIMER_APELLIDO_ARTISTA) :
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", typeof(string));
    
            var sEGUNDO_APELLIDO_ARTISTAParameter = sEGUNDO_APELLIDO_ARTISTA != null ?
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", sEGUNDO_APELLIDO_ARTISTA) :
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", typeof(string));
    
            var tELEFONOParameter = tELEFONO != null ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var pAISParameter = pAIS != null ?
                new ObjectParameter("PAIS", pAIS) :
                new ObjectParameter("PAIS", typeof(string));
    
            var cIUDADParameter = cIUDAD != null ?
                new ObjectParameter("CIUDAD", cIUDAD) :
                new ObjectParameter("CIUDAD", typeof(string));
    
            var lOCALIDADParameter = lOCALIDAD != null ?
                new ObjectParameter("LOCALIDAD", lOCALIDAD) :
                new ObjectParameter("LOCALIDAD", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            var fK_TIPO_PLANParameter = fK_TIPO_PLAN.HasValue ?
                new ObjectParameter("FK_TIPO_PLAN", fK_TIPO_PLAN) :
                new ObjectParameter("FK_TIPO_PLAN", typeof(int));
    
            var cLAVEParameter = cLAVE.HasValue ?
                new ObjectParameter("CLAVE", cLAVE) :
                new ObjectParameter("CLAVE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_REGISTRAR_ARTISTA3", nOMBRE_ARTISTAParameter, pRIMER_APELLIDO_ARTISTAParameter, sEGUNDO_APELLIDO_ARTISTAParameter, tELEFONOParameter, cORREOParameter, pAISParameter, cIUDADParameter, lOCALIDADParameter, dIRECCIONParameter, fK_TIPO_PLANParameter, cLAVEParameter);
        }
    
        public virtual int SP_REGISTRAR_ARTISTA4(string nOMBRE_ARTISTA, string pRIMER_APELLIDO_ARTISTA, string sEGUNDO_APELLIDO_ARTISTA, string tELEFONO, string cORREO, string pAIS, string cIUDAD, string lOCALIDAD, string dIRECCION, Nullable<int> fK_TIPO_PLAN)
        {
            var nOMBRE_ARTISTAParameter = nOMBRE_ARTISTA != null ?
                new ObjectParameter("NOMBRE_ARTISTA", nOMBRE_ARTISTA) :
                new ObjectParameter("NOMBRE_ARTISTA", typeof(string));
    
            var pRIMER_APELLIDO_ARTISTAParameter = pRIMER_APELLIDO_ARTISTA != null ?
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", pRIMER_APELLIDO_ARTISTA) :
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", typeof(string));
    
            var sEGUNDO_APELLIDO_ARTISTAParameter = sEGUNDO_APELLIDO_ARTISTA != null ?
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", sEGUNDO_APELLIDO_ARTISTA) :
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", typeof(string));
    
            var tELEFONOParameter = tELEFONO != null ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var pAISParameter = pAIS != null ?
                new ObjectParameter("PAIS", pAIS) :
                new ObjectParameter("PAIS", typeof(string));
    
            var cIUDADParameter = cIUDAD != null ?
                new ObjectParameter("CIUDAD", cIUDAD) :
                new ObjectParameter("CIUDAD", typeof(string));
    
            var lOCALIDADParameter = lOCALIDAD != null ?
                new ObjectParameter("LOCALIDAD", lOCALIDAD) :
                new ObjectParameter("LOCALIDAD", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            var fK_TIPO_PLANParameter = fK_TIPO_PLAN.HasValue ?
                new ObjectParameter("FK_TIPO_PLAN", fK_TIPO_PLAN) :
                new ObjectParameter("FK_TIPO_PLAN", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_REGISTRAR_ARTISTA4", nOMBRE_ARTISTAParameter, pRIMER_APELLIDO_ARTISTAParameter, sEGUNDO_APELLIDO_ARTISTAParameter, tELEFONOParameter, cORREOParameter, pAISParameter, cIUDADParameter, lOCALIDADParameter, dIRECCIONParameter, fK_TIPO_PLANParameter);
        }
    
        public virtual int SP_REGISTRAR_ARTISTA5(string nOMBRE_ARTISTA, string pRIMER_APELLIDO_ARTISTA, string sEGUNDO_APELLIDO_ARTISTA, string tELEFONO, string cORREO, string pAIS, string cIUDAD, string lOCALIDAD, string dIRECCION, Nullable<int> fK_TIPO_PLAN, Nullable<int> cLAVE, Nullable<bool> eSTADO, string iMAGEN)
        {
            var nOMBRE_ARTISTAParameter = nOMBRE_ARTISTA != null ?
                new ObjectParameter("NOMBRE_ARTISTA", nOMBRE_ARTISTA) :
                new ObjectParameter("NOMBRE_ARTISTA", typeof(string));
    
            var pRIMER_APELLIDO_ARTISTAParameter = pRIMER_APELLIDO_ARTISTA != null ?
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", pRIMER_APELLIDO_ARTISTA) :
                new ObjectParameter("PRIMER_APELLIDO_ARTISTA", typeof(string));
    
            var sEGUNDO_APELLIDO_ARTISTAParameter = sEGUNDO_APELLIDO_ARTISTA != null ?
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", sEGUNDO_APELLIDO_ARTISTA) :
                new ObjectParameter("SEGUNDO_APELLIDO_ARTISTA", typeof(string));
    
            var tELEFONOParameter = tELEFONO != null ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var pAISParameter = pAIS != null ?
                new ObjectParameter("PAIS", pAIS) :
                new ObjectParameter("PAIS", typeof(string));
    
            var cIUDADParameter = cIUDAD != null ?
                new ObjectParameter("CIUDAD", cIUDAD) :
                new ObjectParameter("CIUDAD", typeof(string));
    
            var lOCALIDADParameter = lOCALIDAD != null ?
                new ObjectParameter("LOCALIDAD", lOCALIDAD) :
                new ObjectParameter("LOCALIDAD", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            var fK_TIPO_PLANParameter = fK_TIPO_PLAN.HasValue ?
                new ObjectParameter("FK_TIPO_PLAN", fK_TIPO_PLAN) :
                new ObjectParameter("FK_TIPO_PLAN", typeof(int));
    
            var cLAVEParameter = cLAVE.HasValue ?
                new ObjectParameter("CLAVE", cLAVE) :
                new ObjectParameter("CLAVE", typeof(int));
    
            var eSTADOParameter = eSTADO.HasValue ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(bool));
    
            var iMAGENParameter = iMAGEN != null ?
                new ObjectParameter("IMAGEN", iMAGEN) :
                new ObjectParameter("IMAGEN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_REGISTRAR_ARTISTA5", nOMBRE_ARTISTAParameter, pRIMER_APELLIDO_ARTISTAParameter, sEGUNDO_APELLIDO_ARTISTAParameter, tELEFONOParameter, cORREOParameter, pAISParameter, cIUDADParameter, lOCALIDADParameter, dIRECCIONParameter, fK_TIPO_PLANParameter, cLAVEParameter, eSTADOParameter, iMAGENParameter);
        }
    }
}
