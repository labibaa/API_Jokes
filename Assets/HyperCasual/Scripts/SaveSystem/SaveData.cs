using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public static SaveData instance;
    IDataService dataService = new JsonDataService();
   
    bool EncryptionON;


    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
       
    }
    public void SerializeJson(int highscore)
    {
        if (dataService.SaveData("/SigmaPlayer.json",highscore,EncryptionON))
        {
            Debug.Log("saved");
        }
        else
        {
            Debug.LogError("failed to save");
        }
    }

    public int DeSerializeJson()
    {
       
        return dataService.LoadData<int>("/SigmaPlayer.json",EncryptionON);
    }

   
}
