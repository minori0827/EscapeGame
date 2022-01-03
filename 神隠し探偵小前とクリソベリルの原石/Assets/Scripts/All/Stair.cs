using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Stair : CameraChanger
{
    public GameObject CameraB;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject LightB;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject ArrowsB;
    public GameObject Arrows1;
    public GameObject Arrows2;
    
    public virtual void UseStairB()
    {
        Flowchart.BroadcastFungusMessage("useStairB");
    }
    public virtual void UseStair1()
    {
        Flowchart.BroadcastFungusMessage("useStair1");
    }
    public virtual void UseStair2()
    {
        Flowchart.BroadcastFungusMessage("useStair2");
    }
    
    public void FloorChangeBto1()
    {
        CameraChange(CameraB,Camera1);
        LightChange(LightB,Light1);
        ArrowsChange(ArrowsB,Arrows1);
    }
    
    public void FloorChangeBto2()
    {
        CameraChange(CameraB,Camera2);
        LightChange(LightB,Light2);
        ArrowsChange(ArrowsB,Arrows2);
    }
    
    public void FloorChange1toB()
    {
        CameraChange(Camera1,CameraB);
        LightChange(Light1,LightB);
        ArrowsChange(Arrows1,ArrowsB);
    }
    
    public void FloorChange1to2()
    {
        CameraChange(Camera1,Camera2);
        LightChange(Light1,Light2);
        ArrowsChange(Arrows1,Arrows2);
    }
    
    public void FloorChange2toB()
    {
        CameraChange(Camera2,CameraB);
        LightChange(Light2,LightB);
        ArrowsChange(Arrows2,ArrowsB);
    }
    
    public void FloorChange2to1()
    {
        CameraChange(Camera2,Camera1);
        LightChange(Light2,Light1);
        ArrowsChange(Arrows2,Arrows1);
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
}
