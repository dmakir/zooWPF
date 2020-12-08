using System;
using System.Collections.Generic;
using System.Text;

namespace WPFZOOMVVM
{
    interface IPetAnimal //дом.жив
    {
        string Name { get; set; }
        string Breed { get; set; }
        string Vaccine { get; set; }
        string WoolColor { get; set; }
        string Birthdate { get; set; }
        string Tenderness();
    }
}