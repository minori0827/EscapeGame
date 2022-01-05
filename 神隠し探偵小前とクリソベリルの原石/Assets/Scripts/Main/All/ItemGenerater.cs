using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerater : MonoBehaviour
{
    [SerializeField] ItemListEntity itemListEntity;
    
    public static ItemGenerater instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public Item Spawn(Item.Type type)
    {
        foreach (Item item in itemListEntity.itemList)
        {
            if (item.type == type)
            {
                return new Item(item.type , item.sprite);
            }
        }
        return null;
    }
}
