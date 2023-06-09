using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using System;
using System.Data.SqlTypes;

public class JsonDataService : IDataService
{
    public T LoadData<T>(string relativePath, bool encryptedPath)
    {
        string path = Application.persistentDataPath + relativePath;
        if (!System.IO.File.Exists(path))
        {
            
            return default(T);
        }
        try
        {
            T data = JsonConvert.DeserializeObject<T>(System.IO.File.ReadAllText(path));
            
            return data;
        }
        catch(Exception e)
        {
            Debug.LogError("Error due to: "+e.Message);
            throw e;
        }
    }

    public bool SaveData<T>(string relativePath, T data, bool encrypted)
    {
        string path = Application.persistentDataPath + relativePath;
        
        
            try
            {

            if (System.IO.File.Exists(path))
            {
                Debug.Log("Data exists.Deleting the old file,creating new one");
                System.IO.File.Delete(path);
            }

            else
            {
                Debug.Log("Creating new file");
            }
                
                using FileStream stream = System.IO.File.Create(path);
                stream.Close();
                System.IO.File.WriteAllText(path,JsonConvert.SerializeObject(data));
                return true;
            }
            catch (Exception e)
            {
                Debug.LogError("Couldnot save data due to "+e.Message);
                return false;
            }
        
       
    }

    public void ClearSavedData(string relativePath)
    {
        
            Debug.Log("DataDeleted");
            System.IO.File.Delete(relativePath);
        
    }
}
