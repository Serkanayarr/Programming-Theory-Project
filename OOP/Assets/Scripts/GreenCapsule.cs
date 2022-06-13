using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCapsule : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        SetProperties("Capsule", Color.green);
    }
    private void OnMouseDown()
    {
        // ABSTRACTION
        DisplayText();
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        nameLabel.text = $"You clicked the right shape: {ShapeName}";
    }
}
