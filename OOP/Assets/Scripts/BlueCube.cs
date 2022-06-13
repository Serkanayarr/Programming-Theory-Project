using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        SetProperties("Cube", Color.blue);
    }
    private void OnMouseDown()
    {
        // ABSTRACTION
        DisplayText();
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        nameLabel.text = $"You clicked the middle shape: {ShapeName}";
    }
}
