using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    Camera maincamera;

    [SerializeField] GameObject[] blue;
    [SerializeField] GameObject[] red;
    [SerializeField] GameObject[] green;

    [SerializeField] Color blueColor;
    [SerializeField] Color redColor;
    [SerializeField] Color greenColor;
    [SerializeField] Color whiteColor;


    // Start is called before the first frame update
    void Start()
    {
        maincamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.V))
        {
            setTrue(green);
            setTrue(blue);
            setTrue(red);
            maincamera.backgroundColor = whiteColor;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            setTrue(green);
            setFalse(blue);
            setTrue(red);
            maincamera.backgroundColor = blueColor;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            setTrue(green);
            setTrue(blue);
            setFalse(red);
            maincamera.backgroundColor = redColor;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            setFalse(green);
            setTrue(blue);
            setTrue(red);
            maincamera.backgroundColor = greenColor;
        }


    }




    void setTrue(GameObject[] gameObjectArray)

    {
        foreach (var gameObject in gameObjectArray)
        {
            gameObject.SetActive(true);
        }


    }

    void setFalse(GameObject[] gameObjectArray)
    {
        foreach (var gameObject in gameObjectArray)
        {
            gameObject.SetActive(false);
        }
    }
}
