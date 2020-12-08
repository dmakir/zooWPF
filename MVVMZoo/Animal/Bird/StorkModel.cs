using WPFZOOMVVM;

namespace MVVMZoo.ViewModels.Bird
{
    public class StorkModel:Bird,IAnimal
    {
        private readonly string _soundStork;
        public float Height { get; set; }
        public float Weight { get; set; }
        public string EyeColor { get; set; }


        public StorkModel(float heightStork, float weightStork, string eyeColorStork, float flightAltitude) : base(flightAltitude)
        {
            Height = heightStork;
            Weight = weightStork;
            EyeColor = eyeColorStork;
        }

        public string Info()
        {
            return ($"\nРостом" + Height.ToString().PadLeft(14) +
                    $"\nВес " + Weight.ToString().PadLeft(16) + $"\nЦвет глаз" +
                    EyeColor.ToString().PadLeft(15)+ "\nЯ лечу на высоте  " + _flightAltitude + " метров");
        }
    }
}