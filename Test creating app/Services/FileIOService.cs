using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Test_creating_app.Interfaces;
using Test_creating_app.Models;

namespace Test_creating_app.Services
{
    public class FileIOService : IFileIOService<BindingList<QuestionPattern>>
    {
        public FileIOService(string Path)
        {
            this._path = Path;
        }

        private readonly string _path;

        public BindingList<QuestionPattern> LoadData()
        {
            if (!File.Exists(_path))
            {
                File.Create(_path).Dispose();
                return new BindingList<QuestionPattern>()
                {
                    new QuestionPattern("Вопрос", "1-й ответ", "2-й ответ")
                };
            }

            using (StreamReader myReader = File.OpenText(_path))
            {
                var filetext = myReader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<QuestionPattern>>(filetext);
            }
        }

        public void SaveData(BindingList<QuestionPattern> questions)
        {
            using (StreamWriter streamWriter = File.CreateText(_path))
            {
                string questionsText = JsonConvert.SerializeObject(questions);
                streamWriter.WriteLine(questionsText);
            }
        }
    }
}
