using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TurnPuzzle25 : MonoBehaviour
{
    public List<SpriteRenderer> PanelList = new List<SpriteRenderer>();
    public Sprite maru;
    public Sprite batu;
    public GameObject Cover;
    
    private bool clear;
    
    enum Mark
    {
        Maru = 0,
        Batu = 1,
    }
    
    Mark currentMark0 = Mark.Batu;
    Mark currentMark1 = Mark.Batu;
    Mark currentMark2 = Mark.Batu;
    Mark currentMark3 = Mark.Batu;
    Mark currentMark4 = Mark.Batu;
    Mark currentMark5 = Mark.Batu;
    Mark currentMark6 = Mark.Batu;
    Mark currentMark7 = Mark.Batu;
    Mark currentMark8 = Mark.Batu;
    Mark currentMark9 = Mark.Batu;
    Mark currentMark10 = Mark.Batu;
    Mark currentMark11 = Mark.Batu;
    Mark currentMark12 = Mark.Batu;
    Mark currentMark13 = Mark.Batu;
    Mark currentMark14 = Mark.Batu;
    Mark currentMark15 = Mark.Batu;
    Mark currentMark16 = Mark.Batu;
    Mark currentMark17 = Mark.Batu;
    Mark currentMark18 = Mark.Batu;
    Mark currentMark19 = Mark.Batu;
    Mark currentMark20 = Mark.Batu;
    Mark currentMark21 = Mark.Batu;
    Mark currentMark22 = Mark.Batu;
    Mark currentMark23 = Mark.Batu;
    Mark currentMark24 = Mark.Batu;
    
    public void OnPanel(int panelNumber)
    {
        if (!clear)
        {
            if (Mode.instance.mode == 1)
            {
                Flowchart.BroadcastFungusMessage("GimmicNekoda");
            }
            else
            {
                Turn(panelNumber);
                ClearCheck();
            }
        }
    }
    
    public void Turn(int panelNumber)
    {
            if (panelNumber > 4)
            {
                SoloTurn(panelNumber - 5);
            }
            if (panelNumber % 5 != 0)
            {
                SoloTurn(panelNumber - 1);
            }
            SoloTurn(panelNumber);
            if (panelNumber % 5 != 4)
            {
                SoloTurn(panelNumber + 1);
            }
            if (panelNumber < 20)
            {
                SoloTurn(panelNumber + 5);
            }
    }
    
    public void SoloTurn(int panelNumber)
    {
        ChangeMark(panelNumber);
        ShowMarkImage(panelNumber);
    }
    
    public void ChangeMark(int panelNumber)
    {
        switch (panelNumber)
        {
            case 0:
                if (currentMark0 == Mark.Maru)
                {
                    currentMark0++;
                }
                else
                {
                    currentMark0--;
                }
                break;
            case 1:
                if (currentMark1 == Mark.Maru)
                {
                    currentMark1++;
                }
                else
                {
                    currentMark1--;
                }
                break;
            case 2:
                if (currentMark2 == Mark.Maru)
                {
                    currentMark2++;
                }
                else
                {
                    currentMark2--;
                }
                break;
            case 3:
                if (currentMark3 == Mark.Maru)
                {
                    currentMark3++;
                }
                else
                {
                    currentMark3--;
                }
                break;
            case 4:
                if (currentMark4 == Mark.Maru)
                {
                    currentMark4++;
                }
                else
                {
                    currentMark4--;
                }
                break;
            case 5:
                if (currentMark5 == Mark.Maru)
                {
                    currentMark5++;
                }
                else
                {
                    currentMark5--;
                }
                break;
            case 6:
                if (currentMark6 == Mark.Maru)
                {
                    currentMark6++;
                }
                else
                {
                    currentMark6--;
                }
                break;
            case 7:
                if (currentMark7 == Mark.Maru)
                {
                    currentMark7++;
                }
                else
                {
                    currentMark7--;
                }
                break;
            case 8:
                if (currentMark8 == Mark.Maru)
                {
                    currentMark8++;
                }
                else
                {
                    currentMark8--;
                }
                break;
            case 9:
                if (currentMark9 == Mark.Maru)
                {
                    currentMark9++;
                }
                else
                {
                    currentMark9--;
                }
                break;
            case 10:
                if (currentMark10 == Mark.Maru)
                {
                    currentMark10++;
                }
                else
                {
                    currentMark10--;
                }
                break;
            case 11:
                if (currentMark11 == Mark.Maru)
                {
                    currentMark11++;
                }
                else
                {
                    currentMark11--;
                }
                break;
            case 12:
                if (currentMark12 == Mark.Maru)
                {
                    currentMark12++;
                }
                else
                {
                    currentMark12--;
                }
                break;
            case 13:
                if (currentMark13 == Mark.Maru)
                {
                    currentMark13++;
                }
                else
                {
                    currentMark13--;
                }
                break;
            case 14:
                if (currentMark14 == Mark.Maru)
                {
                    currentMark14++;
                }
                else
                {
                    currentMark14--;
                }
                break;
            case 15:
                if (currentMark15 == Mark.Maru)
                {
                    currentMark15++;
                }
                else
                {
                    currentMark15--;
                }
                break;
            case 16:
                if (currentMark16 == Mark.Maru)
                {
                    currentMark16++;
                }
                else
                {
                    currentMark16--;
                }
                break;
            case 17:
                if (currentMark17 == Mark.Maru)
                {
                    currentMark17++;
                }
                else
                {
                    currentMark17--;
                }
                break;
            case 18:
                if (currentMark18 == Mark.Maru)
                {
                    currentMark18++;
                }
                else
                {
                    currentMark18--;
                }
                break;
            case 19:
                if (currentMark19 == Mark.Maru)
                {
                    currentMark19++;
                }
                else
                {
                    currentMark19--;
                }
                break;
            case 20:
                if (currentMark20 == Mark.Maru)
                {
                    currentMark20++;
                }
                else
                {
                    currentMark20--;
                }
                break;
            case 21:
                if (currentMark21 == Mark.Maru)
                {
                    currentMark21++;
                }
                else
                {
                    currentMark21--;
                }
                break;
            case 22:
                if (currentMark22 == Mark.Maru)
                {
                    currentMark22++;
                }
                else
                {
                    currentMark22--;
                }
                break;
            case 23:
                if (currentMark23 == Mark.Maru)
                {
                    currentMark23++;
                }
                else
                {
                    currentMark23--;
                }
                break;
            case 24:
                if (currentMark24 == Mark.Maru)
                {
                    currentMark24++;
                }
                else
                {
                    currentMark24--;
                }
                break;
        }
    }
    
    public void ShowMarkImage(int panelNumber)
    {
        switch (panelNumber)
        {
            case 0:
                PanelList[0].sprite = GetSource(currentMark0);
                break;
            case 1:
                PanelList[1].sprite = GetSource(currentMark1);
                break;
            case 2:
                PanelList[2].sprite = GetSource(currentMark2);
                break;
            case 3:
                PanelList[3].sprite = GetSource(currentMark3);
                break;
            case 4:
                PanelList[4].sprite = GetSource(currentMark4);
                break;
            case 5:
                PanelList[5].sprite = GetSource(currentMark5);
                break;
            case 6:
                PanelList[6].sprite = GetSource(currentMark6);
                break;
            case 7:
                PanelList[7].sprite = GetSource(currentMark7);
                break;
            case 8:
                PanelList[8].sprite = GetSource(currentMark8);
                break;
            case 9:
                PanelList[9].sprite = GetSource(currentMark9);
                break;
            case 10:
                PanelList[10].sprite = GetSource(currentMark10);
                break;
            case 11:
                PanelList[11].sprite = GetSource(currentMark11);
                break;
            case 12:
                PanelList[12].sprite = GetSource(currentMark12);
                break;
            case 13:
                PanelList[13].sprite = GetSource(currentMark13);
                break;
            case 14:
                PanelList[14].sprite = GetSource(currentMark14);
                break;
            case 15:
                PanelList[15].sprite = GetSource(currentMark15);
                break;
            case 16:
                PanelList[16].sprite = GetSource(currentMark16);
                break;
            case 17:
                PanelList[17].sprite = GetSource(currentMark17);
                break;
            case 18:
                PanelList[18].sprite = GetSource(currentMark18);
                break;
            case 19:
                PanelList[19].sprite = GetSource(currentMark19);
                break;
            case 20:
                PanelList[20].sprite = GetSource(currentMark20);
                break;
            case 21:
                PanelList[21].sprite = GetSource(currentMark21);
                break;
            case 22:
                PanelList[22].sprite = GetSource(currentMark22);
                break;
            case 23:
                PanelList[23].sprite = GetSource(currentMark23);
                break;
            case 24:
                PanelList[24].sprite = GetSource(currentMark24);
                break;
        }
    }
    
    Sprite GetSource(Mark mark)
    {
        switch (mark)
        {
            case Mark.Maru:
                return maru;
            case Mark.Batu:
                return batu;
        }
        return null;
    }
    
    public void ClearCheck()
    {
        if (currentMark0 == Mark.Maru
            && currentMark1 == Mark.Maru
            && currentMark2 == Mark.Maru
            && currentMark3 == Mark.Maru
            && currentMark4 == Mark.Maru
            && currentMark5 == Mark.Maru
            && currentMark6 == Mark.Maru
            && currentMark7 == Mark.Maru
            && currentMark8 == Mark.Maru
            && currentMark9 == Mark.Maru
            && currentMark10 == Mark.Maru
            && currentMark11 == Mark.Maru
            && currentMark12 == Mark.Maru
            && currentMark13 == Mark.Maru
            && currentMark14 == Mark.Maru
            && currentMark15 == Mark.Maru
            && currentMark16 == Mark.Maru
            && currentMark17 == Mark.Maru
            && currentMark18 == Mark.Maru
            && currentMark19 == Mark.Maru
            && currentMark20 == Mark.Maru
            && currentMark21 == Mark.Maru
            && currentMark22 == Mark.Maru
            && currentMark23 == Mark.Maru
            && currentMark24 == Mark.Maru)
        {
            Invoke("Open",1f);
            clear = true;
        }
    }
    
    public void Open()
    {
        this.transform.localPosition = new Vector3(0,-14.5f,0);
        Cover.transform.localPosition = new Vector3(0,-14.5f,0);
    }
}
