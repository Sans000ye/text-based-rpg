using System.ComponentModel;

namespace Engine.Models
{
    public class Players : INotifyPropertyChanged
    {
        private string name;
        private string characterclass;
        private int hp;
        private int exp;
        private int level;
        private int money;
        public required string Name { get { return name; } set { name = value; OnPropertyChanged("Name"); } }
        public required string CharacterClass { get { return characterclass; } set { characterclass = value; OnPropertyChanged("Characterclass"); } }
        public int HP { get { return hp; } set { hp = value; OnPropertyChanged("HP"); } }
        public int EXP { get { return exp; } set { exp = value;OnPropertyChanged("EXP"); } }
        public int Level { get { return level; } set { level = value; OnPropertyChanged("Level"); } }
        public int Money { get { return money; } set { money = value; OnPropertyChanged("Money"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}
