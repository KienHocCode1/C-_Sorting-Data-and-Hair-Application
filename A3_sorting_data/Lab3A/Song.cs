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
    /// this class is responsible for defining what a Song object should have, and inherited from Media class
    /// </summary>
    internal class Song : Media
    {
        // Song getters/setters
        public string Album {  get; set; }
        public string Artist { get; set; }
        /// <summary>
        /// Song constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="album"></param>
        /// <param name="artist"></param>
        public Song(string title, int year, string album, string artist) : base(title, year) 
        {
            this.Album = album;
            this.Artist = artist;
        }
    }
}
