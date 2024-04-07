using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeInit : IFsmNode
{
    void IFsmNode.OnEnter()
    {
        //throw new System.NotImplementedException();
        FsmController.Instance.Run("Login");
    }

    void IFsmNode.OnExit()
    {
        //throw new System.NotImplementedException();
    }

    void IFsmNode.OnFixedUpdate()
    {
        //throw new System.NotImplementedException();
    }

    void IFsmNode.OnHandleMessage()
    {
        //throw new System.NotImplementedException();
    }

    void IFsmNode.OnUpdate()
    {
        //throw new System.NotImplementedException();
    }
}
