using System.Collections.Generic;
public class ItemData
{
    public ModeType modeType;
    public LevelInfo levelInfo;
}

public enum ModeType
{ 
    Easy,
    Normal,
    Hard
}

public class LevelInfo
{
    public Grid grid;
    public List<CellData> defauleValue;
    public List<CellData> tipValue;
    public string tips;
}

public class Grid
{
    public int row;
    public int column;
}

public class CellData
{
    public int xPos;
    public int yPos;
    public int value;
}