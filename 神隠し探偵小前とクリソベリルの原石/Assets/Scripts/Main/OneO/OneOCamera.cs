using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneOCamera : CameraRotation
{
    enum OOR
    {
        OOR0 = 0,
        OOR1 = 1,
        OOR2 = 2,
        OOR3 = 3,
    }

    OOR OOCR = OOR.OOR0;

    public void Start()
    {
        HideArrows();
        rightArrow.SetActive(true);
        leftArrow.SetActive(true);
    }
    
    public void OnRightArrow()
    {
        if (OOCR == OOR.OOR3)
        {
            OOCR -= 3;
        }
        else
        {
            OOCR += 1;
        }
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        if (OOCR == OOR.OOR0)
        {
            OOCR += 3;
        }
        else
        {
            OOCR -= 1;
        }
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        if (OOCR == OOR.OOR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 160 , 0);
        }
        else if (OOCR == OOR.OOR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 230 , 0);
        }
        else if (OOCR == OOR.OOR2)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 330 , 0);
        }
        else if (OOCR == OOR.OOR3)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 50 , 0);
        }
    }
}
