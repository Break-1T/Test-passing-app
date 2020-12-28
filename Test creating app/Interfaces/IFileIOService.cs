using System;
using System.Collections.Generic;
using System.Text;
using Test_creating_app.Models;

namespace Test_creating_app.Interfaces
{
    public interface IFileIOService <T>
    {
        public T LoadData();
        public void SaveData(T myList);
    }
}
