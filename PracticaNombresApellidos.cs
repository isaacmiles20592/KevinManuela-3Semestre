using System;

namespace HelloWorld;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("=== Nombres y apellidos ===");
        Random rd = new Random();

        string[] nombres = new string[100]
            {"Sofía", "Mateo", "Valentina", "Santiago", "Camila", "Sebastián", "Valeria", "Matías", "Lucía", "Emiliano", "Isabella", "Diego", "Martina", "Alejandro", "María", "Nicolás", "Victoria", "Daniel", "Renata", "Samuel", "Regina", "Gabriel", "Ximena", "David", "Natalia", "Lucas", "Mariana", "Samuel", "Andrea", "Andrés", "Jimena", "Javier", "Antonella", "Fernando", "Fernanda", "Carlos", "Paula", "José", "Romina", "Miguel", "Alonso", "Daniela", "Ángel", "Salomé", "Cristóbal", "Emma", "Tomás", "Elena", "Bruno", "Julieta", "Charlie", "Sara", "Leonardo", "Gabriela", "Ian", "Nicole", "Gael", "Charles", "Thiago", "Ariana", "Maximiliano", "Mía", "Joaquín", "Laura", "Elías", "Alma", "Martín", "Abril", "Isaac", "Clara", "Adrián", "Zoe", "Óscar", "Amanda", "Raúl", "Carolina", "Pablo", "Ana", "Eduardo", "Paola", "Héctor", "Vanessa", "Rubén", "Diana", "Iván", "Alejandra", "George", "Liliana", "Víctor", "Fabiola", "Alan", "Lorena", "Kevin", "Marisol", "Eric", "Claudia", "Hugo", "Verónica", "César", "Patricia"};

        string[] apellidos = new string[100]
            {"García", "Rodríguez", "González", "Fernández", "López", "Martínez", "Sánchez", "Pérez", "Gómez", "Martín", "Jiménez", "Hernández", "Ruiz", "Díaz", "Moreno", "Álvarez", "Romero", "Alonso", "Gutiérrez", "Navarro", "Torres", "Domínguez", "Vázquez", "Ramos", "Gallo", "Ramírez", "Serrano", "Morales", "Molina", "Castro", "Ortiz", "Rubio", "Marín", "Sanz", "Núñez", "Iglesias", "Medina", "Garrido", "Cortés", "Castillo", "Santos", "Lozano", "Guerrero", "Cano", "Prieto", "Méndez", "Cruz", "Smith", "Gallego", "Vidal", "León", "Herrera", "Márquez", "Peña", "Flores", "Cabrera", "Campos", "Vega", "Fuentes", "Carrasco", "Chan", "Caballero", "Reyes", "Nieto", "Aguilar", "Pascual", "Santana", "Hidalgo", "Montero", "Lorenzo", "Floyd", "Ibáñez", "Ferrer", "Duran", "Vicente", "Benítez", "Mora", "Arias", "Carmona", "Costa", "Román", "Kirk", "Soto", "Obama", "Velasco", "Moya", "Sol", "Esteban", "Parra", "Bravo", "Gallardo", "Rojas", "Pardo", "Sierra", "Izquierdo", "Maldonado", "Franco", "Vera", "Blanco", "Suárez"};

        int disponiblesNombres = nombres.Length;
        int disponiblesApellidos = apellidos.Length;

        for (int i = 1; i <= 20; i++)
        {
            int indice1 = rd.Next(0, disponiblesNombres);
            string nombre1 = nombres[indice1];
            disponiblesNombres--;
            nombres[indice1] = nombres[disponiblesNombres];
            nombres[disponiblesNombres] = nombre1;

            int indice2 = rd.Next(0, disponiblesNombres);
            string nombre2 = nombres[indice2];
            disponiblesNombres--;
            nombres[indice2] = nombres[disponiblesNombres];
            nombres[disponiblesNombres] = nombre2;

            indice1 = rd.Next(0, disponiblesApellidos);
            string apellido1 = apellidos[indice1];
            disponiblesApellidos--;
            apellidos[indice1] = apellidos[disponiblesApellidos];
            apellidos[disponiblesApellidos] = apellido1;

            indice2 = rd.Next(0, disponiblesApellidos);
            string apellido2 = apellidos[indice2];
            disponiblesApellidos--;
            apellidos[indice2] = apellidos[disponiblesApellidos];
            apellidos[disponiblesApellidos] = apellido2;

            Console.WriteLine(i + ".- " + nombre1 + " " + nombre2 + " " + apellido1 + " " + apellido2);
        }

        Console.WriteLine();
        Console.WriteLine("Total de nombres: " + nombres.Length);
        Console.WriteLine("Total de apellidos: " + apellidos.Length);

    }    
}
