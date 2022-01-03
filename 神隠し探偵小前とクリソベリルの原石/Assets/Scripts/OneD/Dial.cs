using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dial : MonoBehaviour
{
    public SpriteRenderer number1000;
    public SpriteRenderer number100;
    public SpriteRenderer number10;
    public SpriteRenderer number1;
    
    public List<Sprite> NumberList = new List<Sprite>();
    
    public GameObject rightCover;
    public GameObject leftCover;
    public GameObject safe;
    public GameObject dialCamera;
    
    private bool clear = false;
    
    public enum Number
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9
    }
    Number currentNumber0 = Number.Zero;
    Number currentNumber1 = Number.Zero;
    Number currentNumber2 = Number.Zero;
    Number currentNumber3 = Number.Zero;
    
    public Number clearNumber0;
    public Number clearNumber1;
    public Number clearNumber2;
    public Number clearNumber3;
    
    // ボタンをクリックした時の処理
    public void OnThis(int position)
    {
        if (!clear)
        {
            ChangeNumber(position);
            ShowNumberImage(position);
            ClearCheck();
        }
    }
    // マーク変数を変更
    void ChangeNumber(int position)
    {
        switch (position)
        {
            case 0:
                if (currentNumber0 == Number.Nine)
                {
                    currentNumber0 = 0;
                }
                else
                {
                    currentNumber0++;
                }
                break;
            case 1:
                if (currentNumber1 == Number.Nine)
                {
                    currentNumber1 = 0;
                }
                else
                {
                    currentNumber1++;
                }
                break;
            case 2:
                if (currentNumber2 == Number.Nine)
                {
                    currentNumber2 = 0;
                }
                else
                {
                    currentNumber2++;
                }
                break;
            case 3:
                if (currentNumber3 == Number.Nine)
                {
                    currentNumber3 = 0;
                }
                else
                {
                    currentNumber3++;
                }
                break;
        }
    }
    // マーク変数に応じた画像を表示する
    void ShowNumberImage(int position)
    {
        switch (position)
        {
            case 0:
                number1000.sprite = GetSource(currentNumber0);
                break;
            case 1:
                number100.sprite = GetSource(currentNumber1);
                break;
            case 2:
                number10.sprite = GetSource(currentNumber2);
                break;
            case 3:
                number1.sprite = GetSource(currentNumber3);
                break;
        }
    }
    // マーク変数に応じた画像ソースを取得する
    Sprite GetSource(Number number)
    {
        switch (number)
        {
            case Number.Zero:
                return NumberList[0];
            case Number.One:
                return NumberList[1];
            case Number.Two:
                return NumberList[2];
            case Number.Three:
                return NumberList[3];
            case Number.Four:
                return NumberList[4];
            case Number.Five:
                return NumberList[5];
            case Number.Six:
                return NumberList[6];
            case Number.Seven:
                return NumberList[7];
            case Number.Eight:
                return NumberList[8];
            case Number.Nine:
                return NumberList[9];
        }
        return null;
    }
    
    public void ClearCheck()
    {
        if (currentNumber0 == clearNumber0
            && currentNumber1 == clearNumber1
            && currentNumber2 == clearNumber2
            && currentNumber3 == clearNumber3)
        {
            clear = true;
            safe.GetComponent<Button>().enabled = false;
            safe.GetComponent<Collider>().enabled = false;
            Invoke("CameraBack",1f);
            Invoke("Open",2f);
        }
    }
    
    public void CameraBack()
    {
        dialCamera.GetComponent<SubCamera2>().OnBackArrow2();
        safe.GetComponent<Collider>().enabled = false;
    }
    
    public void Open()
    {
        leftCover.transform.localPosition = new Vector3(-2f,0,-24f);
        leftCover.transform.localRotation = Quaternion.Euler(0,180f,90f);
        rightCover.transform.localPosition = new Vector3(-2f,0,0);
        rightCover.transform.localRotation = Quaternion.Euler(0,180f,90f);
    }
}
