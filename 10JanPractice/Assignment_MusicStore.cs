// using System;
// using System.Collections;

// public class Album
// {
//     public string Title { get; set; }
//     public string Artist { get; set; }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         ArrayList albums = new ArrayList();

//         while (true)
//         {
//             Console.WriteLine("Enter album title (or type 'quit' to stop):");
//             string title = Console.ReadLine();

//             if (title != null && title.Trim().ToLower() == "quit")
//                 break;

//             Console.WriteLine("Enter artist name:");
//             string artist = Console.ReadLine();

          
//             if (IsValidInput(title) && IsValidInput(artist))
//             {
//                 Album album = new Album();
//                 album.Title = title;
//                 album.Artist = artist;
//                 albums.Add(album);
//             }
//         }

//         DisplayAlbums(albums);
//     }

 
//     private static bool IsValidInput(string input)
//     {
//         return !string.IsNullOrWhiteSpace(input);
//     }

//     private static void DisplayAlbums(ArrayList albums)
//     {
//         foreach (object obj in albums)
//         {
//             Album a = (Album)obj;   // casting because ArrayList is non-generic
//             Console.WriteLine("Title: " + a.Title + ", Artist: " + a.Artist);
//         }
//     }
// }
