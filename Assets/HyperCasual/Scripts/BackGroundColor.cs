using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundColor : MonoBehaviour
{
    [SerializeField]
    List<Color> colors;
    Camera mainCamera;


    private void OnEnable()
    {
        DetectCollision.OnCollideHex += SetColor;
        DetectCollision.OnEnterHex += SetColor;
    }
    private void OnDisable()
    {
        DetectCollision.OnCollideHex -= SetColor;
        DetectCollision.OnEnterHex -= SetColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        colors.Add(new Color(242,212,121)/255);
        colors.Add(new Color(195,233,233)/255);
        colors.Add(new Color(203, 195, 222) / 255);
        colors.Add(new Color(169, 217, 225) / 255);
        colors.Add(new Color(227, 236, 207) / 255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Color GetColor()
    {
      return colors[ Random.Range(0, colors.Count)];
    }
    void SetColor()
    {
        mainCamera.backgroundColor = GetColor();
    }
}
