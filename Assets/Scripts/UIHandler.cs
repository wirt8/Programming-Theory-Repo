using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public static UIHandler Instance {get; private set;}
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private Text shapeText, colorText; 

    void Awake()
    {
        Instance = this;
    }

    public void DisplayInfo(string shape, string color)
    {
        shapeText.text = shape;
        colorText.text = color;
    }
}
