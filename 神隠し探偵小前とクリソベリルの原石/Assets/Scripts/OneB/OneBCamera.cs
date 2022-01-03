using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBCamera : CameraRotation
{
    enum OBR
    {
        OBR0 = 0,
        OBR1 = 1,
    }
    
    public void Start()
    {
        HideArrows();
        leftArrow.SetActive(true);
    }
    
    OBR OBCR = OBR.OBR1;
    
    public void OnRightArrow()
    {
        OBCR ++;
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        OBCR --;
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        HideArrows();
        if (OBCR == OBR.OBR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,240,0);
            rightArrow.SetActive(true);
        }
        else if (OBCR == OBR.OBR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,160,0);
            leftArrow.SetActive(true);
        }
    }
}
