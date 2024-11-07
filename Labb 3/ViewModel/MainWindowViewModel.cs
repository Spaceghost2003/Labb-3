using Labb_3.Command;
using Labb_3.Model;
using System;
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

        public ICommand MakeNewPack { get; }

        public MainWindowViewModel()
        {
			MakeNewPack = new DelegateCommand(param => Console.WriteLine("Simple command executed.")); ; 
        }

        public ConfigurationViewModel ConfigurationViewModel { get; }
        public PlayerViewModel PlayerViewModel { get;}

        private QuestionPackViewModel? _activePack;

		Question question = new Question("what?", "", "", "", "");
        Question question2 = new Question("what?", "", "", "", "");
        Question question3 = new Question("what?", "", "", "", "");

		QuestionPack myQuestionPack = new QuestionPack("abc", Difficulty.Medium, 30)
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



		public  void AddPack()
		{
			Console.WriteLine("Hej");
		}

		public static bool CanAddPack()
		{
			return true;
		}
	}
}
