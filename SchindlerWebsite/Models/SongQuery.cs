using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SchindlerWebsite.Models
{
    public class SongQuery
    {
        public string URL { get; set; }

        public SongQuery(string url)
        {
            this.URL = filterID(url);
        }

        public string filterID(string url)
        {
            //string regExp = "^.*((youtu.be/)|(v/)|(/u/w/)|(embed/)|(watch?))??v?=?([^#&?]*).*";
            //var match = url.match(regExp);
            //return (match && match[7].length == 11) ? match[7] : false;

            var youtubeMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(url);
            return youtubeMatch.Success ? youtubeMatch.Groups[1].Value : string.Empty;
        }
    }
}
