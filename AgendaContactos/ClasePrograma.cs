using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace AgendaContactos
{
    public class ClasePrograma
    {
        public static List<ClaseContacto> Contacts = new List<ClaseContacto>();
        /*
         * checkPhone(string) verifica que el número de teléfono no esté vacío, tenga 11 dígitos y conste solo de números
         */
        public static bool checkPhone(string phone)

        {
            if (phone == null || phone.Equals(""))
            {
                Console.WriteLine("ERROR: el número de teléfono no puede estar vacio.");
                return false;
            }
            if (phone.Length != 11)
            {
                Console.WriteLine("ERROR: el número de teléfono debe tener 11 dígitos.");
                return false;
            }
            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i] < '0' || phone[i] > '9')
                {
                    Console.WriteLine("ERROR: el número de teléfono debe tener solo números.");
                    return false;
                }
            }
            return true;
        }

        /*
         * printContact(Contact) imprime los datos de un contacto en la consola
         */
        public static void printContact(ClaseContacto contact)
        {
            Console.WriteLine("*************");
            Console.WriteLine("Nombre: " + contact.Name);
            Console.WriteLine("Telefono: " + contact.Phone);
            Console.WriteLine("*************");
        }

        /*
         * readContact() lee los datos de un contacto de la consola
         */
        public static ClaseContacto readContact()
        {
            ClaseContacto contacto = new ClaseContacto();
            do
            {
                Console.WriteLine("Introduce el nombre (obligatorio)");
                try
                {
                    contacto.Name = Console.ReadLine();
                }
                catch (IOException)
                {
                    Console.WriteLine("ERROR: se esperaba un nombre");
                }

            } while (contacto.Name == null || contacto.Name.Equals(""));
            do
            {
                Console.WriteLine("Introduce el número de teléfono (obligatorio, 11 dígitos)");
                try
                {
                    contacto.Phone = Console.ReadLine();
                }
                catch (IOException)
                {
                    Console.WriteLine("ERROR: se esperaba un numero de telefono");
                }
            } while (!checkPhone(contacto.Phone));
            return contacto;
        }

        /*
         * searchContact(List<Contact>) busca un contacto en la agenda por número de teléfono
         */
        public static void searchContact(List<ClaseContacto> agenda)
        {
            string phone = "";
            do
            {
                Console.WriteLine("Por favor, introduce un numero de telefono valido");
                try
                {
                    phone = Console.ReadLine();
                }
                catch (IOException)
                {
                    Console.WriteLine("ERROR: se esperaba un numero");
                }
            } while (!checkPhone(phone));

            ClaseContacto contact = agenda.Find(c => c.Phone == phone);
            if (contact == null)
            {
                Console.WriteLine("No se encontró ningún contacto con el número de teléfono " + phone);
            }
            else
            {
                Console.WriteLine("Se encontró el siguiente contacto:");
                printContact(contact);
            }
        }

        /*
         * insertContact(List<Contact>) inserta un nuevo contacto en la agenda
         */
        public static void insertContact(List<ClaseContacto> agenda)
        {
            ClaseContacto contacto = readContact();
            agenda.Add(contacto);
            Console.WriteLine("Contacto añadido correctamente");
            printContact(contacto);
        }

        /*
         * deleteContact(List<Contact>) elimina un contacto de la agenda
         */
        public static void deleteContact(List<ClaseContacto> agenda)
        {
            ClaseContacto contacto = readContact();
            if (agenda.Remove(contacto))
            {
                Console.WriteLine("Contacto eliminado correctamente");
            }
            else
            {
                Console.WriteLine("No se encontró ningún contacto con esos datos");
            }
        }

        /*
         * updateContact(List<Contact>) actualiza un contacto de la agenda
         */
        public static void updateContact(List<ClaseContacto> agenda)
        {
            ClaseContacto contacto = readContact();
            int index = agenda.FindIndex(c => c.Phone == contacto.Phone);
            if (index == -1)
            {
                Console.WriteLine("No se encontró ningún contacto con esos datos");
            }
            else
            {
                agenda[index] = contacto;
                Console.WriteLine("Contacto actualizado correctamente");
                printContact(contacto);
            }
        }

      
    }

}

