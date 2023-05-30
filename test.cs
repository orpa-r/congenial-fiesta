using System;

namespace OtherStuff
{
    public class Releases {
        public string Title { get; set; }
        public int ReleaseDate { get; set; }
        public int Length { get; set; }
        public double Rating { get; set; }
    }

    class Program
    {
        static void Main(string[] args) {
            
            static void newAlbum() {

                Releases album = new Releases();

                Console.Write("What's this album called?");
                album.Title = Console.ReadLine();

                Console.Write("When will it release?");
                album.ReleaseDate = Console.ReadLine();

                Console.Write("How many songs will it have?");
                album.Length = Console.ReadLine();

                album.Rating;

            }

        }
    }
}