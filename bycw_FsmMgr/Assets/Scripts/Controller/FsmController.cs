using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FsmController : MonoBehaviour
{
    private FsmMachine stateMachine = new FsmMachine();

    public static FsmController Instance = null;//����

    //����
    public void Run(string name)
    {
        stateMachine.RunNode(name);
    }
    
    public void Init()
    {
        GameObject spwan = gameObject;//��������
        DontDestroyOnLoad(spwan);

        FsmController.Instance = this;//����

        //����״̬���ڵ�
        //����ͨ������ɨ�裬���԰����нڵ�ɨ�������ֱ��forѭ��ʵ��ʵ����
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
