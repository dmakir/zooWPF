using System.ComponentModel;
using System.IO;
using MVVMZoo.ADD.Model;
using Newtonsoft.Json;

namespace MVVMZoo.ADD.FileServise
{
    public class FleService
    {
        private readonly string PATH;

        public FleService(string path)
        {
            PATH = path;
        }

        public BindingList<TodoModel> LoadData()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<TodoModel>();
            }

            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<TodoModel>>(fileText);
            }
        }

        public void SaveData(object todoDataList)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(todoDataList);
                writer.Write(output);
            }
        }
    }
}