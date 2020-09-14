using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabEvent : MonoBehaviour
{
    public GameObject originObject;
    RuleManager ruleScript;

    void Start()
    {
        ruleScript = GetComponent<RuleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Grabbed()
    {

        ruleScript.remaining_tanuki = ruleScript.remaining_tanuki-1;
    }
}
