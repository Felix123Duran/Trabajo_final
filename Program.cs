using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal_fum_Pogram
{
    class Program
    {

        static void Main(string[] args)
        {
          
           
            //nombre de usuario y contraseña
            string[] NombresUsuarios = new string[] { "Felix Duran","Adolfo Matias","Mirian Cruz"," Manuela Josefina","Bruce Weyne" };
            string[] Rol_Usuarios = new string[] { "Administrador", "Supervisor", "Vendedor " };

            int[] N_Usuarios = new int[] { 789987, 145274125, 124545127, 45612784, 456123789 };
            int[] N_ClaveUsuarios = new int[] {123456789 , 145789641, 7531598 , 1415263121, 124512741 };
            DateTime Fecha_Usuario = new DateTime (2000,08,12);
            DateTime Fecha_Usuario2 = new DateTime(2001, 05, 10);
            DateTime Fecha_Usuario3 = new DateTime(1988, 01, 20);
            DateTime Fecha_Usuario4 = new DateTime(1999, 10, 10);
            int USUARIO, contraseña;

            // bucle de respuesta al ususario
            
            do
            {
                
                //entrada del usuario
                Console.Write("Introdusca su N/O de cedula (usuario): ");
                USUARIO = int.Parse(Console.ReadLine());
       
                Console.Write("Introdusca su contraseña de forma numerica: ");
                contraseña = int.Parse(Console.ReadLine());

                if (USUARIO == N_Usuarios[0] && contraseña == N_ClaveUsuarios[0])
                {
                    List<string> UsuarioUNO = new List<string>();
                    UsuarioUNO.Add("\nNombre: "+ NombresUsuarios[0]);
                    UsuarioUNO.Add("Username: "+N_Usuarios[0]);
                    UsuarioUNO.Add("Clave: "+N_ClaveUsuarios[0]);
                    UsuarioUNO.Add("Rol: "+Rol_Usuarios[0]);
                    UsuarioUNO.Add("Fecha de creacion: "+ Fecha_Usuario.ToString());

                    UsuarioUNO.Add("Estado: Activo");
                    
                    foreach (var uno in UsuarioUNO)
                    {
                        Console.WriteLine(uno);
                    }
                    
                    Console.ReadKey();
                    return;
                }
                else if (USUARIO == N_Usuarios[1] && contraseña == N_ClaveUsuarios[1])
                {
                    List<string> UsuarioDOS = new List<string>();
                    //UsuarioDOS.Add("Nombre: " + NombresUsuarios[1]);
                    //UsuarioDOS.Add("Username: " + N_Usuarios[1]);
                    //UsuarioDOS.Add("Clave: " + N_ClaveUsuarios[1]);
                    //UsuarioDOS.Add("Rol: " + Rol_Usuarios[1]);
                    //UsuarioDOS.Add("Fecha de creacion: " + Fecha_Usuario2.ToString());

                    UsuarioDOS.Add("\nEstado: Inactivo");

                    foreach (var dos in UsuarioDOS)
                    {
                        Console.WriteLine(dos);
                    }

                    
                    Console.WriteLine("------------Debe volver a validar otro usuario---------------");
                   
                }
                else if (USUARIO == N_Usuarios[2] && contraseña == N_ClaveUsuarios[2])
                {
                    List<string> UsuarioTRES = new List<string>();
                    UsuarioTRES.Add("\nNombre: " + NombresUsuarios[2]);
                    UsuarioTRES.Add("Username: " + N_Usuarios[2]);
                    UsuarioTRES.Add("Clave: " + N_ClaveUsuarios[2]);
                    UsuarioTRES.Add("Rol: " + Rol_Usuarios[2]);
                    UsuarioTRES.Add("Fecha de creacion: " + Fecha_Usuario3.ToString());

                    UsuarioTRES.Add("Estado: Activo");

                    foreach (var tres in UsuarioTRES)
                    {
                        Console.WriteLine(tres);
                    }

                    Console.ReadKey();
                    return;
                }
                else if (USUARIO == N_Usuarios[4] && contraseña == N_ClaveUsuarios[4])
                {
                    List<string> UsuarioCUATRO = new List<string>();
                    UsuarioCUATRO.Add("\nNombre: " + NombresUsuarios[4]);
                    UsuarioCUATRO.Add("Username: " + N_Usuarios[4]);
                    UsuarioCUATRO.Add("Clave: " + N_ClaveUsuarios[4]);
                    UsuarioCUATRO.Add("Rol: " + Rol_Usuarios[2]);
                    UsuarioCUATRO.Add("Fecha de creacion: " + Fecha_Usuario4.ToString());

                    UsuarioCUATRO.Add("Estado: Activo");

                    foreach (var cuatro in UsuarioCUATRO)
                    {
                        Console.WriteLine(cuatro);
                    }
                    Console.ReadKey();
                    return;
                }

                else if (USUARIO == N_Usuarios[4] && contraseña == N_ClaveUsuarios[4])
                {
                    List<string> UsuarioCINCO = new List<string>();
                    UsuarioCINCO.Add("\nNombre: " + NombresUsuarios[4]);
                    UsuarioCINCO.Add("Username: " + N_Usuarios[4]);
                    UsuarioCINCO.Add("Clave: " + N_ClaveUsuarios[4]);
                    UsuarioCINCO.Add("Rol: " + Rol_Usuarios[2]);
                    UsuarioCINCO.Add("Fecha de creacion: " + Fecha_Usuario4.ToString());

                    UsuarioCINCO.Add("Estado: Activo");

                    foreach (var cinco in UsuarioCINCO)
                    {
                        Console.WriteLine(cinco);
                    }
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("REPITE EL PROCESO");

            } while (true);

          
            Console.ReadKey();
        }

    }

}
