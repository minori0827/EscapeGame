using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class OneDDoor : DoorNekoAna
{
    [SerializeField] Item.Type clearItem;
    public bool OneDFlag = false;
    
    public void OnThis()
    {
        if (OneDFlag == true)
        {
            RoomChange();
        }
        else
        {
            bool Clear = ItemBox.instance.TryUseItem(clearItem);
            if (Clear == true)
            {
                Flowchart.BroadcastFungusMessage("OneDDoorOpen");
                ItemBox.instance.UsedItem();
                OneDFlag = true;
            }
            else
            {
                Flowchart.BroadcastFungusMessage("OneDDoorClose");
            }
        }
    }
}
