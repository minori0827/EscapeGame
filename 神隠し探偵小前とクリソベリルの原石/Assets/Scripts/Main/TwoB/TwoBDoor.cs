using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TwoBDoor : DoorNekoAna
{
    [SerializeField] Item.Type clearItem;
    public bool TwoBFlag = false;
    
    public void OnThis()
    {
        if (Mode.instance.mode == 1)
        {
            Flowchart.BroadcastFungusMessage("DoorNekoda");
        }
        else if (TwoBFlag == true)
        {
            RoomChange();
        }
        else
        {
            bool Clear = ItemBox.instance.TryUseItem(clearItem);
            if (Clear == true)
            {
                Flowchart.BroadcastFungusMessage("TwoBDoorOpen");
                ItemBox.instance.UsedItem();
                TwoBFlag = true;
            }
            else
            {
                Flowchart.BroadcastFungusMessage("TwoBDoorClose");
            }
        }
    }
}
