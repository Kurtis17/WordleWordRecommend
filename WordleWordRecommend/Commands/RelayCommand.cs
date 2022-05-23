using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WordleWordRecommend.Commands
{
    /// <summary>
    /// This class is used to relay interactions of the user.
    /// This allows the program to run methods dependent of the users actions.
    /// </summary>
    public class RelayCommand : ICommand
    {
        private Action _action;

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        /// <summary>
        /// Sets _action to action when the class is being initiated 
        /// </summary>
        /// <param name="action"></param>
        public RelayCommand(Action action)
        {
            _action = action;
        }

        /// <summary>
        /// returns true to allow execution in its current state
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// executes the action within the _action variable
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _action();
        }
    }
}
