using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WebApi.Test.Controllers;
using System.Collections.Generic;
using WebApi.Test.Models;
using System.Web.Http.Results;

namespace WebApiTest
{
    /// <summary>
    /// Test del controlador de usuarios
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Valida el funcionamiento del alta de usuarios
        /// </summary>
        [TestMethod]
        public void PostUsuario_AltaUsuario()
        {
            var controller = new UsuariosController(new UsuariosContextTest());

            var item = GetDemoUsuario();

            var result =
                controller.Post(item) as OkNegotiatedContentResult<Usuarios>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Content.Id, item.Id);
            Assert.AreEqual(result.Content.Nombre, item.Nombre);
            Assert.AreEqual(result.Content.Apellido, item.Apellido);
            Assert.AreEqual(result.Content.Email, item.Email);
            Assert.AreEqual(result.Content.Password, item.Password);
        }

        /// <summary>
        /// Valida el funcionamiento de la recuperación de usuarios
        /// </summary>
        [TestMethod]
        public void GetUsuarios_DebeTraerListado()
        {
            var context = new UsuariosContextTest();
            var item = GetDemoUsuario();
            context.Usuarios.Add(item);

            var controller = new UsuariosController(context);

            var result = controller.Get() as OkNegotiatedContentResult<List<Usuarios>>;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count() == 1);
            Assert.AreEqual(result.Content.FirstOrDefault().Id, item.Id);
            Assert.AreEqual(result.Content.FirstOrDefault().Nombre, item.Nombre);
            Assert.AreEqual(result.Content.FirstOrDefault().Apellido, item.Apellido);
            Assert.AreEqual(result.Content.FirstOrDefault().Email, item.Email);
            Assert.AreEqual(result.Content.FirstOrDefault().Password, item.Password);

        }

        /// <summary>
        /// Valida el funcionamiento de la edición de usuarios
        /// </summary>
        [TestMethod]
        public void PutUsuario_UsuarioEditado()
        {
            var context = new UsuariosContextTest();
            var item = GetDemoUsuario();           

            context.Usuarios.Add(item);

            item.Nombre = "Nombre Edit";
            item.Apellido = "Apellido Edit";
            item.Email = "Email Edit";
            item.Password = "Pass Edit";

            var controller = new UsuariosController(context);

            var result =
                controller.Put(1, item) as OkNegotiatedContentResult<Usuarios>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Content.Id, item.Id);
            Assert.AreEqual(result.Content.Nombre, item.Nombre);
            Assert.AreEqual(result.Content.Apellido, item.Apellido);
            Assert.AreEqual(result.Content.Email, item.Email);
            Assert.AreEqual(result.Content.Password, item.Password);
        }

        /// <summary>
        /// Valida el funcionamiento del borrado de usuarios
        /// </summary>
        [TestMethod]
        public void DeleteUsuario_UsuarioEditado()
        {
            var context = new UsuariosContextTest();
            var item = GetDemoUsuario();

            context.Usuarios.Add(item);

            var controller = new UsuariosController(context);

            var result =
                controller.Delete(1) as OkNegotiatedContentResult<Usuarios>;

            Assert.IsNull(result);
        }

        private Usuarios GetDemoUsuario()
        {
            return new Usuarios() {Id = 1, Nombre = "Pepe", Apellido = "Argento", Email = "Pepe@Gmail.com", Password = "123456" };
        }
    }
}
