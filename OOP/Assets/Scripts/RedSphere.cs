using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSphere : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        //Abstraction
        SetProperties("Sphere", Color.red);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    protected override void DisplayText()
    {
        nameLabel.text = $"You choose the left shape: {ShapeName}";
    }
}
