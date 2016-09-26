using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservableObjectDemo.Models;

namespace ObservableObjectDemo.ViewModels
{
    /// <summary>
    /// Sample view model demonstrating how the world would be like without Bindings and INotifyPropertyChanged
    /// WHAT IS SHOWN IN THIS VIEW MODEL IS DEPRECATED AND A BAD PROGRAMMING STYLE
    /// MODERN C# / XAML APPLICATIONS SHOULD USE OBSERVABLE OBJECTS AND PROPERTY BINDING
    /// </summary>
    public class NonObservableWorldViewModel
    {

        /// <summary>
        /// Event that gets called when the value of text box containing the name of the pokemon changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void PokemonNameChanged(object sender, EventArgs args)
        {

        }

        /// <summary>
        /// Event that gets called when the value of the text box cotnaining the pokemon's level changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void PokemonLevelChanged(object sender, EventArgs args)
        {

        }

        /// <summary>
        /// Event that gets triggered when the value of the text box containing the pokemon's type changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void PokemonTypeChanged(object sender, EventArgs args)
        {

        }

        private NonObservablePokemon _pokemon;
    }
}
