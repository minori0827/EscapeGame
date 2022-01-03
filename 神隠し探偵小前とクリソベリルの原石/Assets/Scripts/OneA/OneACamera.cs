using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OneACamera : CameraRotation
{
    enum OAR
    {
        OAR0 = 0,
        OAR1 = 1,
    }
    
    public void Start()
    {
        HideArrows();
        rightArrow.SetActive(true);
    }
    
    OAR OACR = OAR.OAR0;
    
    public void OnRightArrow()
    {
        OACR ++;
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        OACR --;
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        HideArrows();
        if (OACR == OAR.OAR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,-20,0);
            rightArrow.SetActive(true);
        }
        else if (OACR == OAR.OAR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,20,0);
            leftArrow.SetActive(true);
        }
    }
}
