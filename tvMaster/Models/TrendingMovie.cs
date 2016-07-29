using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tvMaster.Models
{
    public class TrendingMovie
    {
        public int watchers { get; set; }
        public Movie movie { get; set; }
    }

    public class Movie
    {
        public string title { get; set; }
        public int year { get; set; }
        public Ids ids { get; set; }
    }

    public class Ids
    {
        public long trakt { get; set; }
        public string slug { get; set; }
        public string imdb { get; set; }
        public long tmdb { get; set; }
    }
    public class MostPlayedMovies
    {
        public long watcher_count { get; set; }
        public long play_count { get; set; }
        public long collected_count { get; set; }
        public Movie movie { get; set; }
    }
    public class AnticipatedMovies
    {
        public long list_count { get; set; }
        public Movie movie { get; set; }
    }


    //Classes from here going down are for shows
    public class TrendingShows
    {
        public long watchers { get; set; }
        public Show show { get; set; }
    }

    public class Show
    {
        public string title { get; set; }
        public long year { get; set; }
        public IdsShows ids { get; set; }
    }

    public class IdsShows
    {
        public long trakt { get; set; }
        public string slug { get; set; }
        public long tvdb { get; set; }
        public string imdb { get; set; }
        public long tmdb { get; set; }
        public long tvrage { get; set; }
    }

    public class PlayedShows
    {
        public long watcher_count { get; set; }
        public long play_count { get; set; }
        public long collected_count { get; set; }
        public long collector_count { get; set; }
        public Show show { get; set; }
    }
    public class AnticipatedShows
    {
        public long list_count { get; set; }
        public Show show { get; set; }
    }

    //From here going down its all about comments 

    public class comments
    {
        public long id { get; set; }
        public string comment { get; set; }
        public bool spoiler { get; set; }
        public bool review { get; set; }
        public int parent_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public long replies { get; set; }
        public long likes { get; set; }
        public long user_rating { get; set; }
        public User user { get; set; }
    }

    public class User
    {
        public string username { get; set; }
        public bool _private { get; set; }
        public string name { get; set; }
        public bool vip { get; set; }
        public bool vip_ep { get; set; }
    }






















    public class GetImages
    {
        public string type { get; set; }
        public object score { get; set; }
        public Movies movie { get; set; }
    }

    public class Movies
    {
        public string title { get; set; }
        public int year { get; set; }
        public IdsImage ids { get; set; }
        public Images images { get; set; }
    }

    public class IdsImage
    {
        public int trakt { get; set; }
        public string slug { get; set; }
        public string imdb { get; set; }
        public int tmdb { get; set; }
    }

    public class Images
    {
        public Fanart fanart { get; set; }
        public Poster poster { get; set; }
        public Logo logo { get; set; }
        public Clearart clearart { get; set; }
        public Banner banner { get; set; }
        public Thumb thumb { get; set; }
    }

    public class Fanart
    {
        public string full { get; set; }
        public string medium { get; set; }
        public string thumb { get; set; }
    }

    public class Poster
    {
        public string full { get; set; }
        public string medium { get; set; }
        public string thumb { get; set; }
    }

    public class Logo
    {
        public string full { get; set; }
    }

    public class Clearart
    {
        public string full { get; set; }
    }

    public class Banner
    {
        public string full { get; set; }
    }

    public class Thumb
    {
        public string full { get; set; }
    }









    /////////////////////////////////Shows




    public class ShowsImages
    {
        public string type { get; set; }
        public object score { get; set; }
        public Shows show { get; set; }
    }

    public class Shows
    {
        public string title { get; set; }
        public int year { get; set; }
        public IdsShowsImages ids { get; set; }
        public ImagesShows images { get; set; }
    }

    public class IdsShowsImages
    {
        public int trakt { get; set; }
        public string slug { get; set; }
        public int tvdb { get; set; }
        public string imdb { get; set; }
        public int tmdb { get; set; }
        public int tvrage { get; set; }
    }

    public class ImagesShows
    {
        public Fanart fanart { get; set; }
        public Poster poster { get; set; }
        public Logo logo { get; set; }
        public Clearart clearart { get; set; }
        public Banner banner { get; set; }
        public Thumb thumb { get; set; }
    }

    public class FanartShow
    {
        public string full { get; set; }
        public string medium { get; set; }
        public string thumb { get; set; }
    }

    public class PosterShow
    {
        public string full { get; set; }
        public string medium { get; set; }
        public string thumb { get; set; }
    }

    public class LogoShow
    {
        public string full { get; set; }
    }

    public class ClearartShow
    {
        public string full { get; set; }
    }

    public class BannerShow
    {
        public string full { get; set; }
    }

    public class ThumbShow
    {
        public string full { get; set; }
    }


    //Search wild
    public class SearchMovies
    {
        public string type { get; set; }
        public float score { get; set; }
        public MovieSearch movie { get; set; }
    }

    public class MovieSearch
    {
        public string title { get; set; }
        public int? year { get; set; }
        public IdsSearch ids { get; set; }
    }

    public class IdsSearch
    {
        public int trakt { get; set; }
        public string slug { get; set; }
        public string imdb { get; set; }
        public int tmdb { get; set; }
    }



    public class SearchShows
    {
        public string type { get; set; }
        public float score { get; set; }
        public ShowSearch show { get; set; }
    }

    public class ShowSearch
    {
        public string title { get; set; }
        public int year { get; set; }
        public IdsShowSearch ids { get; set; }
    }

    public class IdsShowSearch
    {
        public int trakt { get; set; }
        public string slug { get; set; }
        public int tvdb { get; set; }
        public string imdb { get; set; }
        public int? tmdb { get; set; }
        public int? tvrage { get; set; }
    }

}