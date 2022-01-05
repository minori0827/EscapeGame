using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour
{
    public void CameraChange(GameObject currentCamera,GameObject nextCamera)
    {
        currentCamera.SetActive(false);
        nextCamera.SetActive(true);
    }
    
    public void PhysicsRaycasterOn()
    {
        this.GetComponent<UnityEngine.EventSystems.PhysicsRaycaster>().enabled = true;
    }
    
    public void PhysicsRaycasterOff()
    {
        this.GetComponent<UnityEngine.EventSystems.PhysicsRaycaster>().enabled = false;
    }
}
