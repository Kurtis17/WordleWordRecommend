using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using WordleWordRecommend.Commands;
using WordleWordRecommend.Views;

namespace WordleWordRecommend.ViewModels
{
    /// <summary>
    /// this class is the main window of the application, it controls the UserControls and depending on the buttons pressed the appropriate WPF will be displayed within the UserControls
    /// </summary>
    public class MainWindowViewModel : BaseViewModel
    {
        #region Button Content
        public string PlayGameContent { get; private set; }
        public string WordFinderContent { get; private set; }
        #endregion

        #region Button Command
        public ICommand PlayGameCommand { get; private set; }
        public ICommand WordFinderCommand { get; private set; }
        #endregion

        #region User Control
        public UserControl ContentControlBindingOne { get; private set; }
        #endregion

        #region Constructor 
        public MainWindowViewModel()
        {
            PlayGameContent = "New word";
            WordFinderContent = "Find word";

            PlayGameCommand = new RelayCommand(PlayGameButtonClick);
            WordFinderCommand = new RelayCommand(WordFinderButtonClick);

            

        }
        #endregion

        #region Button Click
        private void PlayGameButtonClick()
        {

        }
        private void WordFinderButtonClick()
        {

        }
        #endregion 
    }
}