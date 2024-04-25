using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    internal class Program {
        static void Main(string[] args) {
            var songs = new Song[] {
                new Song("Let it be","The Beatles",243),
                new Song("Bridge Over Troubled Water","Simon & Garfunkel",293),
            };
            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {

                Console.WriteLine(@"{0},{1},{2:mm\:ss}", song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
