using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class MoveTest2 : MonoBehaviour
{
    Tween tween;

    [SerializeField]
    Renderer rendererComponent;

    [SerializeField]
    //UnityEngine.UI.Image image;

    //[SerializeField]
    //UnityEngine.UI.Image image;

    // Start is called before the first frame update
    void Start()
    {
        //1ïbÇ≈RotationÇ™(0,180,0)Ç…Ç»ÇÈÇÊÇ§Ç…âÒì]Ç∑ÇÈ
        //this.transform.DORotate(Vector3.right * 180f, 1f).SetLoops(4, LoopType.Restart);

        //1ïbÇ≈ê‘êFÇ…ïœÇ¶ÇÈ
        //this.rendererComponent.material.DOColor(Color.red, 5f);

        //1ïbÇ≈ImageÇÃÉAÉãÉtÉ@Ç0Ç…Ç∑ÇÈ
        //this.image.DOFade(endValue: 0f, duration: 1f);

        /*Vector3[] path =
        {
            new Vector3(0f,0f,10f),
            new Vector3(5f,0f,10f),
            new Vector3(5f,0f,0f),
            //new Vector3(0f,0f,0f)
        };

        //éwíËÇµÇΩPathÇ4ïbÇ≈í ÇËÅAêiçsï˚å¸Çå¸Ç≠
        this.transform.DOPath(path, 4f).SetLookAt(0.01f);*/

        //(5,0,0)Ç…2ïbÇ≈à⁄ìÆÇµÅAà⁄ìÆÇ™äÆóπÇµÇΩÇÁYé≤180ìxÇ…1ïbÇ≈âÒì]Ç∑ÇÈ
        /*this.transform.DOMove(new Vector3(5f, 0f, 0f), 4f).OnComplete(() =>
        {
            this.transform.DORotate(Vector3.up * 180f, 1f);
        });*/

        Vector3[] path =
        {
            new Vector3(0f,0f,10f),
            new Vector3(5f,0f,10f),
            new Vector3(5f,0f,0f),
            //new Vector3(0f,0f,0f)
        };

        //éwíËÇµÇΩPathÇ4ïbÇ≈í ÇËÅAêiçsï˚å¸Çå¸Ç≠
        this.transform.DOPath(path, 4f).SetLookAt(0.01f).OnComplete(() =>
        {
            this.rendererComponent.material.DOColor(Color.red, 3f);
            this.transform.DORotate(Vector3.right * 180f, 1f).SetLoops(3, LoopType.Restart);
            Debug.Log("OK");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum RotateMode
    {
        //
        // äTóv:
        //     Fastest way that never rotates beyond 360Åã
        Fast = 0,
        //
        // äTóv:
        //     Fastest way that rotates beyond 360Åã
        FastBeyond360 = 1,
        //
        // äTóv:
        //     Adds the given rotation to the transform using world axis and an advanced precision
        //     mode (like when using transform.Rotate(Space.World)).
        //     In this mode the end value is is always considered relative
        WorldAxisAdd = 2,
        //
        // äTóv:
        //     Adds the given rotation to the transform's local axis (like when rotating an
        //     object with the "local" switch enabled in Unity's editor or using transform.Rotate(Space.Self)).
        //     In this mode the end value is is always considered relative
        LocalAxisAdd = 3
    }
}
