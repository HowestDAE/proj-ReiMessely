﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloonsTD6Inspector.Model
{
    public class GameObject
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }

        public string ImageURL 
        { 
            get
            {
                string imageName = (Id == "bloon") ? "base" : Type;
                string typeName = (Type == "hero") ? "heroes" : Type + "s";
                Console.WriteLine($"https://statsnite.com/images/btd/{typeName}/{Id}/{imageName}.png");
                return $"https://statsnite.com/images/btd/{typeName}/{Id}/{imageName}.png";
            }
        }
    }
}