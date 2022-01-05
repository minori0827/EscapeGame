using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DoorNekoAna : CameraChanger
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Arrows1;
    public GameObject Arrows2;
    
    public void RoomChange()
    {
        if(Camera1.activeSelf == true)
        {
            CameraChange(Camera1,Camera2);
            LightChange(Light1,Light2);
            ArrowsChange(Arrows1,Arrows2);
        }
        else
        {
            CameraChange(Camera2,Camera1);
            LightChange(Light2,Light1);
            ArrowsChange(Arrows2,Arrows1);
        }
    }
    
    public void LightChange(GameObject currentLight,GameObject nextLight)
    {
        currentLight.SetActive(false);
        nextLight.SetActive(true);
    }
    
    public void ArrowsChange(GameObject currentArrows,GameObject nextArrows)
    {
        currentArrows.SetActive(false);
        nextArrows.SetActive(true);
    }
    
    public void UseNekoAna()
    {
        if (Mode.instance.mode == 0)
        {
            Flowchart.BroadcastFungusMessage("nekoAnaClose");
        }
        else if (Mode.instance.mode == 1)
        {
            NekoAnaBack();
        }
        else
        {
            NekoAnaOpen();
        }
    }
    
    public virtual void NekoAnaOpen()
    {
        //Flowchart.BroadcastFungusMessage("nekoAnaOpen");
    }
    public virtual void NekoAnaBack()
    {
        //Flowchart.BroadcastFungusMessage("nekoAnaBack");
    }
}
