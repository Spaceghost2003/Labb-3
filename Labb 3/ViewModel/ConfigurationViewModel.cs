using Labb_3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb_3.ViewModel
{
    internal class ConfigurationViewModel : ViewModelBase
    {
        private readonly MainWindowViewModel? mainWindowViewModel;

        private string _query;
        private string _correctAnswer;
        private string _incorrectAnswer1;
        private string _incorrectAnswer2;
        private string _incorrectAnswer3;
           
        public string Query 
        {

            get => _query;
            set
            {
                _query = value;
                RaisePropertyChanged(nameof(Query));
            }
        }

        public string CorrectAnswer
        {
            get => _correctAnswer;
            set
            {
                _correctAnswer = value;
                RaisePropertyChanged(nameof(CorrectAnswer));
            }
        }

        public string IncorrectAnswer1
        {
            get => _incorrectAnswer1;
            set
            {
                _incorrectAnswer1 = value;
                RaisePropertyChanged(nameof(IncorrectAnswer1));
            }
        }

        public string IncorrectAnswer2
        {
            get => _incorrectAnswer2;
            set
            {
                _incorrectAnswer2 = value;
                RaisePropertyChanged(nameof(IncorrectAnswer2));
            }
        }

        public string IncorrectAnswer3
        {
            get => _incorrectAnswer3;
            set
            {
                _incorrectAnswer3 = value;
                RaisePropertyChanged(nameof(IncorrectAnswer3));
            }
        }

        public ConfigurationViewModel(MainWindowViewModel? mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }
    }
}
