using System;
using System.Collections.Generic;
using System.Text;

namespace ReposiotryDpSample.Entities
{
    class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public DateTime PublishDate { get; set; }
        public int Rate { get; set; }
        public override string ToString()
        {
            return $"id:{MovieId} , name: {MovieName} , publish date : {PublishDate} , rate: {Rate}";
        }
    }
}
