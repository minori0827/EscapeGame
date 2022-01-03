using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskCamera : SubCamera
{
    public GameObject Drawer1;
    public GameObject Drawer2;
    public GameObject Drawer3;
    public GameObject Drawer4;
    
    public override void ReturnArrow()
    {
        Drawer1.GetComponent<Drawer>().Close();
        Drawer2.GetComponent<Drawer>().Close();
        Drawer3.GetComponent<Drawer>().Close();
        Drawer4.GetComponent<Drawer>().Close();
    }
}
