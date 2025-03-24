using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Boot : UnitySingleton<Boot>
{
    //����
    public AudioSource audio;

    //ui�����㼶����ҪTransform 
    //����canvas canvas����camera��Ⱦ���� ͨ�����ھ�����Ʋ㼶
    //���������depthonly ���Ҹ���͸������
    public Transform BackRoot;
    public Transform UIRoot;
    public Transform TipRoot;


    void Start()
    {
        Init();
        UIManager.Instance.OpenWindow("GamePanel");
        //GameScenesManager.Instance.LoadSceneAsync("Game", "PlayerPanel", new string[] { "Girls1", "Girls2", "Girls3" });
    }

    void Init()
    {
        gameObject.AddComponent<GameScenesManager>().Init(this);
        UIManager.Instance.Init(TipRoot, UIRoot, BackRoot);
    }

    public void ChangeAudio(AudioClip clip)
    {
        audio.clip = clip;
        audio.time = 0;
        audio.Play();
    }
}
