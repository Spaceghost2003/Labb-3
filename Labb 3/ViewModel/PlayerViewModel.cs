using Labb_3.Command;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Labb_3.ViewModel
{
    internal class PlayerViewModel : ViewModelBase
    {


        public DelegateCommand UpdateButtonCommand { get; }

        private readonly MainWindowViewModel? mainWindowViewModel;

        private DispatcherTimer timer;
        private string _testData;

        public PlayerViewModel(MainWindowViewModel? mainWindowViewModel)
        {


        }




        private void Timer_Tick(Object? sender, EventArgs e)
        {

        }
    }
}
