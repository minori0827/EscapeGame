using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TwoCDoor : DoorNekoAna
{
    [SerializeField] Item.Type clearItem;
    public bool TwoCFlag = false;
    
    public void OnThis()
    {
        if (Mode.instance.mode == 1)
        {
            if (TwoCFlag == true)
            {
                Flowchart.BroadcastFungusMessage("DoorNekoda");
            }
            else
            {
                bool Clear = ItemBox.instance.TryUseItem(clearItem);
                if (Clear == true)
                {
                    Flowchart.BroadcastFungusMessage("TwoCDoorKey");
                    ItemBox.instance.UsedItem();
                    TwoCFlag = true;
                }
                else
                {
                    Flowchart.BroadcastFungusMessage("TwoCDoorCloseInside");
                }
            }
        }
        else
        {
            if (TwoCFlag == false)
            {
                Flowchart.BroadcastFungusMessage("TwoCDoorCloseOutside");
            }
            else
            {
                RoomChange();
            }
        }
    }
}
