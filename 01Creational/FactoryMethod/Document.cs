using System.Collections.Generic;

namespace FactoryMethod
{
    /// <summary>
    /// The 'Creator' abstract class
    ///
    /// declares the factory method, which returns an object of type Product.
    /// Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
    /// may call the factory method to create a Product object.
    /// </summary>
    abstract class Document

    {
        // Constructor calls Factory method
        protected Document()

        {
            CreatePages();
        }

        public List<Page> Pages { get; } = new List<Page>();


        // Factory Method
        public abstract void CreatePages();
    }
}
