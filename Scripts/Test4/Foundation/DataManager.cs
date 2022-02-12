using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager :SingletonClass<DataManager>
{
    public List<ItemData> itemDatas { get; private set; }
    public DataManager()
    {
        itemDatas = new List<ItemData>();
        LodeData();
    }

    private void LodeData()
    {
        string path = "";
        string data = Resources.Load<TextAsset>(path).text;
        //Json to itemData
        //itemDatas =
    }
}