using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTest : MonoBehaviour
{
    Tween tween;

    void Start()
    {
        // 3秒かけて(10,0,0)へ移動する
        //this.transform.DOMove(new Vector3(10f, 0f, 0f), 3f);

        //(10,0,0)へ1秒で移動するのを3回繰り返す
        //this.transform.DOMove(new Vector3(10f, 0f, 0f), 1f).SetLoops(6, LoopType.Yoyo);

        //3秒待ってから(10,0,0)へ1秒で移動する
        //this.transform.DOMove(new Vector3(10f, 0f, 0f), 1f).SetDelay(3f);

        //(10,0,0)へ1秒でリニア移動する
        //this.transform.DOMove(new Vector3(10f, 0f, 0f), 1f).SetEase(Ease.Linear);

        //this.transform.DOMove(new Vector3(10f, 0f, 0f), 3f).SetEase(Ease.InOutQuart);

        /*this.transform.DOMove(new Vector3(10f, 0f, 0f), 3f).SetEase(Ease.InOutBounce)
                                                           .SetLoops(3,LoopType.Restart);*/

        //2秒待ってから(5,0,0)へ3秒で移動するのを4回(2往復) OutBounceで行う
        //this.transform.DOMove(new Vector3(5f, 0f, 0f), 3f).SetDelay(2f).SetLoops(4, LoopType.Yoyo).SetEase(Ease.OutBounce);

        //this.tween = this.transform.DOMove(new Vector3(5f, 0f, 0f), 2f).SetLoops(-1, LoopType.Yoyo);

        //ローカル座標の(5,0,0)へ3秒で移動する
        //this.transform.DOLocalMove(new Vector3(5f, 0f, 0f), 3f);

        //現在の座標からX+5の座標へ3秒で移動する
        //this.transform.DOMoveX(5f, 3f);

        //現在の座標からY+5の座標へ3秒で移動する
        //this.transform.DOMoveY(5f, 3f);

        //現在の座標からZ+5の座標へ3秒で移動する
        //this.transform.DOMoveZ(5f, 3f);

        //(5,0,0)の位置に4秒で2回ジャンプして移動する
        this.transform.DOJump(new Vector3(5f, 0f, 0f), jumpPower: 3f, numJumps: 2, duration: 4f); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //返り値を保存しておいて止める方法
            this.tween.Kill();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //参照元を指定して止める方法
            this.transform.DOKill();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //Objectを指定して止める方法
            DOTween.Kill(this.transform);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            //全ての実行を止める方法
            DOTween.KillAll();
        }
    }
}
