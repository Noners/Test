using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    void Start()
    {
        ArrayCut arrayCut = new ArrayCut(5,10);
        Debug.Log(arrayCut.ToString());
        arrayCut.Cut(arrayCut.DefauleArray,2,2,2,2,3,3);
        Debug.Log(arrayCut.ToString());
    }
}
class ArrayCut
{
    public int[,] DefauleArray { get; private set; }
    private int row;
    private int column;
    public ArrayCut(int row,int column)
    {
        DefauleArray = CreateArray(row,column);
        this.row = row;
        this.column = column;
    }

    private int[,] CreateArray(int row, int column)
    {
        int[,] returnArray = new int[row, column];
        int value = 1;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                // returnArray[i, j] = Random.Range(0, 10);
                returnArray[i, j] = value++;
            }
        }

        return returnArray;
    }

    public void Cut(int[,] array, int beginRow, int rowCount, int beginColumn, int columnCount, int targetBeginRow, int targetBeginColumn)
    {
        List<int> temList = new List<int>();
        for (int i = beginRow; i < beginRow + rowCount; i++)
        {
            for (int j = beginColumn; j < beginColumn + columnCount; j++)
            {
                temList.Add(array[i, j]);
                array[i, j] = default;
            }
        }

        int listIndex = 0;
        for (int i = targetBeginRow; i < targetBeginRow + rowCount && i < row; i++)
        {
            for (int j = targetBeginColumn; j < targetBeginColumn + columnCount && j < column; j++)
            {
                if (listIndex < temList.Count)
                {
                    array[i, j] = temList[listIndex];
                    listIndex++;
                }
            }
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                stringBuilder.Append(DefauleArray[i, j] + ",");
                if (j.Equals(column - 1))
                {
                    stringBuilder.AppendLine();
                }
            }
        }

        return stringBuilder.ToString();
    }
}