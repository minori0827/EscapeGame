using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCamera2 : CameraChanger
{
    public GameObject subCamera;
    public GameObject subCamera2;
    public GameObject subObject2;
    public GameObject backArrow;
    public GameObject backArrow2;
    
    public void OnBackArrow2()
    {
        CameraChange(subCamera2,subCamera);
        subObject2.GetComponent<Collider>().enabled = true;
        backArrow.SetActive(true);
        backArrow2.SetActive(false);
    }
    
    public void OnSubObject2()
    {
        CameraChange(subCamera,subCamera2);
        subObject2.GetComponent<Collider>().enabled = false;
        backArrow.SetActive(false);
        backArrow2.SetActive(true);
    }
}
