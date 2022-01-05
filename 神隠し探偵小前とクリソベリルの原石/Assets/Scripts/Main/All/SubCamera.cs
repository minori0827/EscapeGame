using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCamera : CameraChanger
{
    public GameObject mainCamera;
    public GameObject subCamera;
    public GameObject subObject;
    public GameObject backArrow;
    public GameObject LRArrow;
    
    public virtual void ReturnArrow()
    {
        
    }
    
    public void LRArrowSwitch()
    {
        if (LRArrow.activeSelf == false)
        {
            LRArrow.SetActive(true);
        }
        else
        { 
            LRArrow.SetActive(false);
        }
    }
    
    public void OnBackArrow()
    {
        CameraChange(subCamera,mainCamera);
        subObject.GetComponent<Collider>().enabled = true;
        ReturnArrow();
        backArrow.SetActive(false);
        LRArrowSwitch();
    }
    
    public void OnSubObject()
    {
        LRArrowSwitch();
        CameraChange(mainCamera,subCamera);
        subObject.GetComponent<Collider>().enabled = false;
        backArrow.SetActive(true);
    }
}
