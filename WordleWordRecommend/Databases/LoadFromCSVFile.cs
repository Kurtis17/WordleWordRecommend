using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordleWordRecommend.Models;
using System.Windows;

namespace WordleWordRecommend.Databases
{
    /// <summary>
    /// class used to load and get data from the CSV files
    /// </summary>
    public class LoadFromCSVFile
    {
        public string ErrorCode { get; set; }
        public List<Word> Words { get; set; }

        /// <summary>
        /// when the class is initiated, all public variables within the class are set to empty string and new List
        /// </summary>
        public LoadFromCSVFile()
        {
            ErrorCode = string.Empty;
            Words = new List<Word>();
        }

        /// <summary>
        /// reads all the data within the textwords file and stores them as an word object within the words list variable
        /// </summary>
        /// <returns></returns>
        public bool FromCSVTextWord()
        {
            try
            {
                var info = File.ReadAllLines("listOfWords.csv");
                foreach (string value in info)
                {
                    var line = value.Split(',');
                    Words.Add(new Word()
                    {
                        SingleWord = line[0]
                    });
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }
        }

        /// <summary>
        /// returns the list of words
        /// </summary>
        /// <returns></returns>
        public List<Word> GetWords()
        {
            return Words;
        }
    }
}