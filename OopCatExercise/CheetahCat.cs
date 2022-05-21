using System;
namespace OopCatExercise
{
    public class CheetahCat : Cat
    {
        public CheetahCat() : base(true, 900, "wild") { }
        public override string Eat()
        {
            return "Zzzzzzz";
        }
    }
}
