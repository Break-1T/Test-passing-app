using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Test_creating_app.Models
{
    class FileIOService
    {
        public FileIOService(string Path)
        {
            this._path = Path;
        }

        private readonly string _path;

        public List<QuestionPattern> LoadData()
        {
            if (!File.Exists(_path))
            {
                File.Create(_path).Dispose();
                return new List<QuestionPattern>();
            }

            using (StreamReader myReader = File.OpenText(_path))
            {
                var filetext = myReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<QuestionPattern>>(filetext);
            }
        }

        public void SaveData(List<QuestionPattern> questions)
        {
            using (StreamWriter streamWriter = File.CreateText(_path))
            {
                string questionsText = JsonConvert.SerializeObject(questions);
                streamWriter.WriteLine(questionsText);
            }
        }
    }
}
