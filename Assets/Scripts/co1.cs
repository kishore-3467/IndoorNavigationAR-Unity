using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class co1 : MonoBehaviour
{
    private Canvas CanvasObject;

    void Start()
    {
        CanvasObject = GameObject.Find("Applicationcanvas").GetComponent<Canvas>();
        CanvasObject.GetComponent<Canvas>().enabled = false;
    }

    public void ToggleCanvas()
    {
        if (CanvasObject.enabled == true)
        {
            CanvasObject.GetComponent<Canvas>().enabled = false;
        }
        else
        {
            CanvasObject.GetComponent<Canvas>().enabled = true;
        }
    }
}
