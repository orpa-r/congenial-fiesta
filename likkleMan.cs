using System;

namespace likkleMan
{
    class Program
    {
        static void Main(string[] args) {
	    // start screen (introducing the concept and getting user info)
		    Console.Write("Hello! Welcome to Pop Sensation Simulator! See if you have what it takes to be a Real Popstar! (Press ENTER to Continue...)");
		    Console.ReadLine();

		    //Form??????
		    int age;
		    string legalName;
		    bool recordDealTaken;

		    Console.Write("Are you ready for a record deal?");
		    recordDealTaken = Console.ReadLine();

		    //contract 

		    Console.WriteLine($"This hereby states {legalName} is an artist and brand under the management of VM Records and distribution under SwingSound....");
		    Console.WriteLine("...including but not limited to 6 releases, 4 merchindising oppurtunies and 2 extended tours...");
		    Console.WriteLine($"..and will end when the artist is {age + length}.");

		    Console.Write("Will you sign?");
		    contractSign = Console.ReadLine;
		
		    //if???????

		    Console.Write("Hello New Artist! What are you choosing for your million-dollar stage name?");
		    artistName = Console.ReadLine();

		    Console.WriteLine($"Welcome to the industry {artistName}!");
		
        }
	    static void newAlbum() {
		
	    }
    }
}