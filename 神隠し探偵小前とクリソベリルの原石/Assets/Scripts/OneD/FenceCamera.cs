using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceCamera : CameraRotation
{
    enum ODFR
    {
        ODFR0 = 0,
        ODFR1 = 1,
    }
    
    public void Start()
    {
        HideArrows();
        rightArrow.SetActive(true);
    }
    
    ODFR ODCFR = ODFR.ODFR0;
    
    public void OnRightArrow()
    {
        ODCFR ++;
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        ODCFR --;
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        HideArrows();
        if (ODCFR == ODFR.ODFR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(-50,180,0);
            rightArrow.SetActive(true);
        }
        else if (ODCFR == ODFR.ODFR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(-50,0,0);
            leftArrow.SetActive(true);
        }
    }
}
