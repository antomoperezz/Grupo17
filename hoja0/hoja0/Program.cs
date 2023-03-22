namespace hoja0
{
    internal class Program
    {
        struct Alumno
        {
            public string nombre, apellido1, apellido2;
            public long dni;
            public int telefono;
        }
        struct Listado
        {
            public int num; // numero de alumnos del listado
            public Alumno[] v; // array de alumnos
        }

        static void Main()
        {

        }

        static void Crea(out Listado lst, int n)
        {
            lst.num = n;
            lst.v = new Alumno[n];
        }

        static int Compara(Alumno al1, Alumno al2)
        {
            if (al1.dni < al2.dni) return (-1);
            else if (al1.dni > al2.dni) return 0;
            else return 1;
        }

        void Inserta(ref Listado lst, Alumno al)
        {
            bool igual = false, lleno = false;
            int i = 0;
            if (lst.v[lst.num - 1].dni != 0)
            {
                Console.WriteLine("La lista ya se encuentra llena.");
                lleno = true;
            }
            while (i < lst.num && !igual && !lleno)
            {
                if (Compara(lst.v[i], al) == 1)
                {
                    Console.WriteLine("El alumno introducido ya se encuentra en la lista");
                    igual = true;
                }
                else if (Compara(lst.v[i], al) == -1 && Compara(lst.v[i + 1], al) == 0)
                {
                    for (int j = i; j < lst.num; j++)
                    {
                        lst.v[j + 1] = lst.v[j];
                    }
                    lst.v[i] = al;
                }
                i++;
            }
        }

        static void Elimina(ref Listado lst, long dni)
        {
            int i = 0; bool encontrado = false;
            while (i < lst.num && !encontrado)
            {
                if (lst.v[i].dni == dni)
                {
                    for (int j = i; j < lst.num; j++)
                    {
                        lst.v[j] = lst.v[j + 1];
                    }
                    lst.v[lst.num - 1].dni = 0;
                    lst.v[lst.num - 1].nombre = null;
                    lst.v[lst.num - 1].apellido1 = null;
                    lst.v[lst.num - 1].apellido2 = null;
                    lst.v[lst.num - 1].telefono = 0;
                    encontrado = true;
                }
                i++;
            }
        }

        void CambiaTel(ref Listado lst, long dni, int tel)
        {
            int i = 0; bool encontrado = false;
            while (i < lst.num && !encontrado)
            {
                if (lst.v[i].dni == dni) 
                {
                    lst.v[i].telefono = tel;
                    encontrado = true;
                }
                i++;
            }
            if (!encontrado) Console.WriteLine("El dni introducido no se encuentra en la base de datos.");
        }

        void Vuelca(Listado lst)
        {

        }

        void Recupera(Listado lst)
        {

        }
    }
}