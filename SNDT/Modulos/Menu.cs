﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNDT
{
    public class Menu
    {
        private ArbolGeneral arbolPrincipal;

        //"inicio" contiene la primer vista del programa, mostrando los modulos disponibles
        public void inicio(ArbolGeneral inArbolGeneral)
        {
            bool salirMenu = false;
            do
            {
                #region Menu
                menuMostrarTitulo(" ");
                Console.WriteLine("\t1. Modulo de Administracion\n" +
                                  "\t2. Modulo de Consultas\n" +
                                  "\t3. Salir\n");
                Console.Write("\nOpcion: "); string opcion = Console.ReadLine();
                #endregion

                #region Opciones
                switch (opcion)
                {
                    case "1":
                        Administracion administracion = new Administracion();
                        administracion.inicioAdmin(inArbolGeneral);
                        break;
                    case "2":
                        Consulta consultas = new Consulta();
                        consultas.inicioConsulta(inArbolGeneral);
                        break;
                    case "3":
                        salirMenu = true;
                        Console.WriteLine("Presione una tecla para salir...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey();
                        break;
                } 
                #endregion

            } while (!salirMenu);
        }

        #region Metodos
        public static void menuMostrarTitulo(string espacio)
        {
            Console.Clear();
            Console.Write("\n [  [ [Sistema de Nombres de Dominio Taxonómico (SNDT)] ]  ]\n " +
                          "\n[=> Menu > " + espacio + "\n\n");
        }

        public static char obtenerRespusta()
        {
            try
            {
                Console.Write("¿Desea respetir proceso? (s/n): ");
                return Convert.ToChar(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Opcion no valida, presione una tecla para salir...");
                Console.ReadKey();
                return 'n';
            }

        } 
        #endregion

    }
}
