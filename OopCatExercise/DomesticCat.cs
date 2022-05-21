using System;
namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        public DomesticCat() : base(false, 23, "domestic") { }
        public override string Eat()
        {
            return "Purrrrrrr";
        }
    }
}
