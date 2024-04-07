using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILogin : MonoBehaviour
{
    public void OnLoginClick()
    {
        FsmController.Instance.Run("Town");
    }
}
