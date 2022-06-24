using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTest : MonoBehaviour
{
    Tween tween;

    void Start()
    {
        // 3�b������(10,0,0)�ֈړ�����
        //this.transform.DOMove(new Vector3(10f, 0f, 0f), 3f);

        //(10,0,0)��1�b�ňړ�����̂�3��J��Ԃ�
        //this.transform.DOMove(new Vector3(10f, 0f, 0f), 1f).SetLoops(6, LoopType.Yoyo);

        //3�b�҂��Ă���(10,0,0)��1�b�ňړ�����
        //this.transform.DOMove(new Vector3(10f, 0f, 0f), 1f).SetDelay(3f);

        //(10,0,0)��1�b�Ń��j�A�ړ�����
        //this.transform.DOMove(new Vector3(10f, 0f, 0f), 1f).SetEase(Ease.Linear);

        //this.transform.DOMove(new Vector3(10f, 0f, 0f), 3f).SetEase(Ease.InOutQuart);

        /*this.transform.DOMove(new Vector3(10f, 0f, 0f), 3f).SetEase(Ease.InOutBounce)
                                                           .SetLoops(3,LoopType.Restart);*/

        //2�b�҂��Ă���(5,0,0)��3�b�ňړ�����̂�4��(2����) OutBounce�ōs��
        //this.transform.DOMove(new Vector3(5f, 0f, 0f), 3f).SetDelay(2f).SetLoops(4, LoopType.Yoyo).SetEase(Ease.OutBounce);

        //this.tween = this.transform.DOMove(new Vector3(5f, 0f, 0f), 2f).SetLoops(-1, LoopType.Yoyo);

        //���[�J�����W��(5,0,0)��3�b�ňړ�����
        //this.transform.DOLocalMove(new Vector3(5f, 0f, 0f), 3f);

        //���݂̍��W����X+5�̍��W��3�b�ňړ�����
        //this.transform.DOMoveX(5f, 3f);

        //���݂̍��W����Y+5�̍��W��3�b�ňړ�����
        //this.transform.DOMoveY(5f, 3f);

        //���݂̍��W����Z+5�̍��W��3�b�ňړ�����
        //this.transform.DOMoveZ(5f, 3f);

        //(5,0,0)�̈ʒu��4�b��2��W�����v���Ĉړ�����
        this.transform.DOJump(new Vector3(5f, 0f, 0f), jumpPower: 3f, numJumps: 2, duration: 4f); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //�Ԃ�l��ۑ����Ă����Ď~�߂���@
            this.tween.Kill();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //�Q�ƌ����w�肵�Ď~�߂���@
            this.transform.DOKill();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //Object���w�肵�Ď~�߂���@
            DOTween.Kill(this.transform);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            //�S�Ă̎��s���~�߂���@
            DOTween.KillAll();
        }
    }
}
