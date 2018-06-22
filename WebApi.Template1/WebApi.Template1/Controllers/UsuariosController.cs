using System.Web.Http;
using WebApi.Test.Models;
using System.Linq;

namespace WebApi.Test.Controllers
{
    /// <summary>
    /// Controlador de Usuarios
    /// </summary>
    public class UsuariosController : ApiController
    {
        private ITestWebApiEntities db = new TestWebApiEntities();

        /// <summary>
        /// Constructor
        /// </summary>
        public UsuariosController(){ }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public UsuariosController(ITestWebApiEntities context)
        {
            db = context;
        }

        /// <summary>
        /// Retorna un listado de usuarios
        /// </summary>
        /// <returns>IEnumerable<Usuarios></Usuarios></returns>
        public IHttpActionResult Get()
        {
            return Ok(db.Usuarios.ToList());
        }

        /// <summary>
        /// Retorna un Usuario en base a un identificador recibido por parámetro
        /// </summary>
        /// <returns>Usuarios</Usuarios></returns>
        public IHttpActionResult Get(int id)
        {
            return Ok(db.Usuarios.Where(x => x.Id == id).FirstOrDefault());
        }

        /// <summary>
        /// Inserta un registro
        /// </summary>
        /// <param name="usuario">Usuario</param>
        public IHttpActionResult Post([FromBody]Usuarios usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();

            return Ok(usuario);
        }

        /// <summary>
        /// Edita un registro
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <param name="usuario">Usuario</param>
        public IHttpActionResult Put(int id, [FromBody]Usuarios usuario)
        {
            var usuarioRecuperado = db.Usuarios.Where(x => x.Id == id).FirstOrDefault();
            usuarioRecuperado.Nombre = usuario.Nombre;
            usuarioRecuperado.Apellido = usuario.Apellido;
            usuarioRecuperado.Email = usuario.Email;
            usuarioRecuperado.Password = usuario.Password;

            db.SaveChanges();

            return Ok(usuarioRecuperado);
        }

        /// <summary>
        /// Realiza la baja de un registro
        /// </summary>
        /// <param name="id">Identificador</param>
        public IHttpActionResult Delete(int id)
        {
            var usuarioRecuperado = db.Usuarios.Where(x => x.Id == id).FirstOrDefault();
            db.Usuarios.Remove(usuarioRecuperado);
            db.SaveChanges();

            return Ok();
        }
    }
}