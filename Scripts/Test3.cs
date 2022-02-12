using System;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    void Start()
    {
        string s = "castlejoycastlecatjoyjoycat";
        List<string> wordSet = new List<string>() { "joy", "castle", "cat" };
        string[] outStrList;

        Debug.Log(IsSentence(s, wordSet, out outStrList));

        foreach (var str in outStrList)
        {
            Debug.Log(str);
        }
    }

    private bool IsSentence(string str, List<string> strSet, out string[] sliptStrList)
    {
        string temStr = str;
        for (int i = 0; i < strSet.Count; i++)
        {
            if (str.Contains(strSet[i]))
            {
                str = str.Replace(strSet[i], "");
                temStr = temStr.Replace(strSet[i], strSet[i] + " ");
            }
        }
        char[] separator = { ' ' };
        sliptStrList = temStr.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        return str == "";
    }
}