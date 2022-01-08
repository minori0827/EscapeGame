using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOneBCamera : CameraRotation
{
    enum BOBR
    {
        BOBR0 = 0,
        BOBR1 = 1,
        BOBR2 = 2,
        BOBR3 = 3,
    }

    BOBR BOBCR = BOBR.BOBR2;

    public void Start()
    {
        HideArrows();
        rightArrow.SetActive(true);
        leftArrow.SetActive(true);
    }
    
    public void OnRightArrow()
    {
        if (BOBCR == BOBR.BOBR3)
        {
            BOBCR -= 3;
        }
        else
        {
            BOBCR += 1;
        }
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        if (BOBCR == BOBR.BOBR0)
        {
            BOBCR += 3;
        }
        else
        {
            BOBCR -= 1;
        }
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        if (BOBCR == BOBR.BOBR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 0 , 0);
        }
        else if (BOBCR == BOBR.BOBR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 90 , 0);
        }
        else if (BOBCR == BOBR.BOBR2)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 180 , 0);
        }
        else if (BOBCR == BOBR.BOBR3)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 270 , 0);
        }
    }
}
