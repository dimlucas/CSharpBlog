using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableObjectDemo.Models
{
    public class ObservablePokemon : ObservableObject
    {

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                setValue(nameof(Name), ref _name, value);
            }
        }

        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                setValue(nameof(Level), ref _level, value);
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                setValue(nameof(Type), ref _type, value);
            }
        }

        private string _name;
        private int _level;
        private string _type;
    }
}
