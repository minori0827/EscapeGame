using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchCanvasSwitcher : MonoBehaviour
{
    public GameObject searchCanvas;
    
    public void SearchCanvasOn()
    {
        searchCanvas.SetActive(true);
    }
    public void SearchCanvasOff()
    {
        searchCanvas.SetActive(false);
    }
}
