using System.ComponentModel;
using WPFZOOMVVM;

namespace MVVMZoo.ViewModels
{
    public class CatModel:IPetAnimal,IAnimal
    {
        private string _nameCat;
        private string _breedCat;
        private string _vaccineCat;
        private string _woolColorCat;
        private string _birthdateCat;
        private string _tendernessCat;
        private readonly bool _woolCat = true;
        private readonly string _soundCat;
        public float Height { get; set; }
        public float Weight { get; set; }
        public string EyeColor { get; set; }

        public CatModel()
        {
            
        }

        public CatModel(string name, string breed, string vaccine, string color, bool wool, string birthdate,
            string tenderness, float height, float weight, string eyeColor)
        {
            _nameCat = name;
            _breedCat = breed;
            _vaccineCat = vaccine;
            _woolColorCat = color;
            _woolCat = wool;
            _birthdateCat = birthdate;
            _tendernessCat = tenderness;
            Height = height;
            Weight = weight;
            EyeColor = eyeColor;
        }

        public string Inf()
        {
           return ($"Кличка" + _nameCat.ToString().PadLeft(30) + $"\nПорода" + _breedCat.ToString().PadLeft(28)
                        + $"\nНаличие прививок" + _vaccineCat.ToString().PadLeft(8) +
                        $"\nЦвет шерсти" + _woolColorCat.ToString().PadLeft(29)
                        + $"\nДата рождения" + _birthdateCat.ToString().PadLeft(18) +
                        $"\nШерсть" + _woolCat.ToString().PadLeft(27) + $"\nПроявляет ласку" + _tendernessCat.ToString().PadLeft(14)
                        + $"\nРост  " + Height.ToString().PadLeft(28) + $"\nВес " + Weight.ToString().PadLeft(30)
                        + $"\nЦвет глаз " + EyeColor.ToString().PadLeft(25));
        }

        public string Name
        {
            get { return _nameCat; }
            set
            {
                _nameCat = value;
                OnPropertyChanged("Name");
            }
        }

        public string Breed
        {
            get { return _breedCat; }
            set
            {
                _breedCat = value;
                OnPropertyChanged("Breed");
            }
        }

        public string Vaccine
        {
            get { return _vaccineCat; }
            set
            {
                _vaccineCat = value;
                OnPropertyChanged("Vaccine");
            }
        }

        public string WoolColor
        {
            get { return _woolColorCat; }
            set
            {
                _woolColorCat = value;
                OnPropertyChanged("WoolColor");
            }
        }

        public string Birthdate
        {
            get { return _birthdateCat; }
            set
            {
                _birthdateCat = value;
                OnPropertyChanged("Birthdate");
            }
        }

        string IPetAnimal.Tenderness()
        {
            return _tendernessCat;
        }

        public string Tenderness
        {
            get { return _tendernessCat; }
            set { _tendernessCat = value; }
        }

        string IAnimal.Sound()
        {
            return _soundCat;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}