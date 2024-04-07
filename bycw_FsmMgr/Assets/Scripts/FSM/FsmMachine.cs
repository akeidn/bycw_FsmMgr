using System.Collections;
using System.Collections.Generic;


public class FsmMachine 
{
    private IFsmNode curNode  = null;//��ǰ�ڵ�
    //����һ�����ݽṹ����Žڵ�
    private Dictionary<string, IFsmNode> statesNode = new Dictionary<string, IFsmNode>();

    //��״̬���������״̬���ڵ�
    public bool AddNode(string name, IFsmNode node)
    {        
        if (statesNode.ContainsKey(name))//�ж������Ƿ����   
            return false;         

        statesNode.Add(name, node);
        return true;
    }
    //���нڵ�
    public bool RunNode(string name)
    {
        if(!statesNode.ContainsKey(name))//�ж������Ƿ����
            return false;

        if (curNode != null)//�е�ǰ�ڵ�
            curNode.OnExit();//ִ�е�ǰ�ڵ��˳���Ķ���

        curNode = statesNode[name];//ȷ���½ڵ�
        curNode.OnEnter(); //ִ���½ڵ����Ķ���

        return true;
    }

    public void OnUpdate()//����״̬���ڵ��Update
    {
        if (curNode!=null)        
            curNode.OnUpdate();        
    }

    public void OnFixedUpdate()
    {
        if (curNode != null)
            curNode.OnFixedUpdate();
    }

    public void OnHandleMessage()
    {
        if (curNode != null)
            curNode.OnHandleMessage();
    }
}
