using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoBCamera : CameraRotation
{
    enum TBR
    {
        TBR0 = 0,
        TBR1 = 1,
        TBR2 = 2,
    }
    
    public void Start()
    {
        leftArrow.SetActive(true);
        rightArrow.SetActive(true);
    }
    
    TBR TBCR = TBR.TBR1;
    
    public void OnRightArrow()
    {
        if (TBCR == TBR.TBR2)
        {
            TBCR -= 2;
        }
        else
        {
            TBCR ++;
        }
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        if (TBCR == TBR.TBR0)
        {
            TBCR += 2;
        }
        else
        {
            TBCR --;
        }
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        if (TBCR == TBR.TBR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,80,0);
        }
        else if (TBCR == TBR.TBR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(-10,300,0);
        }
        else if (TBCR == TBR.TBR2)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,180,0);
        }
    }
}
