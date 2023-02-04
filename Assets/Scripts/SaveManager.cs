using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

[System.Serializable]
public class SaveObject
{
    public int highScore;

    public SaveObject(int highScore)
    {
        this.highScore = highScore;
    }
}

public static class SaveManager
{
    public static string directory = "Save";
    public static string fileName = "savefile.savefile";

    public static void Save(SaveObject so)
    {
        if (!DirectoryExists())
            Directory.CreateDirectory(Application.persistentDataPath + "/" + directory);
        
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(GetFullPath());
        bf.Serialize(file, so);
        file.Close();
    }

    public static SaveObject? Load()
    {
        if (SaveExists())
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(GetFullPath(), FileMode.Open);
                SaveObject so = (SaveObject)bf.Deserialize(file);
                file.Close();

                return so;
            }
            catch (SerializationException)
            {
                Debug.Log("Corrupted File...");
            }
        }

        return null;
    }

    private static bool SaveExists()
    {
        return File.Exists(GetFullPath());
    }

    private static bool DirectoryExists()
    {
        return Directory.Exists(Application.persistentDataPath + "/" + directory);
    }

    private static string GetFullPath()
    {
        return Application.persistentDataPath + "/" + directory + "/" + fileName;
    }
}
