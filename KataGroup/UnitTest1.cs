using NUnit.Framework;

namespace KataGroup
{
    
    // 1 - Estudiantes = 10 -> Temas  = 2 -> Grupos = 2 --> integrantes = 5,5
    // 2 -> Estudiante = 11 -> Temas = 4 -> Grupos = 5 --> integrantes =  4,4,4,3
    // 3 -> Estudiantes = 15 -> Temas = 4 -> Grupos = 4 --> Integrantes = 4,4,4,3
    // 4 -> Estudiantes = 12 -> Temas  = 4 = > Grupos = 3 --> Integrantes = 4,4,4
    // 5 ->  Estudiantes = 2 -> Temas = 2 -> Grupos 2 -> Integrantes = 1,1
    // 6 -> Estudiantes = 5 -> Temas = 0 -> Grupos 0 -> Integrantes = 0
    // 7 -> Estudiantes = 0 -> Temas = 2 -> Grupos 0 -> Integrantes = 0
    // 8 -> Estudiantes = 3 -> Temas = 2 -> Grupos 2 -> Integrantes = 2,1
    
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            
            var student = 3;
            var group = 2;
            var topic = 2;
            var groupMember = 2,1;
            Assert.Pass();
        }
    }
}