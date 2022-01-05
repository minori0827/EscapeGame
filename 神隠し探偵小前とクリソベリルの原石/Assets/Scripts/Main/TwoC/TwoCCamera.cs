using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoCCamera : CameraRotation
{
    enum TCR
    {
        TCR0 = 0,
        TCR1 = 1,
    }
    
    public void Start()
    {
        HideArrows();
        rightArrow.SetActive(true);
    }
    
    TCR TCCR = TCR.TCR0;
    
    public void OnRightArrow()
    {
        TCCR ++;
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        TCCR --;
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        HideArrows();
        if (TCCR == TCR.TCR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,190,0);
            rightArrow.SetActive(true);
        }
        else if (TCCR == TCR.TCR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,260,0);
            leftArrow.SetActive(true);
        }
    }
}
