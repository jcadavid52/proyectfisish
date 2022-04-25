using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationSpiritualArt.Models;
using WebApplicationSpiritualArt.Logica_Negocio;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WebApplicationSpiritualArt.Models.PagosPlan;
using System.IO;

namespace WebApplicationSpiritualArt.Controllers
{
    public class PrincipalController : Controller
    {
        LogicaNegocioArtista logicaNegocioArtista = new LogicaNegocioArtista();
        LogicaPlanes logicaPlanes = new LogicaPlanes();
        // GET: Principal
        public ActionResult Index()
        {

            return View();
        }

        //este metodo es igual al index pero solo se accede a él cuando el artista se haya registrado
        public ActionResult IndexSesion()
        {
            if (Session["correo"] != null && Session["clave"] != null)
            {
                return View();
            }
            else
            {
                return View("Index");
            }



        }

        public ActionResult RegistrarArtista()
        {
            List<TIPO_PLAN> listarPlanes = logicaPlanes.listarPlanes();
            return View(listarPlanes);
        }

        //registro de artista
        public ActionResult RegistrarArtistaAccion(REGISTRO_ARTISTA nuevoArtista)
        {

            TempData["correo"] = nuevoArtista.CORREO;
            TempData["nombre_artista"] = nuevoArtista.NOMBRE_ARTISTA;
            TempData["primer_apellido"] = nuevoArtista.PRIMER_APELLIDO_ARTISTA;
            TempData["segundo_apeliido"] = nuevoArtista.SEGUNDO_APELLIDO_ARTISTA;
            TempData["telefono"] = nuevoArtista.TELEFONO;
            TempData["pais"] = nuevoArtista.PAIS;
            TempData["ciudad"] = nuevoArtista.CIUDAD;
            TempData["localidad"] = nuevoArtista.LOCALIDAD;
            TempData["direccion"] = nuevoArtista.DIRECCION;
            TempData["fk_plan"] = nuevoArtista.FK_TIPO_PLAN;
            TempData["imagen"] = nuevoArtista.IMAGEN;
            int? fk_plan = nuevoArtista.FK_TIPO_PLAN;



            //verifica el tipo de plan
            if (nuevoArtista.FK_TIPO_PLAN == 8 || nuevoArtista.FK_TIPO_PLAN == 9)
            {
                TempData["correoRegistrado"] = nuevoArtista.CORREO;
                List<TIPO_PLAN> listarPlanes = logicaPlanes.listarPlanes(fk_plan);
                return View("OfertaPlanes", listarPlanes);
            }
            else
            {

                logicaNegocioArtista.RegistrarArtista(nuevoArtista);


                //consulta con varios parametros para traer la clave del artista
                REGISTRO_ARTISTA obtenerClave = logicaNegocioArtista.obtenerClaveArtista(nuevoArtista.CORREO, nuevoArtista.NOMBRE_ARTISTA, nuevoArtista.PRIMER_APELLIDO_ARTISTA, nuevoArtista.SEGUNDO_APELLIDO_ARTISTA);


                //envio de los parametros que va a llevar el envio del email
                logicaNegocioArtista.EnviarEmail(obtenerClave.CORREO, obtenerClave.CLAVE, obtenerClave.CORREO, obtenerClave.NOMBRE_ARTISTA);
                return View("IniciarSesionPago", obtenerClave);
            }
        }

        public ActionResult IniciarSesion()
        {
            return View();
        }
        public ActionResult IniciarSesionPago()
        {
            string correo = TempData["correo"].ToString();
            string nombre_artista = TempData["nombre_artista"].ToString();
            string primer_apellido = TempData["primer_apellido"].ToString();
            string segundo_apellido = TempData["segundo_apeliido"].ToString();
            string telefono = TempData["telefono"].ToString();
            string pais = TempData["pais"].ToString();
            string ciudad = TempData["ciudad"].ToString();
            string localidad = TempData["localidad"].ToString();
            string direccion = TempData["direccion"].ToString();
            int? fk_plan = Convert.ToInt32(TempData["fk_plan"].ToString());
            string imagen = TempData["imagen"].ToString();

            var registrarArtista = new REGISTRO_ARTISTA()
            {
                NOMBRE_ARTISTA = nombre_artista,
                PRIMER_APELLIDO_ARTISTA = primer_apellido,
                SEGUNDO_APELLIDO_ARTISTA = segundo_apellido,
                TELEFONO = telefono,
                PAIS = pais,
                CIUDAD = ciudad,
                LOCALIDAD = localidad,
                DIRECCION = direccion,
                FK_TIPO_PLAN = fk_plan,
                CORREO = correo,
                IMAGEN = imagen

            };

            logicaNegocioArtista.RegistrarArtista(registrarArtista);

            REGISTRO_ARTISTA obtenerClave = logicaNegocioArtista.obtenerClaveArtista(correo, nombre_artista, primer_apellido, segundo_apellido);
            return View(obtenerClave);
        }

        public ActionResult IniciarSesionAccion(REGISTRO_ARTISTA datosAcceso)
        {
            REGISTRO_ARTISTA acceso = logicaNegocioArtista.Acceso(datosAcceso);
            if (acceso == null)
            {
                ViewBag.Mensaje = "Clave o usuario inválido, intente nuevamente";
                return View("IniciarSesion");
            }
            else
            {
                Session["correo"] = acceso.CORREO;
                Session["clave"] = acceso.CLAVE;
                Session["imagen"] = acceso.IMAGEN;
                return View("IndexSesion");
            }
        }

        public ActionResult EspacioArtista()
        {
            return View();
        }


        [HttpPost]
        public async Task<JsonResult> PagoPlan(string precio, string plan)
        {
            bool status = false;
            string respuesta = string.Empty;

            using (var client = new HttpClient())
            {
                var userName = "Aedtf_Rt5Y4MwJCsIph_C3re97TvnicO-cyxmTM_VRPsG1y-eUXREfVXpzPrhH1zZZkcNuRnb1QTYbmC";
                var password = "EFfc3lvPYwDO7FJBZuFg2BhZWb3EfUz-KLt_KfKKU_HzT1pHJPnG87BtMtlpopXbwJlSK-GGA5RaEqb7";

                client.BaseAddress = new Uri("https://api-m.sandbox.paypal.com");

                var authToken = Encoding.ASCII.GetBytes($"{userName}:{password}");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));

                var orden = new OrdenPlanes()
                {
                    intent = "CAPTURE",
                    purchase_units = new List<PurchaseUnit>()
                      {
                          new PurchaseUnit()
                          {
                              amount = new Amount()
                              {
                                  currency_code = "USD",
                                  value = precio
                              },
                              description = plan
                          }
                      },
                    application_context = new ApplicationContext()
                    {
                        brand_name = "SpiritualArt.com",
                        landing_page = "NO_PREFERENCE",
                        user_action = "PAY_NOW",
                        return_url = "https://localhost:44379/Principal/IniciarSesionPago",
                        cancel_url = "https://localhost:44379/Principal/Index"

                    }
                };

                var json = JsonConvert.SerializeObject(orden);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("/v2/checkout/orders", data);
                status = response.IsSuccessStatusCode;

                if (status)
                {
                    respuesta = response.Content.ReadAsStringAsync().Result;
                }

            }

            return Json(new { status = status, respuesta = respuesta }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult OfertaPlanes()
        {
            return View();
        }

        public ActionResult CerrarSesion()
        {
            Session["correo"] = null;
            Session["clave"] = null;

            return View("Index");
        }

        public ActionResult CambiarImagen(REGISTRO_ARTISTA nuevaImagen)
        {
            if (nuevaImagen.IMAGEN != null)
            {
                string nombreArchivo = Path.GetFileNameWithoutExtension(nuevaImagen.archivo.FileName);
                string extension = Path.GetExtension(nuevaImagen.archivo.FileName);
                nombreArchivo = nombreArchivo + DateTime.Now.ToString("yymmssfff") + extension;
                nuevaImagen.IMAGEN = "~/ArchivosLectura/" + nombreArchivo;
                nombreArchivo = Path.Combine(Server.MapPath("~/ArchivosLectura/"), nombreArchivo);
                nuevaImagen.archivo.SaveAs(nombreArchivo);
                logicaNegocioArtista.modificarImagen(nuevaImagen);
                ModelState.Clear();
                return View("Index");
            }
                return View("Index");

        }
    }
}