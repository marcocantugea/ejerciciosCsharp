using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeciciosEstructuraDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArraysExample();
            StackExample();
            Console.Read();
        }

        // arrays, listas, stacks, Queues, Dictoranries 
        // FIFO, FILO
        //FIFO  First In, First Out
        //FILO Fist in, last out
        //Arrays, Listas, Dictoronaries : FIFO 
        //Stacks : FILO
        //Queues : FIFO


        public static void ArraysExample()
        {
            string[] arraysStrings = new string[3];

            string[] arrayStringsStatic = {
                "valor1",
                "valor2",
                "valor3"
            };

            arraysStrings[0] = "valor";

            List<Persona> ColeccionesDePersonas = new List<Persona>();
            List<string> coleccionString = new List<string>();
            List<int> coleccionInt = new List<int>();

            Persona persona_1 = new Persona();
            persona_1.name = "Marco Cantu";

            Persona persona_2 = new Persona();
            persona_2.name = "Juan Luis";

            Persona persona_3 = new Persona();
            persona_3.name = "Mauricio";

            ColeccionesDePersonas.Add(persona_1);
            coleccionString.Add("este es un string");
            coleccionInt.Add(3);

            Persona[] listaPersonas = {
                persona_1,
                persona_2,
                persona_3
            };

            List<Persona> conversionArrayListaPersonas = new List<Persona>();
            conversionArrayListaPersonas.AddRange(listaPersonas);

            int indexMarco=conversionArrayListaPersonas.IndexOf(persona_1);
            conversionArrayListaPersonas.RemoveAt(indexMarco);

            foreach (Persona item in conversionArrayListaPersonas)
            {
                Console.WriteLine($"Esta persona {item.name} es atoda madre");
            }

            //foreach(Persona item in ColeccionesDePersonas)
            //{
            //    Console.WriteLine($"La persona se llama {item.name}");
            //}

            //foreach(string texto in coleccionString)
            //{
            //    Console.WriteLine(texto);
            //}

            //foreach(int numero in coleccionInt)
            //{
            //    Console.WriteLine(numero);
            //}

            Factura factura1 = new Factura();
            factura1.detalle.partidas.Add(new Partida());

            foreach (Partida partida in factura1.detalle.partidas)
            {

            }

        }

        public static void StackExample()
        {

            Stack<string> stackDeStrings = new Stack<string>();

            stackDeStrings.Push("valor1");
            stackDeStrings.Push("valor2");
            stackDeStrings.Push("valor3");
            stackDeStrings.Push("valor4");
            stackDeStrings.Push("valor5");
            stackDeStrings.Push("valor6");
            stackDeStrings.Push("valor7");
            stackDeStrings.Push("valor8");

            Console.WriteLine("sdfsdf");

            foreach(string valor in stackDeStrings)
            {
                Console.WriteLine($"Este es el primer valor procesado {valor}");
            }


            Stack<Proceso> preciosActualizados = new Stack<Proceso>();
            // emulo obtener de la base de datos los precios order by fecha

            Proceso precio1 = new Proceso() {
                precioAActualizar = 50,
                cuando = "Lunes"
            };

            Proceso precio2 = new Proceso()
            {
                precioAActualizar = 80,
                cuando="Martes"
            };

            Proceso precio3 = new Proceso()
            {
                precioAActualizar = 40,
                cuando="Miercoes"
            };


            preciosActualizados.Push(precio1);
            preciosActualizados.Push(precio2);
            preciosActualizados.Push(precio3);

            foreach(Proceso process in preciosActualizados)
            {
                process.ActualizarPublicacion();
            }



        }

    }

    class Persona
    {
        public string name { set; get; }
    }

    class Factura
    {
        public EncabezadoFactura encabezado { get; set; }
        public DetalleFactura detalle = new DetalleFactura();

    }

    class EncabezadoFactura { }
    class DetalleFactura
    {
        public List<Partida> partidas = new List<Partida>();
    }

    class Partida { }

    class Proceso
    {
        public float precioAActualizar { get; set; }
        public string cuando { set; get; }

        public void ActualizarPublicacion()
        {
            Console.WriteLine($"Actualizando publicacion con precio {precioAActualizar}");
        }
    }
}
