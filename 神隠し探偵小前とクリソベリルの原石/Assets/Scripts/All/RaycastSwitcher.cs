using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastSwitcher : MonoBehaviour
{
    public LayerMask CameraLayer;
    public LayerMask SubCameraLayer;
    
    public void CurrentPhysicsRaycasterOn()
    {
        Collider[] findCameras = Physics.OverlapSphere(Vector3.zero, 20, CameraLayer);
        foreach (Collider findCamera in findCameras)
        {
            findCamera.GetComponent<CameraRotation>().PhysicsRaycasterOn();
        }
        
        Collider[] findSubCameras = Physics.OverlapSphere(Vector3.zero, 20, SubCameraLayer);
        foreach (Collider findSubCamera in findSubCameras)
        {
            findSubCamera.GetComponent<CameraChanger>().PhysicsRaycasterOn();
        }
    }
    
    public void CurrentPhysicsRaycasterOff()
    {
        Collider[] findCameras = Physics.OverlapSphere(Vector3.zero, 20, CameraLayer);
        foreach (Collider findCamera in findCameras)
        {
            findCamera.GetComponent<CameraRotation>().PhysicsRaycasterOff();
        }
        
        Collider[] findSubCameras = Physics.OverlapSphere(Vector3.zero, 20, SubCameraLayer);
        foreach (Collider findSubCamera in findSubCameras)
        {
            findSubCamera.GetComponent<CameraChanger>().PhysicsRaycasterOff();
        }
    }
}
