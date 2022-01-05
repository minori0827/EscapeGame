using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    string currentDrawerStr = "Close";
    
    public void OnClick()
    {
        if (currentDrawerStr == "Close")
        {
            Open();
        }
        else
        {
            Close();
        }
    }
    
    public void Open()
    {
        this.transform.localPosition = new Vector3(-0.3f,0,0);
        currentDrawerStr = "Open";
    }
    
    public void Close()
    {
        this.transform.localPosition = new Vector3(0,0,0);
        currentDrawerStr = "Close";
    }
}
