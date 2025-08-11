using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal class Artist : Person
    {
        public int ArtistId { get; set; }
        public string? StageName { get; set; }
        public string? Genre { get; set; }
        public int AlbumReleased{ get; set; }




        public Artist()
        {
            StageName = "unknown";
            Genre = "unknown";
            AlbumReleased = 0;
        }

        public Artist(string id, string name, string city, int age, int artistId, string stageName, string genre, int albumReleased) : 
            base(id, name, city, age)
        {
            ArtistId = artistId;
            StageName = stageName;
            AlbumReleased=albumReleased;
        }
        public string GetArtistInfo()
        {
            return $"Arist ID : {ArtistId}, Stage Name : {StageName}, Genre : {Genre}, Album Released: {AlbumReleased}";
        }
        public void SetArtistInfo(int artistId, string stageName, int albumReleased)
        {
            ArtistId = artistId;
            StageName = stageName;
            AlbumReleased = albumReleased;
        }
        public void DisplayArtistInfo()
        {
            Console.WriteLine($"Artist Id:  {ArtistId}, Stage Name: {StageName}, Genre: {Genre}, Album Released: {AlbumReleased}");
            base.DisplayPersonInfo();
        }
        public override string ToString()
        {
            return $"Artist Id: {ArtistId}, Stage Name: {StageName}, Album Released: {AlbumReleased}" + 
             base.ToString();
        }
    }
}
