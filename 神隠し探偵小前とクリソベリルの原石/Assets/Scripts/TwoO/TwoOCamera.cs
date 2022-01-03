using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoOCamera : CameraRotation
{
    enum TOR
    {
        TOR0 = 0,
        TOR1 = 1,
        TOR2 = 2,
    }
    
    public void Start()
    {
        HideArrows();
        rightArrow.SetActive(true);
    }
    
    TOR TOCR = TOR.TOR0;
    
    public void OnRightArrow()
    {
        TOCR ++;
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        TOCR --;
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        HideArrows();
        if (TOCR == TOR.TOR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,220,0);
            rightArrow.SetActive(true);
        }
        else if (TOCR == TOR.TOR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,290,0);
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
        else if (TOCR == TOR.TOR2)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,0,0);
            leftArrow.SetActive(true);
        }
    }
}
