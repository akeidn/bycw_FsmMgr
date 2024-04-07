using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NodeLogin : IFsmNode
{
    void IFsmNode.OnEnter()
    {
        //throw new System.NotImplementedException();
        SceneManager.LoadScene("Login");
    }

    void IFsmNode.OnExit()
    {
        Debug.Log("OnExit");
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
        //Debug.Log("Update");
    }
}
