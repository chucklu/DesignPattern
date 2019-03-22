using System.Collections.Generic;

namespace FactoryMethod
{
    /// <summary>
    /// The 'Creator' abstract class
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
