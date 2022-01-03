using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public GameObject Camera;
    public GameObject rightArrow;
    public GameObject leftArrow;
    
    public void HideArrows()
    {
        leftArrow.SetActive(false);
        rightArrow.SetActive(false);
    }
    
    public void PhysicsRaycasterOn()
    {
        Camera.GetComponent<UnityEngine.EventSystems.PhysicsRaycaster>().enabled = true;
    }
    
    public void PhysicsRaycasterOff()
    {
        Camera.GetComponent<UnityEngine.EventSystems.PhysicsRaycaster>().enabled = false;
    }
    
    /*各スクリプト機能まとめ(省略抜き)
    OnRightArrow()
    {
        currentRotation += 1;
        ChangeRotation();
    }
    
    OnLeftArrow()
    {
        currentRotation -= 1;
        ChangeRotation();
    }
    
    ChangeRotation()
    {
        HideArrows();
        if (currentRotation == Rotation.Rotation0)
        {
            Cameras.transform.localRotation = Quaternion.Euler(x,y,z);
            Arrow.SetActive(true);
        }
        else if (currentRotation == Rotation.Rotation1)
        {
            Camera.transform.localRotation = Quaternion.Euler(x,y,z);
            Arrow.SetActive(true);
        }
    }
    */
}
