using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BgmManager : MonoBehaviour
{
    AudioSource audioSource;
    GameObject Rule; 
    RuleManager script;
    int tanuki;
    public AudioClip sound1;
    public AudioSource clear;
    float seconds;
    bool ok = true;

    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();

        Rule = GameObject.Find("Rule"); 
        script = Rule.GetComponent<RuleManager>();
        //tanuki = script.remaining_tanuki;

        seconds = 0f;
    }
    void Update()
    {
        if(script.remaining_tanuki == 0)
        {
            seconds += Time.deltaTime;
            if (3 < seconds)
            {
                if (ok)
                {
                    audioSource.Stop();
                    clear.PlayOneShot(sound1);
                    ok = false;
                }
            }

            if (8 < seconds)
            {
                SceneManager.LoadScene("Start");

            }


        }
    }
}
