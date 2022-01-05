using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOneACamera : CameraRotation
{
    enum BOAR
    {
        BOAR0 = 0,
        BOAR1 = 1,
    }
    
    public void Start()
    {
        HideArrows();
        leftArrow.SetActive(true);
    }
    
    BOAR BOACR = BOAR.BOAR1;
    
    public void OnRightArrow()
    {
        BOACR ++;
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        BOACR --;
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        HideArrows();
        if (BOACR == BOAR.BOAR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,-20,0);
            rightArrow.SetActive(true);
        }
        else if (BOACR == BOAR.BOAR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0,120,0);
            leftArrow.SetActive(true);
        }
    }
}
