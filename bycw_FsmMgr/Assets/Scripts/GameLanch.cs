using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLanch : MonoBehaviour
{
    void Awake()
    {
        //��ܳ�ʼ������
        gameObject.AddComponent<FsmController>().Init();
    }

    // Start is called before the first frame update
    void Start()
    {
        //״̬������ʵ�������ʼ��
        FsmController.Instance.Run("Init");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
