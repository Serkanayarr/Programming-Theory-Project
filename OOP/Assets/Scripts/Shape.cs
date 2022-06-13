using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI nameLabel;
 
    // Encapsulation
    public string ShapeName { get; protected set; }
    public Color ShapeColor { get; protected set; }

    //Polymorphism
    protected virtual void DisplayText() 
    {
        nameLabel.text = ShapeName;
    }   

    //Abstraction
    protected void SetProperties(string name, Color color) 
    {
        ShapeName = name;
        ShapeColor = color;
        GetComponent<Renderer>().material.color = ShapeColor;
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
