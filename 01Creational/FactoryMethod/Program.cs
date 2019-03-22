using System;

namespace FactoryMethod
{
    class Program
    {
        /// <summary>
        /// Define an interface for creating an object,
        /// but let subclasses decide which class to instantiate.
        /// Factory Method lets a class defer instantiation to subclasses. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { 
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();



            // Display document pages
            foreach (Document document in documents)
            {

                Console.WriteLine("\n" + document.GetType().Name + "--");

                foreach (Page page in document.Pages)

                {

                    Console.WriteLine(" " + page.GetType().Name);

                }

            }


            Console.ReadKey();
        }
    }
}
