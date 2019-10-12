using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StudentRecordApplication
{
    // клас для записи и чтения фалов
    [Serializable]
    class FileReaderInteractor
    {
        static public void safeObjects(object student, String fileName)
        {
            // Создаем поток для записи в файл
            FileStream myStream = File.Create(fileName);

            // Помещаем объектный граф в поток в двоичном формате
            BinaryFormatter myBinaryFormat = new BinaryFormatter();
            myBinaryFormat.Serialize(myStream, student);
            myStream.Close();
        }

        // записать список пользователей
        static public void safeObjects(List<object> listStudent, String fileName)
        {
            // в цикле записываем все объекты
            listStudent.ForEach(delegate (object student)
            {
                safeObjects(student, fileName);
            });
        }

        // загрузить объект объектов 
        static public object loadObject(String fileName)
        {
            // Создаем поток для записи в файл
            FileStream myStream = File.OpenRead(fileName);

            // Помещаем объектный граф в поток в двоичном формате
            BinaryFormatter myBinaryFormat = new BinaryFormatter();
            object obj = myBinaryFormat.Deserialize(myStream);
            myStream.Close();
            return obj;
        }
    }
}