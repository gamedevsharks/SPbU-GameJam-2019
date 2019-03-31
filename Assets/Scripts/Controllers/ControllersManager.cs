using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllersManager : MonoBehaviour
{
    public void SetController<T>() where T : BaseController
    {
        BaseController[] controllers = GetComponents<BaseController>();
        for (int i = 0; i < controllers.Length; ++i)
        {
            controllers[i].enabled = false;
        }

        GetComponent<T>().enabled = true;
    }
}
