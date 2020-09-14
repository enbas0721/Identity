using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleManager : MonoBehaviour
{
    public int remaining_tanuki=1;

    void Start()
    {
    }

    void Update()
    {
        if (remaining_tanuki == 0)
        {
            Debug.Log("finish");
        }
    }
}
