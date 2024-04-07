using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLanch : MonoBehaviour
{
    void Awake()
    {
        //框架初始化代码
        gameObject.AddComponent<FsmController>().Init();
    }

    // Start is called before the first frame update
    void Start()
    {
        //状态机管理实例化与初始化
        FsmController.Instance.Run("Init");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
