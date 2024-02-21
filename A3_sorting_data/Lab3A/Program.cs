/*I, Trung Kien Bui, 000356049 certify that this material is my original work. No other person's work has been used without due acknowledgement. 
    Data created: October 31, 2023
    Purpose: This program is created to read data from text file, decrypt some info and display them. obstacles: "-----", '|', '\n', BOOK and MOVIE summary encrypted. ROT13 Wikipedia
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    /// <summary>
    /// Class responsible for prompt user input, return information according to selection.
    /// </summary>
    internal class Program 
    {
        // static Media Array, text file, and mediaCount
        private static Media[] mediaList = new Media[100];
        private static readonly string DATAFILE = "Data.txt";
        private static int mediaCount;
        static void Main(string[] args)
        {
            // Call read method
            ReadData();
            
            //prompt for user input, exit if enter 6
            bool running = true;
            while(running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kien's Media Collection\n" +
                                  "=======================");
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("1. List All Books\n" +
                                  "2. List All Movies\n" +
                                  "3. List All Songs\n" +
                                  "4. List All Media\n" +
                                  "5. Search All Media by Title\n" +
                                  "6. Exit the program\n") ;
                // using try and catch to validate input also "default" in switch case help to validate valid selection.
                try 
                {
                    Console.Write("Enter your choice: ");
                    string userInput = Console.ReadLine();
                    int choice = int.Parse(userInput);
                    switch (choice)
                    {
                        // call List ALL >> BOOK, MOVIE, SONG, ALL TYPE, SEARCH, AND EXIT
                        case 1:
                            ListAllBook();
                            break;
                        case 2:
                            ListAllMovies();
                            break;
                        case 3:
                            ListAllSongs();
                            break;
                        case 4:
                            ListAllMedias();
                            break;
                        case 5:
                            SearchMedia();
                            break;
                        case 6:
                            Console.WriteLine("Good bye");
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option entered.... ");
                            break;
                    }
                    Console.ReadKey();
                } catch (FormatException)
                {
                    Console.WriteLine("Input must be integer..........");
                    Console.ReadKey();
                }
            }
            
        }
        /// <summary>
        /// Reads media data from a file and populates the mediaList array. Sort data into BOOK, MOVIE, SONG catalogue (into its Object)
        /// </summary>
        private static void ReadData()
        {
            string data;
            const string MEDIA_DELIMETER = "-----"; // this is string not CHAR
            try
            {
                //save file to data as string
                data = File.ReadAllText(DATAFILE);
                //split every paragraph into array, get pass FIRST obstacle "-----"
                string[] media_strings = data.Split(new string[] { MEDIA_DELIMETER }, StringSplitOptions.None);
                mediaCount = 0;

                //loop over the array and do some magic
                for (int i = 0; i < media_strings.Length; i++)
                {
                    // convert array back to string for another split, get pass SECOND obstacle '|'
                    string media_string = media_strings[i].Trim();
  
                    if (media_string.Length > 0)
                    {
                        // split the string into array by CHAR '|'
                        string[] properties = media_string.Split('|'); // split CHAR

                        // take first element properties[0] to sort them out
                        string mediaType = properties[0];
                        string title = properties[1];
                        int year = int.Parse(properties[2]);

                        // if first elemnt is BOOK or SONG or MOVIE
                        switch (mediaType)
                        {
                            case "BOOK":
                                // this is where the magic comes from
                                // Currently this is last element. Split last element using '\n' when splitting it is in array state so we can target [0] and [1].
                                string author = properties[3].Split('\n')[0];
                                string summary_book = properties[3].Split('\n')[1];
                                // 4 parameters because of its setup in Book Class
                                Book book = new Book(title, year, author, summary_book);
                                // save the book object to array using array's way. List will be using Add()
                                mediaList[mediaCount] = book;
                                // count how many items in the mediaList array
                                mediaCount++;
                                break;
                            case "SONG":
                                // normal Split('|') no trouble here
                                string album = properties[3];
                                string artist = properties[4];
                                Song song = new Song(title, year, album, artist);
                                mediaList[mediaCount] = song;
                                mediaCount++;
                                break;
                            case "MOVIE":
                                // this is where the magic comes from
                                // Currently this is last element. Split last element using '\n' when splitting it is in array state so we can target [0] and [1].
                                string director = properties[3].Split('\n')[0];
                                string summary_film = properties[3].Split('\n')[1];
                                // 4 parameters because of its setup in Movie Class
                                Movie movie = new Movie(title, year, director, summary_film);
                                // save the movie object to array using array's way. List will be using Add()
                                mediaList[mediaCount] = movie;
                                mediaCount++;
                                break;
                            default:
                                throw new Exception("Media type not supported: " + mediaType);
                        }
                    }
                }
                Console.WriteLine(mediaCount);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Lists all books in the mediaList array.
        /// </summary>
        private static void ListAllBook() 
        {
            Console.WriteLine("\n>>> List All Books\n");
            int listIndex = 0;
            for (int i = 0; i < mediaCount; i++)
            {
                // mediaList is a list of all Book, Song and Movie objects.
                // Because Media type is parent type of Book, Song and Movie, so an
                // array of Media type can hold items of its children type
                // (inheritance and polymorphism).

                // Checking if an item is of type Book, then cast its type from
                // Media to Book, and print it.

                // https://www.geeksforgeeks.org/c-sharp-is-operator-keyword/
                // https://www.codeguru.com/csharp/c-sharp-type-casting/

                Media media = mediaList[i];
                if (media is Book)
                {
                    // because media is of type Book, it's safe to cast media to
                    // type Book.
                    Book book = (Book)media;
                    // static method PrintBook called, located below, ++listIndex ++ means it start from 1 instead of 0
                    PrintBook(++listIndex, book);
                }
            }
            Console.WriteLine("\n");
        }
        /// <summary>
        /// A part of ListAllBook, responsible for printing format
        /// </summary>
        /// <param name="listIndex">number of Book</param>
        /// <param name="book">book objects </param>
        private static void PrintBook(int listIndex, Book book)
        {
            // Console.WriteLine("#" + listIndex + ". (BOOK) Title: " + book.Title + ", Year: " + book.Year + ", Author: " + book.Author);

            // https://www.c-sharpcorner.com/UploadFile/mahesh/format-string-in-C-Sharp/#:~:text=Alignment%20and%20spacing%20using%20C%23%20String%20Format
            Console.WriteLine("#{0,2:00}. (BOOK) Title: {1,-60}, Year: {2,-10}, Author: {3,-0}", listIndex, book.Title, book.Year, book.Author);
        }
        /// <summary>
        /// Decrypt ROT13 Book summary and output when use Search function
        /// </summary>
        /// <param name="listIndex"></param>
        /// <param name="book"></param>
        private static void PrintBookWithSummary(int listIndex, Book book)
        {
            Encryptor encryptor = new Encryptor(book.Summary);
            Console.WriteLine('\n' + "#" + listIndex + ". (BOOK) Title: " + book.Title + ", Year: " + book.Year + ", Author: " + book.Author);
            //call Decrypt() from Encryptor class
            Console.WriteLine("\tSummary: " + encryptor.Decrypt());
        }
        /// <summary>
        /// List all movies in the mediaList array
        /// </summary>
        private static void ListAllMovies()
        {
            // similar to List all Book explaination
            Console.WriteLine("\n>>> List All Movies\n");
            int listIndex = 0;
            for (int i = 0; i < mediaCount; i++)
            {
                Media media = mediaList[i];
                if (media is Movie)
                {
                    Movie movie = (Movie)media;
                    PrintMovie(++listIndex, movie);
                }
            }
            Console.WriteLine("\n");
        }
        /// <summary>
        /// static method to print all movies info, part of ListAllMovies, formatting purpose
        /// </summary>
        /// <param name="listIndex"></param>
        /// <param name="movie"></param>
        private static void PrintMovie(int listIndex, Movie movie)
        {
            // Console.WriteLine("#" + listIndex + ". (MOVIE) Title: " + movie.Title + ", Year: " + movie.Year + ", Director: " + movie.Director);
            Console.WriteLine("#{0,2:00}. (BOOK) Title: {1,-60}, Year: {2,-10}, Director: {3,-0}", listIndex, movie.Title, movie.Year, movie.Director);

        }
        /// <summary>
        /// Decrypt ROT13 Movie summary and output when use Search function
        /// </summary>
        /// <param name="listIndex">Movie number</param>
        /// <param name="movie">movie objects</param>
        private static void PrintMovieWithSummary(int listIndex, Movie movie)
        {
            Encryptor encryptor = new Encryptor(movie.Summary);
            Console.WriteLine('\n' + "#" + listIndex + ". (MOVIE) Title: " + movie.Title + ", Year: " + movie.Year + ", Director: " + movie.Director);
            Console.WriteLine("\tSummary: " + encryptor.Decrypt());
        }
        /// <summary>
        /// List all songs in mediaList array
        /// </summary>
        private static void ListAllSongs()
        {
            // similar explaination with book and movie
            Console.WriteLine("\n>>> List All Songs\n");
            int listIndex = 0;
            for (int i = 0; i < mediaCount; i++)
            {
                Media media = mediaList[i];
                if (media is Song)
                {
                    Song song = (Song)media;
                    PrintSong(++listIndex, song);
                }
            }
            Console.WriteLine("\n");
        }
        /// <summary>
        /// part of List All Song static method, formatting purpose
        /// </summary>
        /// <param name="listIndex">number of song</param>
        /// <param name="song">song objects</param>
        private static void PrintSong(int listIndex, Song song)
        {
            // Console.WriteLine("#" + listIndex + ". (SONG) Title: " + song.Title + ", Year: " + song.Year + ", Album: " + song.Album + ", Artist: " + song.Artist);
            Console.WriteLine("#{0,2:00}. (BOOK) Title: {1,-60}, Year: {2,-10}, Singer: {3,-0}", listIndex, song.Title, song.Year, song.Artist);
        }
        /// <summary>
        /// List everything, BOOK, MOVIE, SONG in mediaList array and display them
        /// </summary>
        private static void ListAllMedias()
        {
            Console.WriteLine("\n>>> List All Medias\n");
            int listIndex = 0;
            for (int i = 0; i < mediaCount; i++)
            {
                Media media = mediaList[i];
                if (media is Book)
                {
                    Book book = (Book)media;
                    PrintBook(++listIndex, book);
                }
                else if (media is Movie)
                {
                    Movie movie = (Movie)media;
                    PrintMovie(++listIndex, movie);
                }
                else if (media is Song)
                {
                    Song song = (Song)media;
                    PrintSong(++listIndex, song);
                }
            }
            Console.WriteLine("\n");
        }
        /// <summary>
        /// Search method, used to display the desire piece of info, display info + its summary if its BOOK and MOVIE
        /// </summary>
        private static void SearchMedia()
        {
            Console.Write("Enter your search key: ");
            // if user input not null return that value, otherwise return "" empty string
            string userInput = Console.ReadLine() ?? "";
            Console.WriteLine("\n>>> Search All Medias by Title: " + userInput + "\n");

            int listIndex = 0;
            for (int i = 0; i < mediaCount; i++)
            {
                Media media = mediaList[i];
                if (media.Search(userInput))
                {
                    if (media is Book)
                    {
                        Book book = (Book)media;
                        PrintBookWithSummary(++listIndex, book);
                    }
                    else if (media is Movie)
                    {
                        Movie movie = (Movie)media;
                        PrintMovieWithSummary(++listIndex, movie);
                    }
                    else if (media is Song)
                    {
                        Song song = (Song)media;
                        PrintSong(++listIndex, song);
                    }
                }
            }
            Console.WriteLine("\n");
        }
    }
}
