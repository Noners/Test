public class NormalView : BaseView
{
    public static void ShowView()
    {
        ViewUtil.ShowView(nameof(NormalView));
    }

    protected override void Satrt()
    {
        Init(new ItemData());

        base.Satrt();
    }

    protected override void Init(ItemData itemData)
    {
        this.itemData = itemData;
    }
}