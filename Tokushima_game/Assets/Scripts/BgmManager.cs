using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmManager : MonoBehaviour
{
    AudioSource audioSource;
    GameObject Rule; 
    RuleManager script;
    int tanuki;

    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();

        Rule = GameObject.Find("Rule"); 
        script = Rule.GetComponent<RuleManager>();
        tanuki = script.remaining_tanuki;
    }
    void Update()
    {

        if (tanuki == 1)
        {
            audioSource.pitch = 2;
        } else if( tanuki == 0)
        {
            audioSource.Stop();
        }
    }
}
