using WPFZOOMVVM;

namespace MVVMZoo.ViewModels.Bird
{
    public class ChickenModel:Bird,IAnimal
    {
        private readonly string _soundChicken;
        public float Height { get; set; }
        public float Weight { get; set; }
        public string EyeColor { get; set; }


        public ChickenModel(float heightChicken, float weightChicken, string eyeColorChicken,  float flightAltitude) : base(flightAltitude)
        {
            Height = heightChicken;
            Weight = weightChicken;
            EyeColor = eyeColorChicken;
        }

        public string Info()
        {
            return ($"\nРостом" + Height.ToString().PadLeft(15) +
                    $"\nВес " + Weight.ToString().PadLeft(16) + $"\nЦвет глаз" +
                    EyeColor.ToString().PadLeft(15)+ "\nЯ лечу на высоте  " + _flightAltitude + " метров");
        }

        public string Sound()
        {
            return _soundChicken;
        }
    }
}