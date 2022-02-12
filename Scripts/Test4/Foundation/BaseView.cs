using System;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseView : MonoBehaviour
{
    [SerializeField] private Text tips;
    protected ItemData itemData;
    protected abstract void Init(ItemData itemData);

    protected virtual void Satrt()
    {
        InitUI();
    }

    protected virtual void InitUI()
    {
        tips.text = itemData.levelInfo.tips;
    }

    public virtual void Show()
    {
        gameObject.SetActiveVirtual(true);
    }

    public virtual void Show(Action action)
    {
        action?.Invoke();
        Show();
    }

    public virtual void Close()
    { 
        gameObject.SetActiveVirtual(false);
    }

    public virtual void Close(Action action)
    {
        action?.Invoke();
        Close();
    }
}