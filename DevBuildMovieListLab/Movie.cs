using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildMovieListLab
{
    class Movie
    {

        private string title = string.Empty;
        private string category = string.Empty;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public Movie(string name, string category)
        {
            Title = name;
            Category = category;

        }


    }
}
