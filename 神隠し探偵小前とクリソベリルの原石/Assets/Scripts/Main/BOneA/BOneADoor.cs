using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class BOneADoor : DoorNekoAna
{
    public GameObject gemRed;
    public GameObject gemBlue;
    public bool BOneAFlag = false;
    public List<GameObject> BOneBDoors = new List<GameObject>();
    
    public void Onthis()
    {
        if (BOneAFlag)
        {
            RoomChange();
            DoorOnOff();
        }
        else if (gemRed.activeSelf == false && gemBlue.activeSelf == false)
        {
            Flowchart.BroadcastFungusMessage("BOneADoorOpen");
            BOneAFlag = true;
        }
        else
        {
            Flowchart.BroadcastFungusMessage("BOneADoorClose");
        }
    }
    
    public void DoorOnOff()
    {
        foreach (GameObject BOneBDoor in BOneBDoors)
        {
            if (BOneBDoor.activeSelf == false)
            {
                BOneBDoor.SetActive(true);
            }
            else
            {
                BOneBDoor.SetActive(false);
            }
        }
    }
}
