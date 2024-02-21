/*I, Trung Kien Bui, 000356049 certify that this material is my original work. No other person's work has been used without due acknowledgement. 
    Data created: October 31, 2023
    Purpose: This program is created to read data from text file, decrypt some info and display them. obstacles: "-----", '|', '\n', BOOK and MOVIE summary encrypted. ROT13 Wikipedia
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{   
    /// <summary>
    /// This class is responsible for defining what Book object should have and inherited from Media class
    /// </summary>
    public class Book : Media
    {
        // getters/setters no validation
        public string Author { get; set; }
        // getters/setters no validation
        public string Summary { get; set; }
        /// <summary>
        /// Book constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="author"></param>
        /// <param name="summary"></param>
        public Book(string title, int year, string author, string summary) : base(title, year) 
        { 
            Author = author;
            Summary = summary;
        }

    }
}
