using WPFZOOMVVM;

namespace MVVMZoo.ViewModels
{
    public class DogModel:IAnimal,IPetAnimal
    {
        private string _nameDog;
        private string _breedDog;
        private string _vaccineDog;
        private string _woolColorDog;
        private string _birthdateDog;
        private string _tendernessDog;
        private readonly string _soundDog;
        private readonly bool _trainingDog = false;
        private float _height;
        private float _weight;
        private string _eyeColor;

        public DogModel(string nameDog, string breedDog, string vaccineDog, string woolColorDog,
            string birthdateDog, bool trainingDog, string tendernessDog, float heightDog, float weightDog, string eyeColorDog)
        {
            _nameDog = nameDog;
            _breedDog = breedDog;
            _vaccineDog = vaccineDog;
            _woolColorDog = woolColorDog;
            _birthdateDog = birthdateDog;
            _trainingDog = trainingDog;
            _tendernessDog = tendernessDog;
            _height = heightDog;
            _weight = weightDog;
            _eyeColor = eyeColorDog;
        }

        public string Info()
        {
            return ($"Кличка" + _nameDog.ToString().PadLeft(28) + $"\nПорода" + _breedDog.ToString().PadLeft(30)
                    + $"\nНаличие прививок" + _vaccineDog.ToString().PadLeft(8) +
                    $"\nЦвет шерсти" + _woolColorDog.ToString().PadLeft(22)
                    + $"\nДата рождения" + _birthdateDog.ToString().PadLeft(20) +
                    $"\nШерсть" + _woolColorDog.ToString().PadLeft(27) + $"\nПроявляет ласку" + _tendernessDog.ToString().PadLeft(14)
                    + $"\nРост  " + _height.ToString().PadLeft(28) + $"\nВес " + _weight.ToString().PadLeft(30)
                    + $"\nЦвет глаз " + _eyeColor.ToString().PadLeft(25));
        }

        public string Name
        {
            get { return _nameDog; }
            set { _nameDog = value; }
        }

        public string Breed
        {
            get { return _breedDog; }
            set { _breedDog = value; }
        }

        public string Vaccine
        {
            get { return _vaccineDog; }
            set { _vaccineDog = value; }
        }

        public string WoolColor
        {
            get { return _woolColorDog; }
            set { _woolColorDog = value; }
        }

        public string Birthdate
        {
            get { return _birthdateDog; }
            set { _birthdateDog = value; }
        }

        string IPetAnimal.Tenderness()
        {
            return _tendernessDog;
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
            return _soundDog;
        }
    }
}