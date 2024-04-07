using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FsmController : MonoBehaviour
{
    private FsmMachine stateMachine = new FsmMachine();

    public static FsmController Instance = null;//单例

    //运行
    public void Run(string name)
    {
        stateMachine.RunNode(name);
    }
    
    public void Init()
    {
        GameObject spwan = gameObject;//不可销毁
        DontDestroyOnLoad(spwan);

        FsmController.Instance = this;//单例

        //创建状态机节点
        //可以通过类型扫描，可以把所有节点扫描进来，直接for循环实现实例化
        stateMachine.AddNode("Init",new NodeInit());
        stateMachine.AddNode("Login",new NodeLogin());
        stateMachine.AddNode("Town",new NodeTown());
    }

    // Update is called once per frame
    void Update()
    {
        stateMachine.OnUpdate();
    }

    private void FixedUpdate()
    {
        stateMachine.OnFixedUpdate();
    }
}
