using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteBook : MonoBehaviour {

    public Text Date;

    public Text page;

    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;

    private int begin;

    // Use this for initialization
    void Awake()
    {
        begin = 0;
    }

    void SetText(int indexText, string text)
    {
        switch (indexText)
        {
            case 0:
                text1.text = text;
                break;
            case 1:
                text2.text = text;
                break;
            case 2:
                text3.text = text;
                break;
            case 3:
                text4.text = text;
                break;
            case 4:
                text5.text = text;
                break;
            case 5:
                text6.text = text;
                break;
            case 6:
                text7.text = text;
                break;
        }
    }

    void setDate()
    {
        Date.text = DateArray.GetDay((int)System.DateTime.Now.DayOfWeek) + " " + System.DateTime.Now.Day + " " + DateArray.GetMonth(System.DateTime.Now.Month);

    }

    void setPage()
    {
        int p = (begin / 7) + 1;
        page.text = p + " / " + ConstantObject.getNumberOfPage();
    }

    void resetPage()
    {
        text1.text = "";
        text2.text = "";
        text3.text = "";
        text4.text = "";
        text5.text = "";
        text6.text = "";
        text7.text = "";
    }

    public void showPage()
    {
        resetPage();

        setDate();

        int end = 7;
        if (((begin / 7) + 1) == ConstantObject.getNumberOfPage())
            end = ConstantObject.getNumberLine() % 7;
        for(int i = 0; i < end; i++)
        {
            SetText(i, ConstantObject.getLine(i + begin));
        }
        setPage();
    }

    public void nextPage()
    {
        begin += 7;
        if(((begin / 7) + 1) > ConstantObject.getNumberOfPage())
        {
            begin -= 7;
        }
        showPage();
    }

    public void predPage()
    {
        begin -= 7;

        if (begin < 0)
            begin = 0;

        showPage();
    }

    public void ResetPage()
    {
        begin = 0;
    }
}
