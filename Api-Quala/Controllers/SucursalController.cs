using System.IdentityModel.Tokens.Jwt;
using Api_Quala.Contexts;
using Api_Quala.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


namespace Api_Quala.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SucursalController : Controller
    {
        private readonly ConexionDB db;

        public SucursalController(ConexionDB db)
        {
            this.db = db;
        }

        // GET: SucursalController
        [HttpGet]
        [Route("Lista-sucursales")]
        public IEnumerable<SucursalModel> GetValuesSucursales()
        {
            return db.sucursalModels.ToList();
        }

        [HttpPost]
        [Route("Crear-sucursales")]
        public String PostValueNewSucursales(SucursalViewModel sucursal)
        {

            if (!ModelState.IsValid)
            {
                var errores = ModelState.Select(v => new { key = v.Key, errores = v.Value.Errors });
                return JsonSerializer.Serialize(new { success = false, errores = errores });
            }
            DateTime dateTime = DateTime.Now;
            SucursalModel sucursalModel = new SucursalModel();
            sucursalModel.Codigo = sucursal.Codigo;
            sucursalModel.Descripcion = sucursal.Descripcion;
            sucursalModel.Identificacion = sucursal.Identificacion;
            sucursalModel.Direccion = sucursal.Direccion;
            sucursalModel.FechaCreacion = dateTime;
            sucursalModel.Moneda = sucursal.Moneda;
            db.sucursalModels.Add(sucursalModel);
            db.SaveChanges();
            SucursalModel x = db.sucursalModels.Find(sucursalModel.Codigo);
            var objRetornado = new
            {
                Codigo = x.Codigo,
                Descripcion = x.Direccion,
                Identificacion = x.Identificacion,
                Direccion = x.Direccion,
                FechaCreacion = x.FechaCreacion,
                Moneda = x.Moneda,

            };
            return JsonSerializer.Serialize(new { success = true, objRetornado = objRetornado });
        }


        [HttpPost]
        [Route("Editar-sucursales")]
        public String PostValueUpdateSucursales(SucursalViewModel sucursal)
        {

            if (!ModelState.IsValid)
            {
                var errores = ModelState.Select(v => new { key = v.Key, errores = v.Value.Errors });
                return JsonSerializer.Serialize(new { success = false, errores = errores });
            }

            DateTime dateTime = DateTime.Now;
            SucursalModel s = db.sucursalModels.Find(sucursal.Codigo);
            s.Codigo = sucursal.Codigo;
            s.Descripcion = sucursal.Descripcion;
            s.Identificacion = sucursal.Identificacion;
            s.Direccion = sucursal.Direccion;
            s.FechaCreacion = dateTime;
            s.Moneda = sucursal.Moneda;
            db.SaveChanges();
            SucursalModel x = db.sucursalModels.Find(sucursal.Codigo);
            var objRetornado = new
            {
                Codigo = x.Codigo,
                Descripcion = x.Direccion,
                Identificacion = x.Identificacion,
                Direccion = x.Direccion,
                FechaCreacion = x.FechaCreacion,
                Moneda = x.Moneda,

            };
            return JsonSerializer.Serialize(new { success = true, objRetornado = objRetornado });
        }



        [HttpGet]
        [Route("Lista-monedas")]
        public IEnumerable<MonedaModel> GetValuesMonedas()
        {
            return db.monedaModels.ToList();
        }


    }
}
