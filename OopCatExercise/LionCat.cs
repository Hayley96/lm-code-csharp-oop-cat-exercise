﻿using System;
namespace OopCatExercise
{
    public class LionCat : Cat
    {
        public LionCat() : base(false, 1100, "wild") { }

        public override string Eat()
        {
            return "Roar!!!!";
        }
    }
}
