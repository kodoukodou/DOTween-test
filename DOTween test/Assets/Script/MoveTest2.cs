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
        //1�b��Rotation��(0,180,0)�ɂȂ�悤�ɉ�]����
        //this.transform.DORotate(Vector3.right * 180f, 1f).SetLoops(4, LoopType.Restart);

        //1�b�ŐԐF�ɕς���
        //this.rendererComponent.material.DOColor(Color.red, 5f);

        //1�b��Image�̃A���t�@��0�ɂ���
        //this.image.DOFade(endValue: 0f, duration: 1f);

        /*Vector3[] path =
        {
            new Vector3(0f,0f,10f),
            new Vector3(5f,0f,10f),
            new Vector3(5f,0f,0f),
            //new Vector3(0f,0f,0f)
        };

        //�w�肵��Path��4�b�Œʂ�A�i�s����������
        this.transform.DOPath(path, 4f).SetLookAt(0.01f);*/

        //(5,0,0)��2�b�ňړ����A�ړ�������������Y��180�x��1�b�ŉ�]����
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

        //�w�肵��Path��4�b�Œʂ�A�i�s����������
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
        // �T�v:
        //     Fastest way that never rotates beyond 360��
        Fast = 0,
        //
        // �T�v:
        //     Fastest way that rotates beyond 360��
        FastBeyond360 = 1,
        //
        // �T�v:
        //     Adds the given rotation to the transform using world axis and an advanced precision
        //     mode (like when using transform.Rotate(Space.World)).
        //     In this mode the end value is is always considered relative
        WorldAxisAdd = 2,
        //
        // �T�v:
        //     Adds the given rotation to the transform's local axis (like when rotating an
        //     object with the "local" switch enabled in Unity's editor or using transform.Rotate(Space.Self)).
        //     In this mode the end value is is always considered relative
        LocalAxisAdd = 3
    }
}
