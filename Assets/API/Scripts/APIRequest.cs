using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;

public class APIRequest : MonoBehaviour
{

    
    public enum URL{ 
    
    Joke,
    Fact,
    Ananta
    };


    [SerializeField]string JokesUrl = "https://v2.jokeapi.dev/joke/Dark?type=single";
    [SerializeField] string FactsUrl = "https://uselessfacts.jsph.pl/random.json?language=en";
    [SerializeField] string AnantaUrl = "https://api.chucknorris.io/jokes/random";
    [SerializeField] TMP_Text tMP_Text;
    public URL dataState;


    Dictionary<URL,string> dataType;


    private void Awake()
    {

        

        dataType = new Dictionary<URL, string>() {
            { URL.Joke,JokesUrl },
            {URL.Fact,FactsUrl },
            { URL.Ananta,AnantaUrl}
        
        
        };


    }

    public void GetData()
    {
       
        StartCoroutine(RequestData());
    }


    public IEnumerator RequestData()
    {
       
        using (UnityWebRequest request = UnityWebRequest.Get(dataType[dataState]))
        {
            
            yield return request.SendWebRequest();
            if( request.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log("Connection Error");
            }
            else
            {
               
                Jokes jokes = new Jokes();
                jokes = JsonUtility.FromJson<Jokes>(request.downloadHandler.text);

                if (dataState==URL.Ananta) {

                    if(jokes.value.Contains("Chuck Norris"))
                    {
                        jokes.value = jokes.value.Replace("Chuck Norris","Ananta Jalil");
                    }


                    tMP_Text.text = jokes.value;

                }
                else if(dataState==URL.Fact)
                {
                    tMP_Text.text = jokes.text;
                }
                else
                {
                    tMP_Text.text = jokes.joke;
                }
                
                
            }



        }


    }



    // Start is called before the first frame update

    public void DropDownSelectSystem(int index)
    {

        tMP_Text.text = "";

        switch (index)
        {

            case 0:
                dataState = URL.Joke;
                AudioController.Instance.PlayAudio(AudioController.Instance.Jokes);
                break;
            case 1:
                dataState = URL.Fact;
                AudioController.Instance.PlayAudio(AudioController.Instance.Facts);
                break;
            case 2:
                AudioController.Instance.PlayAudio(AudioController.Instance.Aj);
                dataState = URL.Ananta;
                break;

        }



    }


}
