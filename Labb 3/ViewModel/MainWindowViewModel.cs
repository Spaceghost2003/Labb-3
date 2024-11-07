using Labb_3.Command;
using Labb_3.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Labb_3.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<QuestionPackViewModel> Packs { get; set; }

		public string QuestionText { get; set; } = "tester";

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

        public ICommand AddQueryCommand { get; }

        public MainWindowViewModel()
        {
			AddQueryCommand = new DelegateCommand(param => AddQuery()); ; 
        }

        public ConfigurationViewModel ConfigurationViewModel { get; }
        public PlayerViewModel PlayerViewModel { get;}

        private QuestionPackViewModel? _activePack;

		Question question = new Question("what is the capital of Sweden?", "Stockholm", "Paris", "Rom", "Helsinki");
        Question question2 = new Question("Who is the president of the US?", "Joe Biden", "Michael Jackson", "Hilary Clinton", "Scooby Doo");
        Question question3 = new Question("How many legs does a dog have", "Four", "One", "Two", "Three");

        List<Question> myList = new List<Question>();    
 

        QuestionPack myQuestionpack = new QuestionPack("DefaultPack")
        {
       
        };
        public Question Question3
        {
            get => question3;
            set
            {
                question2 = value;
                RaisePropertyChanged(nameof(Question3)); // Notify the UI if this property changes
            }
        }

        public Question Question2
        {
            get => question2;
            set
            {
                question2 = value;
                RaisePropertyChanged(nameof(Question2)); // Notify the UI if this property changes
            }
        }

        QuestionPack myQuestionPack = new QuestionPack("My Pack", Difficulty.Medium, 30)
		{

		};

		
        public QuestionPackViewModel? ActivePack
		{
			get => _activePack;
			set 
			{
				_activePack = value;
				RaisePropertyChanged();
				ConfigurationViewModel.RaisePropertyChanged("ActivePack");
			}
		}


		public  void AddQuery()
		{
            Question newQuestion = new Question(Query, CorrectAnswer, IncorrectAnswer1, IncorrectAnswer2, IncorrectAnswer3);
            myQuestionPack.Questions.Add(newQuestion);
        }

		public static bool CanAddQuery()
		{
			return true;
		}
	}
}
