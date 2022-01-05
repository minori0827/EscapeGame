using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disc : MonoBehaviour
{
    public enum Bar
    {
        Up = 0,
        Right = 1,
        Down = 2,
        Left = 3,
    }
    
    public DiscBox discBox;
    public GameObject bar;
    public Bar currentBar;
    
    public void TurnBar()
    {
        if (currentBar == Bar.Left)
        {
            currentBar -= 3;
        }
        else
        {
            currentBar += 1;
        }
        DiscRotation();
        discBox.ClearCheck();
    }
    
    public void DiscRotation()
    {
        if (currentBar == Bar.Up)
        {
            bar.transform.localPosition = new Vector3(-0.9f,-0.11f,0.025f);
            bar.transform.localRotation = Quaternion.Euler(0 , 90 , 0);
        }
        else if (currentBar == Bar.Right)
        {
            bar.transform.localPosition = new Vector3(-1.025f,-0.11f,0.1f);
            bar.transform.localRotation = Quaternion.Euler(0 , 0 , 0);
        }
        else if (currentBar == Bar.Down)
        {
            bar.transform.localPosition = new Vector3(-1.1f,-0.11f,-0.025f);
            bar.transform.localRotation = Quaternion.Euler(0 , 270 , 0);
        }
        else if (currentBar == Bar.Left)
        {
            bar.transform.localPosition = new Vector3(-0.975f,-0.11f,-0.1f);
            bar.transform.localRotation = Quaternion.Euler(0 , 180 , 0);
        }
    }
}
