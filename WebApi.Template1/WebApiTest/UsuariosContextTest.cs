using System.Data.Entity;
using WebApi.Test.Models;

namespace WebApiTest
{
    /// <summary>
    /// Contexto para Test de UsuariosController
    /// </summary>
    public class UsuariosContextTest : ITestWebApiEntities 
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UsuariosContextTest()
        {
            this.Usuarios = new UsuariosSetDatosTest();
        }

        /// <summary>
        /// Usuarios
        /// </summary>
        public DbSet<Usuarios> Usuarios { get; set; }

        public int SaveChanges()
        {
            return 0;
        }

        public void Dispose() { }
    }
}
