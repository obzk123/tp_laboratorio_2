using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LeerBaseDeDatos()
        {
            GestorBaseDeDatos<Torneo> gbd = new GestorBaseDeDatos<Torneo>("Data Source =.; Initial Catalog = equipos; Integrated Security = true");
            Torneo nuevoTorneo = gbd.Leer();

            Assert.IsNotNull(nuevoTorneo);

        }


        [TestMethod]
        [ExpectedException(typeof(ExceptionSQL))]
        public void ExceptionLeerBaseDeDatos()
        {
            GestorBaseDeDatos<Torneo> gbd = new GestorBaseDeDatos<Torneo>("Data Source =error; Initial Catalog = equipos; Integrated Security = true");
            Torneo nuevoTorneo = gbd.Leer();
        }
    }
}
