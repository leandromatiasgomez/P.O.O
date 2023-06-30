using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Password
{
    private int longitud = 8;
    private string password;
    private int cantidad;

    public Password() { }

    public Password(int longitud, int cantidad)
    {
        this.longitud = longitud;
        this.password = generarPassword();
        Console.WriteLine("Constraseña: " + password);
        if (esFuerte() == true)
        {
            Console.WriteLine("La contraseña es fuerte");
        }
        else
        {
            Console.WriteLine("La contraseña es debil");
        }


    }

    public bool esFuerte()
    {
        bool result = false;
        string numeros = "0123456789";
        string letrasMinusculas = "qwertyuiopasdfghjklñzxcvbnm";
        string letrasMayusculas = "QWERTYUIOPASDFGHJKLÑZXCVBNM";
        int contadorNumeros = 0;
        int contadorLetrasMinusculas = 0;
        int contadorLetrasMayusculas = 0;

        for (int i = 0; i < password.Length; i++)
        {
            if (password.Contains(numeros))
            {
                contadorNumeros++;
                i++;
            }
            if (password.Contains(letrasMayusculas))
            {
                contadorLetrasMayusculas++;
                i++;
            }
            if (password.Contains(letrasMinusculas))
            {
                contadorLetrasMinusculas++;
                i++;
            }
        }

        if (longitud >= 11)
        {

            if (contadorNumeros > 5 && contadorLetrasMayusculas > 2 && contadorLetrasMinusculas > 1)
            {
                result = true;
            }

        }

        return result;
    }

    public string generarPassword()
    {
        Random random = new Random();
        Random aleatorio = new Random();
        string contraseña = "";

        for (int i = 0; i < longitud; i++)
        {
            int ale = aleatorio.Next(1, 3);

            if (i < longitud && ale == 1)
            {
                int numeros = random.Next(0, 9);
                contraseña += numeros.ToString();
            }

            if (i < longitud && ale == 2)
            {
                int n = random.Next(97, 122);
                char letrasMin = Convert.ToChar(n);
                contraseña += letrasMin.ToString();
            }

            if (i < longitud && ale == 3)
            {
                int n = random.Next(65, 90);
                char letrasMay = Convert.ToChar(n);
                contraseña += letrasMay.ToString();
            }

        }

        return contraseña;
    }

    public int getLongitud
    {
        get
        {
            return this.longitud;
        }
    }
    public string getPassword
    {
        get
        {
            return this.password;
        }
    }
    public void setLongitud(int longitud)
    {
        this.longitud = longitud;
    }
}

class Ejecutable
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de contraseñas: ");
        string linea = Console.ReadLine();
        int tamaño = int.Parse(linea);
        Console.Write("Ingrese la longitud de las contraseñas: ");
        linea = Console.ReadLine();
        int longitud = int.Parse(linea);
        Console.WriteLine("");

        Password[] password = new Password[tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            password[i] = new Password(longitud, i);

        }

        Console.ReadKey();
    }
}


