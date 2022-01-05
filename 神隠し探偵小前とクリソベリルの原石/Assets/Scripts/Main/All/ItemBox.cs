using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    [SerializeField] Slot selectedSlot = null;
    
    public static ItemBox instance;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            slots = GetComponentsInChildren<Slot>();
        }
    }
    
    public void SetItem(Item item)
    {
        foreach(Slot slot in slots)
        {
            if (slot.IsEmpty())
            {
                slot.SetItem(item);
                break;
            }
        }
    }
    
    public void OnSelectSlot(int position)
    {
        foreach(Slot slot in slots)
        {
            slot.HideBgPanel();
        }
        if(slots[position].OnSelected())
        {
            selectedSlot = slots[position];
        }
    }
    
    public bool TryUseItem(Item.Type type)
    {
        if(selectedSlot == null)
        {
            return false;
        }
        
        if(selectedSlot.GetItem().type == type)
        {
            return true;
        }
        return false;
    }
    
    public void UsedItem()
    {
        selectedSlot.SetItem(null);
        selectedSlot.HideBgPanel();
        selectedSlot = null;
    }
}
