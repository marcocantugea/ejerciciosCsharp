using System;
using System.Collections.Generic;
using System.IO;
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
            //StackExample();
            //QueuesAndDictionaries();
            //ListSortExample();
            //EjemploFuncionesList();
            //FoundMedian();
            EjercicioAgregado();
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

            int indexMarco = conversionArrayListaPersonas.IndexOf(persona_1);
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

            factura1.detalle.partidas.Add(new Partida()
            {
                precio = "50.00",
                desc = "Huevos con Jamon"
            });

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

            foreach (string valor in stackDeStrings)
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
                cuando = "Martes"
            };

            Proceso precio3 = new Proceso()
            {
                precioAActualizar = 40,
                cuando = "Miercoes"
            };


            preciosActualizados.Push(precio1);
            preciosActualizados.Push(precio2);
            preciosActualizados.Push(precio3);

            foreach (Proceso process in preciosActualizados)
            {
                process.ActualizarPublicacion();
            }



        }

        public static void QueuesAndDictionaries()
        {

            Queue<Persona> ColeccionesDePersonas = new Queue<Persona>();
            Persona persona_1 = new Persona()
            {
                name = "Marco Cantu",
                age = 40
            };

            Persona persona_2 = new Persona();
            persona_2.name = "Juan Luis";
            persona_2.age = 37;

            Persona persona_3 = new Persona();
            persona_3.name = "Antonio Peres";
            persona_3.age = 27;

            Persona persona_4 = new Persona();
            persona_4.name = "Benito Garcia";
            persona_4.age = 55;

            Persona persona_5 = new Persona();
            persona_5.name = "Carlos Juan";
            persona_5.age = 19;

            Persona persona_6 = new Persona();
            persona_6.name = "Zoe Medina";
            persona_6.age = 20;

            ColeccionesDePersonas.Enqueue(persona_1);
            ColeccionesDePersonas.Enqueue(persona_2);
            ColeccionesDePersonas.Enqueue(persona_3);
            ColeccionesDePersonas.Enqueue(persona_4);
            ColeccionesDePersonas.Enqueue(persona_5);
            ColeccionesDePersonas.Enqueue(persona_6);

            int totalPersonasEnFila = ColeccionesDePersonas.Count - 1;

            while (ColeccionesDePersonas.Count > 0)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (ColeccionesDePersonas.Count == 0) break;
                    Persona p = ColeccionesDePersonas.Dequeue();
                    Console.WriteLine($"La persona que llego fue {p.name} y tiene {p.age} anios");

                }
                Console.WriteLine("termina un proceso");

            }

            Console.WriteLine(ColeccionesDePersonas.Count);
            //foreach(Persona p in ColeccionesDePersonas)
            //{
            //    Console.WriteLine($"La persona que llego fue {p.name} y tiene {p.age} anios");
            //}

            Dictionary<string, Persona> dictionaryPersonas = new Dictionary<string, Persona>();

            dictionaryPersonas.Add(persona_1.name, persona_1);
            dictionaryPersonas.Add(persona_2.name, persona_2);
            dictionaryPersonas.Add(persona_3.name, persona_3);
            dictionaryPersonas.Add(persona_4.name, persona_4);
            dictionaryPersonas.Add(persona_5.name, persona_5);
            dictionaryPersonas.Add(persona_6.name, persona_6);

            if (dictionaryPersonas.ContainsKey("Marco Cantu")) {
                Console.WriteLine("Existe marco en la lista");
            }


            foreach (KeyValuePair<string, Persona> data in dictionaryPersonas)
            {
                string Key = data.Key;
                Persona p = data.Value;

                Console.WriteLine($"La persona es {p.name} y tiene {p.age} anios");
            }


        }

        public static void ListSortExample()
        {
            List<Persona> ColeccionesDePersonas = new List<Persona>();
            SortedList<string, Persona> listaDePersonsas = new SortedList<string, Persona>();
            SortedList<int, Persona> listaDePersonsasAge = new SortedList<int, Persona>();

            Persona persona_1 = new Persona();
            persona_1.name = "Marco Cantu";
            persona_1.age = 40;

            Persona persona_2 = new Persona();
            persona_2.name = "Juan Luis";
            persona_2.age = 37;

            Persona persona_3 = new Persona();
            persona_3.name = "Antonio Peres";
            persona_3.age = 27;

            Persona persona_4 = new Persona();
            persona_4.name = "Benito Garcia";
            persona_4.age = 55;

            Persona persona_5 = new Persona();
            persona_5.name = "Carlos Juan";
            persona_5.age = 19;

            Persona persona_6 = new Persona();
            persona_6.name = "Zoe Medina";
            persona_6.age = 20;

            ColeccionesDePersonas.Add(persona_1);
            ColeccionesDePersonas.Add(persona_2);
            ColeccionesDePersonas.Add(persona_3);
            ColeccionesDePersonas.Add(persona_4);
            ColeccionesDePersonas.Add(persona_5);
            ColeccionesDePersonas.Add(persona_6);

            listaDePersonsas.Add(persona_1.name, persona_1);
            listaDePersonsas.Add(persona_2.name, persona_2);
            listaDePersonsas.Add(persona_3.name, persona_3);
            listaDePersonsas.Add(persona_4.name, persona_4);
            listaDePersonsas.Add(persona_5.name, persona_5);
            listaDePersonsas.Add(persona_6.name, persona_6);

            listaDePersonsasAge.Add(persona_1.age, persona_1);
            listaDePersonsasAge.Add(persona_2.age, persona_2);
            listaDePersonsasAge.Add(persona_3.age, persona_3);
            listaDePersonsasAge.Add(persona_4.age, persona_4);
            listaDePersonsasAge.Add(persona_5.age, persona_5);
            listaDePersonsasAge.Add(persona_6.age, persona_6);

            foreach (Persona persona in ColeccionesDePersonas)
            {
                Console.WriteLine(persona.name);
            }


            //SortByAge sortAgeClass = new SortByAge();
            //ColeccionesDePersonas.Sort(sortAgeClass);
            //ColeccionesDePersonas.Reverse();

            Console.WriteLine("aplicando sort");
            Console.WriteLine("");
            Console.WriteLine("");

            ColeccionesDePersonas.Sort(new SortBySalary());
            ColeccionesDePersonas.Reverse();

            foreach (Persona persona in ColeccionesDePersonas)
            {
                Console.WriteLine($"La persona {persona.name} tiene {persona.age} años");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("listando lista sort");
            Console.WriteLine("");
            Console.WriteLine("");

            foreach (KeyValuePair<string, Persona> item in listaDePersonsas)
            {
                Console.WriteLine($"La persona {item.Value.name} tiene {item.Value.age} años");
            }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("listando lista sort por age");
            Console.WriteLine("");
            Console.WriteLine("");

            foreach (KeyValuePair<int, Persona> item in listaDePersonsasAge)
            {
                Console.WriteLine($"La persona {item.Value.name} tiene {item.Value.age} años");
            }
        }

        public static void EjemploFuncionesList()
        {
            List<Persona> ColeccionesDePersonas = new List<Persona>();
            Persona persona_1 = new Persona();
            persona_1.name = "Marco Cantu";
            persona_1.age = 40;

            Persona persona_2 = new Persona();
            persona_2.name = "Juan Luis";
            persona_2.age = 37;

            Persona persona_3 = new Persona();
            persona_3.name = "Antonio Peres";
            persona_3.age = 27;

            Persona persona_4 = new Persona();
            persona_4.name = "Benito Garcia";
            persona_4.age = 55;

            Persona persona_5 = new Persona();
            persona_5.name = "Carlos Juan";
            persona_5.age = 19;

            Persona persona_6 = new Persona();
            persona_6.name = "Zoe Medina";
            persona_6.age = 20;

            ColeccionesDePersonas.Add(persona_1);
            ColeccionesDePersonas.Add(persona_2);
            ColeccionesDePersonas.Add(persona_3);
            ColeccionesDePersonas.Add(persona_4);
            ColeccionesDePersonas.Add(persona_5);
            ColeccionesDePersonas.Add(persona_6);

            double promedioEdades = ColeccionesDePersonas.Average(persona => persona.age);
            int edadMaxima = ColeccionesDePersonas.Max(persona => persona.age);
            int edadMinima = ColeccionesDePersonas.Min(persona => persona.age);
            string nombres = ColeccionesDePersonas.Aggregate((a, b) => new Persona() { name = a.name + "," + b.name }).name;

            Console.WriteLine($"Promiedio de edad de lista es {promedioEdades}");
            Console.WriteLine($"Edad maxima es {edadMaxima}");
            Console.WriteLine($"Edad minima es {edadMinima}");
            Console.WriteLine($"listado de nombre contactenados");
            Console.WriteLine(nombres);

        }

        public static void FoundMedian()
        {
            List<int> listaInt = new List<int>() {
                1,
                8,
                5,
                3,
                5,
                6,
                7
            };
            listaInt.Sort();

            if ((listaInt.Count % 2) == 1)
            {
                int index = (int)((listaInt.Count() / 2) - .5);
                Console.WriteLine(listaInt[index]);
            }
            else
            {

            }
        }
        public static void ListadoFloats()
        {

            List<Ejercicio01> laFlota = new List<Ejercicio01>();

            using (var reader = new StreamReader(@"C:\jlr\ejercicio01.csv"))
            {
                //List<string> listA = new List<string>();
                //List<string> listB = new List<string>();



                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    double bbase = Convert.ToDouble(values[0]);
                    double altura = Convert.ToDouble(values[1]);
                    double ancho = Convert.ToDouble(values[2]);
                    double resultado = bbase * altura * ancho;


                    laFlota.Add(new Ejercicio01()
                    {
                        bbase = Convert.ToDouble(values[0]),
                        altura = Convert.ToDouble(values[1]),
                        ancho = Convert.ToDouble(values[2]),
                        //resultado = resultado
                    });

                }
            }

            int indice = 0;



            foreach (Ejercicio01 valor in laFlota)
            {
                laFlota[indice].resultado = laFlota[indice].bbase * laFlota[indice].altura * laFlota[indice].ancho;
                laFlota.IndexOf(valor);
                Console.WriteLine($"El resultado es {valor.resultado}");
                indice++;
            }

        }


        public static void EjercicioAgregado()
        {
            int[] valores = { 1, 2, 3 };
            int total = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                total += valores[i];
            }
            //Overload1: El Agregado simple
            Console.WriteLine(valores.Aggregate((ant,nuevo)=>ant+nuevo));
            //Overload2: Inicias desde el acumulador 10
            Console.WriteLine(valores.Aggregate(10, (ant, nuevo) => ant + nuevo));
            //Overolad3: Al resultado final se le agrega otra operación
            Console.WriteLine(valores.Aggregate(10,(ant, nuevo) => ant + nuevo,ant=>ant*2));


        }

    }
  
    class Ejercicio01
    {
        public double bbase { get; set; }
        public double altura { get; set; }
        public double ancho { get; set; }
        public double resultado { get; set; }
    }

    class Persona : IComparable<Persona>
    {
        public string name { set; get; }
        public int age { get; set; }
        public double salary { get; set; }
        
        public int CompareTo(Persona other)
        {
            return this.name.CompareTo(other.name);
        }
    }

    class SortByAge : IComparer<Persona>
    {
        public int Compare(Persona x, Persona y)
        {
            
            if (x.age > y.age) return 1;
            if (x.age < y.age) return -1;

            return 0;

        }
    }

    class SortByName : IComparer<Persona>
    {
        
        public int Compare(Persona x, Persona y)
        {
            return x.name.CompareTo(y.name);
        }
    }

    class SortBySalary : IComparer<Persona>
    {
        public int Compare(Persona x, Persona y)
        {
            if (x.salary > y.salary) return 1;
            if (x.salary < y.salary) return -1;

            return 0;
        }
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

   
    class Proceso
    {
        public float precioAActualizar { get; set; }
        public string cuando { set; get; }

        public void ActualizarPublicacion()
        {
            Console.WriteLine($"Actualizando publicacion con precio {precioAActualizar}");
        }
    }
    class Partida { 
    public string precio { get; set; }
        public string desc { get; set; }
    }
}
