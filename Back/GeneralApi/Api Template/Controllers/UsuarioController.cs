using GeneralApi.Models.Parcial;
using GeneralApi.Utils;
using GeneralApi.Utils.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace GeneralApi.Controllers
{
    public class UsuarioController : ApiController
    {
        #region Get Endpoints
        [HttpGet]
        public IHttpActionResult Login([FromUri] string user, string password)
        {
            try
            {
                usuario usuario = new usuario();

                usuario = UsuarioServices.Current.Login(user,password);
                if (usuario.id_usuario == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(usuario);
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