using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NodeTown : IFsmNode
{
    void IFsmNode.OnEnter()
    {
        //throw new System.NotImplementedException();
        SceneManager.LoadScene("Town");
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
