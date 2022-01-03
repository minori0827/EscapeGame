using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoACamera : CameraRotation
{
    enum TAR
    {
        TAR0 = 0,
        TAR1 = 1,
        TAR2 = 2,
    }
    
    public void Start()
    {
        HideArrows();
        rightArrow.SetActive(true);
    }
    
    TAR TACR = TAR.TAR0;
    
    public void OnRightArrow()
    {
        TACR ++;
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        TACR --;
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        HideArrows();
        if (TACR == TAR.TAR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,200,0);
            rightArrow.SetActive(true);
        }
        else if (TACR == TAR.TAR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,250,0);
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
        else if (TACR == TAR.TAR2)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,310,0);
            leftArrow.SetActive(true);
        }
    }
}
