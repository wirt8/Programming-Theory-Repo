using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private string shapeType;
    [SerializeField] private Material material;
    private void Awake() {
        shapeType = gameObject.name;
    }
    private void OnMouseDown() {
        Debug.Log("aa");
        DisplayText();
    }
    public virtual void DisplayText()
    {
        UIHandler.Instance.DisplayInfo(shapeType, material.color.ToString());
    }

    public virtual void Rotate()
    {
        
    }
}
