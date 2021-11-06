using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InicializarUnEquipo()
        {
            Equipo nuevoEquipo = new Equipo();

            Assert.IsNotNull(nuevoEquipo);
        }

        [TestMethod]
        public void InicializarUnTorneo()
        {
            Torneo nuevoTorneo = new Torneo("Primera Divison", 10, 10);

            Assert.IsNotNull(nuevoTorneo);
        }

        [TestMethod]
        public void AgregarUnEquipoAUnTorneo()
        {
            Torneo nuevoTorneo = new Torneo("Primera Divison", 10, 10);
            Equipo equipo = new Equipo("Estudiantes", 10, 3, 0, 10, 5);

            Assert.IsTrue(nuevoTorneo + equipo);
        }

        [TestMethod]
        public void EliminarUnEquiposUnTorneo()
        {
            Torneo nuevoTorneo = new Torneo("Primera Divison", 10, 10);
            Equipo equipo = new Equipo("Estudiantes", 10, 3, 0, 10, 5);
            bool aux = nuevoTorneo + equipo;

            Assert.IsTrue(nuevoTorneo - equipo);
        }

        [TestMethod]
        public void EquipoAMayorQueEquipoB()
        {
            Equipo equipoA = new Equipo("Racing", 11, 2, 3, 22, 5);
            Equipo equipoB = new Equipo("Estudiantes", 10, 3, 0, 10, 5);
            
            Assert.IsTrue(equipoA > equipoB);
        }

        [TestMethod]
        public void EquipoBMenorQueEquipoA()
        {
            Equipo equipoA = new Equipo("Racing", 11, 2, 3, 22, 5);
            Equipo equipoB = new Equipo("Estudiantes", 10, 3, 0, 10, 5);

            Assert.IsTrue(equipoB < equipoA);
        }

        [TestMethod]
        public void CompararMismoEquipo()
        {
            Equipo equipoA = new Equipo("Racing", 11, 2, 3, 22, 5);
            Equipo equipoB = new Equipo("Racing", 10, 3, 0, 10, 5);

            Assert.IsTrue(equipoA == equipoB);
        }

        [TestMethod]
        public void CompararEquiposDistintos()
        {
            Equipo equipoA = new Equipo("Racing", 11, 2, 3, 22, 5);
            Equipo equipoB = new Equipo("Estudiantes", 10, 3, 0, 10, 5);

            Assert.IsTrue(equipoA != equipoB);
        }

        [TestMethod]
        [ExpectedException (typeof(ExceptionTxt))]
        public void AbrirTxtException()
        {
            Torneo nuevoTorneo = new Torneo("Primera Divison", 10, 10);
            GestorDeArchivos gda = new GestorDeArchivos();
            nuevoTorneo = gda.AbrirTxt("Prueba error", nuevoTorneo);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionJson))]
        public void AbrirJsonException()
        {
            Torneo nuevoTorneo = new Torneo("Primera Divison", 10, 10);
            GestorDeArchivos gda = new GestorDeArchivos();
            nuevoTorneo = gda.AbrirJSON("Prueba error", nuevoTorneo);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionXml))]
        public void AbrirXmlException()
        {
            Torneo nuevoTorneo = new Torneo("Primera Divison", 10, 10);
            GestorDeArchivos gda = new GestorDeArchivos();
            nuevoTorneo = gda.AbrirXML("Prueba error", nuevoTorneo);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionTxt))]
        public void GuardarTxtException()
        {
            Torneo nuevoTorneo = new Torneo("Primera Divison", 10, 10);
            GestorDeArchivos gda = new GestorDeArchivos();
            gda.GuardarTxt("C:\\Error.xml", nuevoTorneo);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionJson))]
        public void GuardarJsonException()
        {
            Torneo nuevoTorneo = new Torneo("Primera Divison", 10, 10);
            GestorDeArchivos gda = new GestorDeArchivos();
            gda.GuardarJSON("C:\\Error.txt", nuevoTorneo);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionXml))]
        public void GuardarXmlException()
        {
            Torneo nuevoTorneo = new Torneo("Primera Divison", 10, 10);
            GestorDeArchivos gda = new GestorDeArchivos();
            gda.GuardarXML("C:\\Error.json", nuevoTorneo);
        }
    }
}
