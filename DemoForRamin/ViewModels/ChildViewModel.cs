using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForRamin.ViewModels
{
    public class ChildViewModel : INotifyPropertyChanged
    {
        public ChildViewModel(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public string Title { get; set; }
        public string Text { get; set; }
        //public string LogMessage { get; set; }
        private string logMessage;

        public string LogMessage
        {
            get { return logMessage; }
            set
            {
                logMessage = value;
                OnPropertyChanged(nameof(LogMessage));
            }
        }

        public void CreateLogMessage()
        {
            LogMessage = $"Entered ChildViewModel with title {Title} and {Text}";
        }

        public void OpenFilePicker()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                //Do something here with the file
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            var eh = this.PropertyChanged;
            if (null != eh)
            {
                eh(this, new PropertyChangedEventArgs(propName));
            }
        }

    }
}
