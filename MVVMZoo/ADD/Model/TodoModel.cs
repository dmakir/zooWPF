using System;
using System.ComponentModel;

namespace MVVMZoo.ADD.Model
{
    public class TodoModel
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;
        private bool _vacctina;
        private string _animal;
        private string _height;
        private string _weight;
        private string _sound;
        private string _eyeColor;

        public bool Vacctina
        {
            get { return _vacctina; }
            set
            {
                if (_vacctina == value)
                    return;
                _vacctina = value;
                OnPropertyChanged("Vacctina");
            }
        }

        public string Animal
        {
            get { return _animal; }
            set
            {
                if (_animal == value)
                    return;
                _animal = value;
                OnPropertyChanged("Animal");
            }
        }

        public string Height
        {
            get { return _height; }
            set
            {
                if (_height == value)
                    return;
                _height = value;
                OnPropertyChanged("Heigth");
            }
        }

        public string Weight
        {
            get { return _weight; }
            set
            {
                if (_weight == value)
                    return;
                _weight = value;
                OnPropertyChanged("Weight");
            }
        }

        public string EyeColor
        {
            get { return _eyeColor; }
            set
            {
                if (_eyeColor == value)
                    return;
                _eyeColor = value;
                OnPropertyChanged("EyeColor");
            }
        }

        public string Sound
        {
            get { return _sound; }
            set
            {
                if (_sound == value)
                    return;
                _sound = value;
                OnPropertyChanged("Sound");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}