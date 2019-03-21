using Builder.Product;

namespace Builder.Builder
{
    /// <summary>
    /// Same as MonkeyBuilder, the KittenBuilder class will implement the details for building a Kitten object.
    /// </summary>
    class KittenBuilder : AnimalBuilder
    {
        public KittenBuilder()
        {
            animal = new Kitten();
        }

        public override void BuildHead()
        {
            animal.Head = "Kitten's Head has been built";
        }

        public override void BuildBody()
        {
            animal.Body = "Kitten's Body has been built";
        }

        public override void BuildArm()
        {
            animal.Arm = "Kitten's Arm has been built";
        }

        public override void BuildLeg()
        {
            animal.Leg = "Kitten's Leg has been built";
        }

        public override void BuildTail()
        {
            animal.Tail = "Kitten's Tail has been built";
        }
    }
}
