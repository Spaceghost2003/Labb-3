﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Labb_3.Command
{
    class DelegateCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object?, bool> canExecute;

        public event EventHandler? CanExecuteChanged;

        public DelegateCommand(Action<Object> execute, Func<Object?, bool> canExecute= null)
        {
            ArgumentNullException.ThrowIfNull(execute);
            this.execute = execute;
            this.canExecute = canExecute;
        }



        public void RaiseCanExecuteChanged() => CanExecuteChanged.Invoke(this, EventArgs.Empty);

        public bool CanExecute(object? parameter) => canExecute is null ? true : canExecute(parameter);

        public void Execute(object? parameter) => execute(parameter);

    }
}
