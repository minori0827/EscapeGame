using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    [SerializeField] Item.Type itemType;
    Item item;
    
    public static ItemGet instance;
    
    private void Start()
    {
        item = ItemGenerater.instance.Spawn(itemType);
    }
    
    public void GetItem()
    {
        // アイテムボックス行きにする
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}
