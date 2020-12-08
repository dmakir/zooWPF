using WPFZOOMVVM;

namespace MVVMZoo.ViewModels
{
    public class TigerModel:IAnimal,IWildAnimal
    {
        private string _habitatTiger;
        private string _locationDateTiger;
        private string _soundTiger;
        private float _height;
        private float _weight;
        private string _eyeColor;


        public TigerModel(string habitatTiger, string locationDateTiger, float heightTiger, float weightTiger,
            string eyeColorTiger)
        {
            _habitatTiger = habitatTiger;
            _locationDateTiger = locationDateTiger;
            _height = heightTiger;
            _weight = weightTiger;
            _eyeColor = eyeColorTiger;
        }

        public string Info()
        {
            return ($"Место обитяния " + _habitatTiger.ToString().PadLeft(9) + $"\nДата нахождения " + _locationDateTiger.ToString().PadLeft(15) +
                    $"\nРостом" + _height.ToString().PadLeft(16) +
                    $"\nВес " + _weight.ToString().PadLeft(17) + $"\nЦвет глаз" + _eyeColor.ToString().PadLeft(17));
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
            return _soundTiger;
        }

        public string Habitat
        {
            get { return _habitatTiger; }
            set { _habitatTiger = value; }
        }

        public string LocationDate
        {
            get { return LocationDate; }
            set { LocationDate = value; }
        }
    }
}