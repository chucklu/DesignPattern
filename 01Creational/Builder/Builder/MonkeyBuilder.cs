using Builder.Product;

namespace Builder.Builder
{
    /// <summary>
    /// The MonkeyBuilder class is a child class of AnimalBuilder. It provides the details of each building method for a Monkey. 
    /// In this class, we apply all the rules to make our product (Monkey) a ready to use object (decorated monkey). 
    /// In the constructor, we also initialize the Animal object (aAnimal) to be a Monkey object.
    /// </summary>
    class MonkeyBuilder:AnimalBuilder
    {
        public MonkeyBuilder()
        {
            animal = new Monkey();
        }

        public override void BuildHead()
        {
            animal.Head = "Monkey's Head has been built";
        }

        public override void BuildBody()
        {
            animal.Body = "Monkey's Body has been built";
        }

        public override void BuildArm()
        {
            animal.Arm = "Monkey's Arm has been built";
        }

        public override void BuildLeg()
        {
            animal.Leg = "Monkey's Leg has been built";
        }

        public override void BuildTail()
        {
            animal.Tail = "Monkey's Tail has been built";
        }
    }
}
