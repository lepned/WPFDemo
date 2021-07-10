using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForRamin.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Title = "I am inside MainViewModel";
            Text = "Greetings from MainViewModel";
        }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
