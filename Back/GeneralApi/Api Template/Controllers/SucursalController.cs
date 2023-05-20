using GeneralApi.Utils;
using GeneralApi.Utils.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace GeneralApi.Controllers
{
    public class SucursalController : ApiController
    {
        #region Get Endpoints
        [HttpGet]
        public IHttpActionResult GetDepositos()
        {
            try
            {
                var objdepositos = SucursalService.Current.GetDepositos();
                if (objdepositos == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(objdepositos);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [HttpGet]
        public IHttpActionResult GetTiendas()
        {
            try
            {
                var objtiendas = SucursalService.Current.GetTiendas();
                if (objtiendas == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(objtiendas);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [HttpGet]
        public IHttpActionResult GetSucursal([FromUri]int id)
        {
            try
            {
                var sucursal = SucursalService.Current.GetSucursal(id);
                if (sucursal == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(sucursal);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        #endregion

        #region Put Endpoints
        /*
        [Microsoft.AspNetCore.Mvc.HttpPut("{id:string}")]
        public IHttpActionResult PutValorTipoVehiculo(string idTipoVehiculo, decimal nuevoValor)
        {
            try
            {
                var success = TransitoManager.UpdateValorVehiculo(idTipoVehiculo, nuevoValor);
                if (success)
                {
                    return Ok(new { msg = $"Se actualizo valor del monto del vehiculo con id = {idTipoVehiculo} al valor = ${nuevoValor.ToString()}" });
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Microsoft.AspNetCore.Mvc.HttpPut]
        public IHttpActionResult PutValorMulta(decimal nuevoValor)
        {
            try
            {
                var success = TransitoManager.UpdateValorMulta(nuevoValor);
                if (success)
                {
                    return Ok(new { msg = $"Se actualizo valor de la multa al valor = ${nuevoValor.ToString()}" });
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        */
        #endregion
    }
}