﻿using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities
{
    public class Samurai:IShortableRangeUnit
    {
        public string Name
        {
            get => "Samurai";
        }
        public void Hit()
        {
            
        }
    }
}
