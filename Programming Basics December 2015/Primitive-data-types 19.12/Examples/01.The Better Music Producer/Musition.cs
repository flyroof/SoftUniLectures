using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.The_Better_Music_Producer
{
    class Musition
    {
        static void Main(string[] args)
        {
            // Input
            string input = Console.ReadLine();
            int europeAlbumsCount = int.Parse(input);
            decimal europeAlbumPrice = decimal.Parse(Console.ReadLine());
            int northAmericaAlbumCount = int.Parse(Console.ReadLine());
            decimal northAmericaAlbumPrice = decimal.Parse(Console.ReadLine());
            int southAmericaAlbumCount = int.Parse(Console.ReadLine());
            decimal southAmericaAlbumPrice = decimal.Parse(Console.ReadLine());
            int concertCount = int.Parse(Console.ReadLine());
            decimal concertPrice = decimal.Parse(Console.ReadLine());

            // Convert money to lv
            europeAlbumPrice = europeAlbumPrice * 1.94m;
            northAmericaAlbumPrice *= 1.72m;
            southAmericaAlbumPrice /= 332.74m;
            concertPrice *= 1.94m;

            // Calculate income from albums
            decimal albumIncome = 0m;
            albumIncome += (europeAlbumsCount * europeAlbumPrice);
            albumIncome = albumIncome + (northAmericaAlbumCount * northAmericaAlbumPrice);
            albumIncome += (southAmericaAlbumCount * southAmericaAlbumPrice);

            // Deduct producer fee, deduct tax
            albumIncome -= albumIncome * 0.35m;
            albumIncome -= albumIncome * 0.2m;

            // Calculate income from concerts
            decimal concertsIncome = concertCount * concertPrice;

            // If concert money > 100 000 deduct 15%
            if (concertsIncome > 100000)
            {
                concertsIncome -= concertsIncome * 0.15m;
            }

            // Check witch is bigger 
            // Output
            if (albumIncome > concertsIncome)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", albumIncome);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", concertsIncome);
            }
        }
    }
}
