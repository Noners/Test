using UnityEngine;
using UnityEngine.UI;

public class EasyView : BaseView
{
    [SerializeField] Button nextBtn;
    public static void ShowView()
    {
        ViewUtil.ShowView(nameof(EasyView));   
    }

    protected override void Satrt()
    {
        ItemData itemData = DataManager.Instance.itemDatas.Find(
            (data) => { return data.modeType.Equals(ModeType.Easy); });
        Init(itemData);//新手教程数据

        base.Satrt();
    }

    protected override void Init(ItemData itemData)
    {
        this.itemData = itemData;
    }

    protected override void InitUI()
    {
        base.InitUI();
        //....
    }

    public void OnNextClick()
    {
        Close();
        //...下一个指导教程
    }
}