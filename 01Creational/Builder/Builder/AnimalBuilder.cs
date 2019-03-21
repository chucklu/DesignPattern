using Builder.Product;

namespace Builder.Builder
{
    /// <summary>
    /// The AnimalBuilder class is a base abstract class. 
    /// It contains all the building methods to construct a general product (Animal). 
    /// A public Animal object is also declared here to implement the concept (GetResult) of returning a ready to use object. 
    /// Well, it can also be a private product object; in that case, a GetResult method has to be introduced to return a ready to use product.
    /// </summary>
    public abstract class AnimalBuilder
    {
        public Animal animal;

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArm();
        public abstract void BuildLeg();
        public abstract void BuildTail();
    }
}
