using System;
using System.Collections.Generic;

namespace ContactManagerApp
{
    public class ContactManager
    {
        private Dictionary<string, string> contacts;

        public ContactManager()
        {
            contacts = new Dictionary<string, string>();
        }

        public void AddContact(string name, string phone)
        {
            if (!contacts.ContainsKey(name))
            {
                contacts.Add(name, phone);
                Console.WriteLine("Contacto agregado correctamente.");
            }
            else
            {
                Console.WriteLine("El contacto ya existe.");
            }
        }

        public void SearchContact(string name)
        {
            if (contacts.ContainsKey(name))
            {
                Console.WriteLine($"📞 {name}: {contacts[name]}");
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }

        public void DeleteContact(string name)
        {
            if (contacts.Remove(name))
            {
                Console.WriteLine("Contacto eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo eliminar. El contacto no existe.");
            }
        }
    }
}
