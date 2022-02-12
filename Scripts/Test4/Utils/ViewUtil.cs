using System;
using UnityEngine;

public static class ViewUtil
{
    public static void ShowView(string viewName,Action action = null)
    {
        BaseView baseView = LodeView(viewName);
        baseView = UnityEngine.Object.Instantiate(baseView);
        baseView.Show(action);
    }

    public static BaseView LodeView(string name)
    {
        string path = $"Prefabs/Views/{name}";
        BaseView baseView = Resources.Load<BaseView>(path); ;
        return baseView;
    }
}
