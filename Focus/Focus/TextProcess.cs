using System;

public class TextProcess
{
    public TextProcess(int TotalSec)
    {
        //construct
        TotalTime = TotalSec;
    }

    public void SetTotalTime(int NewTotalSec)
    {
        TotalTime = NewTotalSec;
    }

    public void SetCurrentProcess(int NewCurrentTime)
    {
        if (NewCurrentTime > TotalTime)
        {
            NewCurrentTime = TotalTime;
        }
        CurrentTime = NewCurrentTime;
    }

    public void ResetCurrentProcess()
    {
        SetCurrentProcess(0);
    }
    public void CurrentProcessClick()
    {
        CurrentTime++;
        if (CurrentTime > TotalTime)
        {
            CurrentTime = TotalTime;
        }
    }
    public bool IsFull()
    {
        return (CurrentTime == TotalTime);
    }
    public string GetEmptyProcess()
    {
        string s = "";
        s = s + "||";
        for (int i = 0; i < TextLength; i++)
        {
            s = s + ' ';
        }
        s = s + "||";
        s = s + "0" + "/" + Convert.ToString(TotalTime);
        return s;
    }

    public string GetCurrentProcess()
    {
        //return current process text
        string s = "";
        int l_1 = Convert.ToInt32(TextLength * Convert.ToDouble(CurrentTime) / TotalTime);
        int l_2 = TextLength - l_1;

        s = s + "||";
        for (int i = 0; i < l_1; i++)
        {
            s = s + '>';
        }
        for (int i = 0; i < l_2; i++)
        {
            s = s + ' ';
        }
        s = s + "||";
        return s;
    }
    public int GetCurrentTime()
    {
        return CurrentTime;
    }

    //public string GetCurrentTimeMinStr()
    //{
    //    int Min;
    //    string MinStr;

    //    Min = CurrentTime / 60;
    //    MinStr = Min.ToString("00");

    //    return MinStr;
    //}

    //public string GetCurrentTimeSecStr()
    //{
    //    int Sec;
    //    string SecStr;

    //    Sec = CurrentTime % 60;
    //    SecStr = Sec.ToString("00");

    //    return SecStr;
    //}

    //public string GetCurrentTimeMinSecStr()
    //{
    //    return GetCurrentTimeMinStr() + ":" + GetCurrentTimeSecStr();
    //}

    public int GetTotalTime()
    {
        return TotalTime;
    }

    private int TextLength = 50;        //total length
    private int TotalTime = 30 * 60;    //default:30min*60sec
    private int CurrentTime = 0;
}
