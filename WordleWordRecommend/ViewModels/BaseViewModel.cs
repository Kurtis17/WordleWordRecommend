using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WordleWordRecommend.ViewModels
{
    /// <summary>
    /// A class used to allow other classes to inherit the methods and varaibles of PropertyChanged
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Sets property changes
        /// </summary>
        /// <param name="name"></param>
        public void OnChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

    }
}