using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleWordRecommend.Models
{
    /// <summary>
    ///  This class is used to be an object which stores the five leeter words from the CSV file
    /// </summary>
    public class Word
    {
        public string SingleWord { get; set; }

        /// <summary>
        /// when the class is initiated, SingleWord is set to an empty string
        /// </summary>
        public Word()
        {
            SingleWord = string.Empty;
        }

        /// <summary>
        /// returns SingleWord
        /// </summary>
        /// <returns></returns>
        public string GetWord()
        {
            return this.SingleWord;
        }

    }
}
