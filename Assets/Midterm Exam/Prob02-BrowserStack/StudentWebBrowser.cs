using System;
using System.Collections.Generic;

namespace MidtermExam.Prob02
{
    public class StudentWebBrowser
    {
        private Stack<string> backHistory = new Stack<string>();
        private Stack<string> forwardHistory = new Stack<string>();
        private string currentUrl = string.Empty;

        public void Open(string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return;
            
            if (!string.IsNullOrEmpty(currentUrl))
            {
                backHistory.Push(currentUrl);
            }
            currentUrl = url;
            forwardHistory.Clear();
        }

        public void Back()
        {
            if (backHistory.Count == 0) return;
            
            forwardHistory.Push(currentUrl);
            currentUrl = backHistory.Pop();
        }

        public void Forward()
        {
            if (forwardHistory.Count == 0) return;
            
            backHistory.Push(currentUrl);
            currentUrl = forwardHistory.Pop();
        }

        public string Current()
        {
            return currentUrl;
        }
    }
}
