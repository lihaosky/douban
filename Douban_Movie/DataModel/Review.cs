﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PanoramaApp2
{
    public class Review
    {
        private string _id = "";
        public string id 
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id == value)
                {
                    return;
                }
                _id = value;
                NotifyPropertyChanged("id");
            }
        }
        private string _title = "";
        public string title 
        {
            get
            {
                return _title;
            }
            set
            {
                if (_title == value)
                {
                    return;
                }
                _title = value;
                NotifyPropertyChanged("title");
            }
        }
        private string _review = "";
        public string review 
        {
            get
            {
                return _review;
            }
            set
            {
                if (_review == value)
                {
                    return;
                }
                _review = value;
                NotifyPropertyChanged("review");
            }
        }
        private string _reviewShort = "";
        public string reviewShort
        {
            get
            {
                return _reviewShort;
            }
            set
            {
                if (_reviewShort == value)
                {
                    return;
                }
                _reviewShort = value;
                NotifyPropertyChanged("reviewShort");
            }
        }
        private string _reviewer = "";
        public string reviewer
        {
            get
            {
                return _reviewer;
            }
            set
            {
                if (_reviewer == value)
                {
                    return;
                }
                _reviewer = value;
                NotifyPropertyChanged("revewer");
            }
        }
        private string _date = "";
        public string date 
        {
            get
            {
                return _date;
            }
            set
            {
                if (_date == value)
                {
                    return;
                }
                _date = value;
                NotifyPropertyChanged("date");
            }
        }
        private string _movieId = "";
        public string movieId 
        {
            get
            {
                return _movieId;
            }
            set
            {
                if (_movieId == value)
                {
                    return;
                }
                _movieId = value;
                NotifyPropertyChanged("movieId");
            }
        }
        private string _movieName = "";
        public string movieName 
        {
            get
            {
                return _movieName;
            }
            set
            {
                if (_movieName == value)
                {
                    return;
                }
                _movieName = value;
                NotifyPropertyChanged("movieName");
            }
        }
        private string _star = "";
        public string star {
            get
            {
                return _star;
            }
            set
            {
                if (_star == value)
                {
                    return;
                }
                _star = value;
                NotifyPropertyChanged("star");
            }
        }

        private string _nextCommentLink = "";
        public string nextCommentLink
        {
            get
            {
                return _nextCommentLink;
            }
            set
            {
                _nextCommentLink = value;
            }
        }

        public static string reviewLinkHeader = "http://movie.douban.com/review/";
        public static string hotReviewHeader = "http://movie.douban.com/review/best/";

        public event PropertyChangedEventHandler PropertyChanged;
        // NotifyPropertyChanged will raise the PropertyChanged event, 
        // passing the source property that is being updated.
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Review)
            {
                Review tmp = obj as Review;
                return tmp.id == this.id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
