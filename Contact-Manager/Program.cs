using System;
using System.ComponentModel.Design;


namespace Contact_Manager
{
    public class Program
    {

        static void Main(string[] args)
        {
            string action = "add";
            List<string> contact = new List<string> { "jafar", "nemer", "raghad" };
            string name = "moayad";

            List<string> result = ContactsManager(contact, action, name);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);

            }

             
        }

        public static List<string> ContactsManager(List<string> contact, string action, string name = "")
        {
            if (action == "add" && name != "")
            {
                AddContact(name, contact);

            }
            if (action == "remove")
            {
                RemoveContact(name, contact);
            }
            if (action == "view")
            {
                ViewAllContacts(contact);
            }

            return contact;
        }


        //

        public static List<string> AddContact(string name, List<string> contact)
        {
            for (int i = 0; i < contact.Count; i++)
            {
                if (name == contact[i])
                {
                    return contact;
                }
            }

            contact.Add(name);
            return contact;
        }

        public static List<string> RemoveContact(string name, List<string> contact)
        {
            for (int i = 0; i < contact.Count; i++)
            {
                if (name == contact[i])
                {
                    contact.Remove(name);
                }
            }

            return contact;
        }

        public static List<string> ViewAllContacts(List<string> contact)
        {
            return contact;
        }



    }
}
