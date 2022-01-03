using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class OneBDoor : DoorNekoAna
{
    public bool OneBFlag = false;
    
    public void OnThis()
    {
        if (Mode.instance.mode == 1)
        {
            if (OneBFlag == false)
            {
                OneBFlag = true;
                Flowchart.BroadcastFungusMessage("OneBDoorKey");
            }
            else
            {
                Flowchart.BroadcastFungusMessage("DoorNekoda");
            }
        }
        else
        {
            if (OneBFlag == false)
            {
                Flowchart.BroadcastFungusMessage("OneBDoorClose");
            }
            else
            {
                RoomChange();
            }
        }
    }
}
