using WPFZOOMVVM;

namespace MVVMZoo.ViewModels
{
    public class WolfModel:IAnimal,IWildAnimal
    {
        private string _habitatWolf;
        private string _locationDateWolf;
        private string _soundWolf;
        private readonly bool _leaderWolf = true;
        private float _height;
        private float _weight;
        private string _eyeColor;

        public WolfModel(string habitatWolf, string locationDateWolf, float heightWolf, float weightWolf, string eyeColorWolf, bool leaderWolf)
        {
            _habitatWolf = habitatWolf;
            _locationDateWolf = locationDateWolf;
            _height = heightWolf;
            _weight = weightWolf;
            _eyeColor = eyeColorWolf;
            _leaderWolf = leaderWolf;
        }

        public string Info()
        {
            return ($"Место обитяния " + _habitatWolf.ToString().PadLeft(7) + $"\nДата нахождения " +
                    _locationDateWolf.ToString().PadLeft(13) +
                    $"\nРостом" + _height.ToString().PadLeft(16) +
                    $"\nВес " + _weight.ToString().PadLeft(18) + $"\nЦвет глаз" +
                    _eyeColor.ToString().PadLeft(15)+ $"\nВожак " + _leaderWolf.ToString().PadLeft(17));
        }

        float IAnimal.Height
        {
            get => _height;
            set => _height = value;
        }

        float IAnimal.Weight
        {
            get => _weight;
            set => _weight = value;
        }

        string IAnimal.EyeColor
        {
            get => _eyeColor;
            set => _eyeColor = value;
        }

        public string Sound()
        {
            return _soundWolf;
        }

        public string Habitat
        {
            get { return _habitatWolf; }
            set { _habitatWolf = value; }
        }


        public string LocationDate
        {
            get { return _locationDateWolf; }
            set { _locationDateWolf = value; }
        }
    }
}