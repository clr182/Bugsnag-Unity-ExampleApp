using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BugsnagUnity;

public class triggers : MonoBehaviour
{
    public static void triggerHandled(){
        Bugsnag.Notify(new System.Exception("Non-fatal"));
    }

}
