// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

//--- XAML programming		(XAML code)		** XAML - Basics		RelayCommand.cs		By WhiskeyTango Coding

** Class (WPF)

*/

/*====================================================    | GENERAL NOTES |    ======================================================*/

** C. Create a relay command. 		(See Setup Notes below...)			** Folder: Core		Class
** WPF .NET 4.8.1

using System;
using System.Windows.Input;

namespace ApplicationName.Core
{
    internal class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public event EventHandler CanExecuteChanged                        // public event EventHandler? CanExecuteChanged 	(.NET 8.0 only)
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}

//---

/*====================================================    | GENERAL NOTES |    ======================================================*/

** IMPORTANT!!

** We can use this for any command in any MVVM project w/o having to change this code at all






/*====================================================    | GENERAL NOTES |    ======================================================*/

//
