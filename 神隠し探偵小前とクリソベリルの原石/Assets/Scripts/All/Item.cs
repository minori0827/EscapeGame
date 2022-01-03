using System;
using UnityEngine;

[Serializable]
public class Item
{
    public enum Type
    {
        CrossDriver = 0,
        SingleDriver = 1,
        KeyRed = 2,
        KeyBlue = 3,
        KeyGreen = 4,
        KeyBlack = 5,
        JemYellow = 6,
        JemRed = 7,
        JemBlue = 8,
        JemBlack = 9,
        JemWhite = 10,
        Piece9 = 11,
        Piece16 = 12,
        Pliers = 13
    }
    
    public Type type;     //種類
    public Sprite sprite; //画像
    
    public Item(Type type , Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
