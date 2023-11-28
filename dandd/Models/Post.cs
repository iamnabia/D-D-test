using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dandd.Models

{
    private readonly View mainPage;

    public View GetMainPage()
    {
        return this.mainPage;
    }

    public class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

    }


        internal class ObservableObject
        {
            public int _UserOd;
            public int _Id;
            public string _Title;
            public string _Body;
        }
   
        internal class ObservablePropertyAttribute : Attribute
        {
        }


}
