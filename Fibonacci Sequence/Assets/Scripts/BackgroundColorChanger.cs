using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColorChanger : MonoBehaviour
{
    private Camera cam;
    private void Start()
    {
        cam = Camera.main; // store the camera in a cam variable
        cam.backgroundColor = Random.ColorHSV(); // Change the color at the start of the game
    }
    public void BackgroundColorChange()
    {
        cam.backgroundColor = Random.ColorHSV(); // change the background color to something random whenever you press the button
    }
}
