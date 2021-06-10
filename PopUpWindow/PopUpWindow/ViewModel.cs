using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace PopUpWindow
{
    public class ViewModel
    {
        public static Session session;
        static string pathFile = @"C:\Users\julka\source\repos\PopUpWindow\PopUpWindow\file.json";
        string jsonString;
        
        public Session currentSession { get => session; }
        public ViewModel()
        {
            jsonString = File.ReadAllText(pathFile);
            if (jsonString.ToString() != String.Empty)
                session = JsonSerializer.Deserialize<Session>(jsonString);
            else
                session = new Session();
            
        }
        public static void SaveClass()
        {
            string jsonString = JsonSerializer.Serialize(session);
            File.WriteAllText(pathFile, jsonString);
        }
       
    }
}
