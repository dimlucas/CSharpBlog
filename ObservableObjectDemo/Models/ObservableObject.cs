using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableObjectDemo.Models
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void setValue<T>(string propertyName, ref T property, T value)
        {
            //Set the property and raise the event only if the property's value is actually changed
            if (!property.Equals(value))
            {
                property = value;
                raisePropertyChanged(propertyName);
            }
        }

        /// <summary>
        /// Raises the "PropertyChanged" event for the given property
        /// </summary>
        /// <param name="propertyName">The name of the property that changed</param>
        protected void raisePropertyChanged(string propertyName)
        {
            //First check if there are any methods subscribed in the event
            if(PropertyChanged != null)
            {
                //Then construct the event's arguments
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                //Raise the event
                PropertyChanged(this, args);
            }
        }
    }
}
