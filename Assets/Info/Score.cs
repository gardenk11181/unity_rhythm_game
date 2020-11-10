using System;
public class Score
{
    private int perfectNum;
    private int greatNum;
    private int goodNum;
    private int badNum;

    public Score(int perfectNum, int greatNum, int goodNum, int badNum)
    {
        this.PerfectNum = perfectNum;
        this.GreatNum = greatNum;
        this.GoodNum = goodNum;
        this.BadNum = badNum;
    }

    public int PerfectNum { get => perfectNum; set => perfectNum = value; }
    public int GoodNum { get => goodNum; set => goodNum = value; }
    public int GreatNum { get => greatNum; set => greatNum = value; }
    public int BadNum { get => badNum; set => badNum = value; }

    override public string ToString()
    {
        return PerfectNum+"|"+GoodNum+"|"+GreatNum+"|"+BadNum;
    }
}
