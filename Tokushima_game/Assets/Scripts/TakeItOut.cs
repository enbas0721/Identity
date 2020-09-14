using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TakeItOut : MonoBehaviour
{
    [SerializeField]
    private float changeDis=0;

    [SerializeField]
    private GameObject changedObj;

    [SerializeField]
    private ParticleSystem particle;

    [SerializeField]
    private AudioSource changeSound;

    private bool iscalledonce = false;

    private float colliderOffset;
    /*
    // Start is called before the first frame update
    private void Start()
    {
        //colliderOffset = GetComponent<CapsuleCollider>().radius + targetObj.GetComponent<CapsuleCollider>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.GetComponent<OVRGrabbable>().isGrabbed)
        {
            changedObj.SetActive(true);
            if (!iscalledonce)
            {
                iscalledonce = true;
                particle.Play();
                changeSound.Play();
                int score = GameObject.Find("Rule").GetComponent<RuleManager>().score;
                score += 1;
                GameObject.Find("Rule")
                    .GetComponent<RuleManager>().score = score;
                Debug.Log(score);
            }
        }
    }
    */
}
