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

    }
}