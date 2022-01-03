using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class OneADoor : DoorNekoAna
{
    public bool OneAFlag = false;
    public GameObject KeyItem;
    
    public void OnThis()
    {
        if (OneAFlag == true)
        {
            if(Mode.instance.mode == 1)
            {
                Flowchart.BroadcastFungusMessage("DoorNekoda");
            }
            else
            {
                RoomChange();
            }
        }
        else
        {
            if (KeyItem.activeSelf == false)
            {
                Flowchart.BroadcastFungusMessage("OneADoorOpen");
                OneAFlag = true;
            }
            else
            {
                Flowchart.BroadcastFungusMessage("OneADoorClose");
            }
        }
    }
}
