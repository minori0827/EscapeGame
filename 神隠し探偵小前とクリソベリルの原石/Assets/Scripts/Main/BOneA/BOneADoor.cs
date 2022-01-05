using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class BOneADoor : DoorNekoAna
{
    public GameObject jemRed;
    public GameObject jemBlue;
    public bool BOneAFlag = false;
    
    public void Onthis()
    {
        if (BOneAFlag)
        {
            RoomChange();
        }
        else if (jemRed.activeSelf == false && jemBlue.activeSelf == false)
        {
            Flowchart.BroadcastFungusMessage("BOneADoorOpen");
            BOneAFlag = true;
        }
        else
        {
            Flowchart.BroadcastFungusMessage("BOneADoorClose");
        }
    }
}
