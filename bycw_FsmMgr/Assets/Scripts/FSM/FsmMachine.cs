using System.Collections;
using System.Collections.Generic;


public class FsmMachine 
{
    private IFsmNode curNode  = null;//当前节点
    //定义一个数据结构，存放节点
    private Dictionary<string, IFsmNode> statesNode = new Dictionary<string, IFsmNode>();

    //往状态机里面加入状态机节点
    public bool AddNode(string name, IFsmNode node)
    {        
        if (statesNode.ContainsKey(name))//判断名字是否存在   
            return false;         

        statesNode.Add(name, node);
        return true;
    }
    //运行节点
    public bool RunNode(string name)
    {
        if(!statesNode.ContainsKey(name))//判断名字是否存在
            return false;

        if (curNode != null)//有当前节点
            curNode.OnExit();//执行当前节点退出后的动作

        curNode = statesNode[name];//确认新节点
        curNode.OnEnter(); //执行新节点进入的动作

        return true;
    }

    public void OnUpdate()//迭代状态机节点的Update
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
