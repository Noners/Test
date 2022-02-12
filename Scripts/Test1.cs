using DG.Tweening;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    private void Start()
    {
        GameObjectAnimation gameObjectAnimation = new GameObjectAnimation();
        gameObjectAnimation.Move(gameObject, Vector3.one, Vector3.one * 4, 2f, true, EaseType.EaseIn);
        //gameObjectAnimation.Move(gameObject, Vector3.one, Vector3.one * 4, 2f, true);
    }
}

public enum EaseType
{
    EaseIn,
    EaseOut,
    EaseInOut
}

class GameObjectAnimation
{
    public void Move(GameObject gameObject, Vector3 start, Vector3 end, float time, bool isPingPong)
    {
        gameObject.transform.position = start;
        Tweener tweener = gameObject.transform.DOMove(end, time);

        if (isPingPong)
        {
            tweener.OnComplete(() => { Move(gameObject, end, start, time, isPingPong); });
        }
    }

    public void Move(GameObject gameObject, Vector3 start, Vector3 end, float time, bool isPingPong, EaseType easeType)
    {
        gameObject.transform.position = start;
        Tweener tweener = gameObject.transform.DOMove(end, time);

        switch (easeType)
        {
            case EaseType.EaseIn:
                tweener.SetEase(Ease.InSine);
                break;
            case EaseType.EaseOut:
                tweener.SetEase(Ease.OutSine);
                break;
            case EaseType.EaseInOut:
                tweener.SetEase(Ease.InOutSine);
                break;
            default:
                break;
        }

        if (isPingPong)
        {
            tweener.OnComplete(() => { Move(gameObject, end, start, time, isPingPong, easeType); });
        }
    }
}