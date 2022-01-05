using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneDCamera : CameraRotation
{
    enum ODR
    {
        ODR0 = 0,
        ODR1 = 1,
    }
    
    public void Start()
    {
        HideArrows();
        rightArrow.SetActive(true);
    }
    
    ODR ODCR = ODR.ODR0;
    
    public void OnRightArrow()
    {
        ODCR ++;
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        ODCR --;
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        HideArrows();
        if (ODCR == ODR.ODR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,150,0);
            rightArrow.SetActive(true);
        }
        else if (ODCR == ODR.ODR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,250,0);
            leftArrow.SetActive(true);
        }
    }
}
