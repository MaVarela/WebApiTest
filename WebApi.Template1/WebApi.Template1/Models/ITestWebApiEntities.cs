using System;
using System.Data.Entity;

namespace WebApi.Test.Models
{
    /// <summary>
    /// Interfaz TestWebApiEntities
    /// </summary>
    public interface ITestWebApiEntities : IDisposable
    {
        /// <summary>
        /// Usuarios
        /// </summary>
        DbSet<Usuarios> Usuarios { get; set; }

        /// <summary>
        /// Guarda los cambios
        /// </summary>
        /// <returns>int</returns>
        int SaveChanges();
    }
}
