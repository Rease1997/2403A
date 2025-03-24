using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    public Transform cube;
    //Vector3[] paths;
    // Start is called before the first frame update
    void Start()
    {
        //paths = null;
        //Transform pathsParent = GameObject.Find("Paths").transform;
        //paths = new Vector3[pathsParent.childCount];
        //for (int i = 0; i < pathsParent.childCount; i++)
        //{
        //    paths[i] = pathsParent.GetChild(i).position;
        //}
        DoMoveFunc();
    }

    public void DoMoveFunc()
    {
        //transform.DOPath(paths, 30f);
        //transform.DOMove(Vector3.zero, 3f);
    }

    public void Update()
    {
        //��˼���ǰ��
        //dot��������������������(transform.forward, cube.position.normalized)
        //�õ���˽�����㷴����ֵ(Mathf.Acos)
        //�ٳ��Ի��ȵ���(Mathf.Rad2Deg)
        float angle = Mathf.Acos(Vector3.Dot(transform.forward, cube.position.normalized)) * Mathf.Rad2Deg;

        Debug.Log(angle);
    }
}
