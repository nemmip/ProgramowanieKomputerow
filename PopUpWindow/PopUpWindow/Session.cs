using System.Text.Json;
using System.Text.Json.Serialization;

namespace PopUpWindow
{
    public class Session
    {
        private string textContent;
        

        public string TextContent
        {
            get { return textContent; }
            set { textContent = value; }
        }
        private bool isSessionOpen;

        public bool IsSessionOpen
        {
            get { return isSessionOpen; }
            set { isSessionOpen = value; }
        }


    }
}
