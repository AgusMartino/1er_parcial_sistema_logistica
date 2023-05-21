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
        #endregion
    }
}