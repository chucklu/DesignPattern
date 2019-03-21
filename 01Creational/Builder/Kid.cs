using Builder.Builder;

namespace Builder
{
    class Kid
    {
        public string Name { get; set; }

        //construct process to build an animal object, 
        //after this process completed, a object 
        //will be consider as a ready to use object.
        /// <summary>
        /// This a director
        /// </summary>
        /// <param name="animalBuilder"></param>
        public void MakeAnimal(AnimalBuilder animalBuilder)
        {
            animalBuilder.BuildHead();
            animalBuilder.BuildBody();
            animalBuilder.BuildArm();
            animalBuilder.BuildLeg();
            animalBuilder.BuildTail();
        }
    }
}
