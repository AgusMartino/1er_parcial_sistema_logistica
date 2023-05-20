using GeneralApi.Entities;
using GeneralApi.Utils;
using GeneralApi.Utils.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace GeneralApi.Controllers
{
    public class ReportesController : ApiController
    {
        #region Get Endpoints
        [HttpGet]
        public IHttpActionResult GetOperacionesDestino()
        {
            try
            {
                var obj = ReportesServicies.Current.GetOperacionesDestino();
                if (obj == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(obj);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [HttpGet]
        public IHttpActionResult GetOperacionesFiltroFecha([FromUri] GetOperacionesFiltroFecha getOperacionesFiltroFecha)
        {
            try
            {
                var obj = ReportesServicies.Current.GetOperacionesFiltroFecha(getOperacionesFiltroFecha.id, getOperacionesFiltroFecha.inicio, getOperacionesFiltroFecha.final);
                if (obj == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(obj);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [HttpGet]
        public IHttpActionResult GetOperaciones()
        {
            try
            {
                var obj = ReportesServicies.Current.GetOperaciones();
                if (obj == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(obj);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        /*
        [HttpGet]
        public IHttpActionResult GetOperacionesConMasTresDia([FromUri] DateTime fecha)
        {
            try
            {
                var obj = ReportesServicies.Current.GetOperacionesConMasTresDia(fecha);
                if (obj == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(obj);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }*/
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