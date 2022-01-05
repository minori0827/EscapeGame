using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneCCamera : CameraRotation
{
    enum OCR
    {
        OCR0 = 0,
        OCR1 = 1,
        OCR2 = 2,
    }
    
    public void Start()
    {
        leftArrow.SetActive(true);
        rightArrow.SetActive(true);
    }
    
    OCR OCCR = OCR.OCR0;
    
    public void OnRightArrow()
    {
        if (OCCR == OCR.OCR2)
        {
            OCCR -= 2;
        }
        else
        {
            OCCR ++;
        }
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        if (OCCR == OCR.OCR0)
        {
            OCCR += 2;
        }
        else
        {
            OCCR --;
        }
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        if (OCCR == OCR.OCR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,300,0);
        }
        else if (OCCR == OCR.OCR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,150,0);
        }
        else if (OCCR == OCR.OCR2)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,30,0);
        }
    }
}
