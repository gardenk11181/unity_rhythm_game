using System;
public class Score
{
    private int perfectNum;
    private int greatNum;
    private int goodNum;
    private int badNum;
    private int maxCombo;

    public Score(int perfectNum, int greatNum, int goodNum, int badNum, int maxCombo)
    {
        this.PerfectNum = perfectNum;
        this.GreatNum = greatNum;
        this.GoodNum = goodNum;
        this.BadNum = badNum;
        this.MaxCombo = maxCombo;
    }

    public int PerfectNum { get => perfectNum; set => perfectNum = value; }
    public int GoodNum { get => goodNum; set => goodNum = value; }
    public int GreatNum { get => greatNum; set => greatNum = value; }
    public int BadNum { get => badNum; set => badNum = value; }
    public int MaxCombo { get => maxCombo; set => maxCombo = value; }

    override public string ToString()
    {
        return PerfectNum+"|"+GoodNum+"|"+GreatNum+"|"+BadNum;
    }
}
