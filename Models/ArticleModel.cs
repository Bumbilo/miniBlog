using System;
using System.Collections.Generic;

namespace MiniBlog.Models
{
    public class ArticleModel
    {
        public int Comments { get; set;}
        public string Content {get; set;}
        public string Author {get; set;}
        public string Date {get; set;}
        public string Title {get; set;}
        public string Image {get; set;}
        public int Id {get; set;}

        public IEnumerable<ArticleModel> GetArticles() {
            return ArticleRepositoryModel.GetArticles;
        }
    }

    
}
