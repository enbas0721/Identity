using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlaySystem : MonoBehaviour { 

    public AudioSource Awaodori;
    public Transform me = null;
    public Transform handAnchorL = null;
    public Transform handAnchorR = null;

    public bool handsup = false;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 mylocation = me.transform.position;
        Vector3 handposL = handAnchorR.position;
        Vector3 handposR = handAnchorL.position;

        if ((mylocation.y < handposL.y) && (mylocation.y < handposR.y))
        {
            Awaodori.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mylocation = me.transform.position;
        Vector3 handposL = handAnchorR.position;
        Vector3 handposR = handAnchorL.position;

        if((mylocation.y - 0.50 < handposL.y) && (mylocation.y - 0.50 < handposR.y))
        {
            Awaodori.UnPause();
            handsup = true;
        }
        else
        {
            Awaodori.Pause();
            handsup = false;
        }
    }
}
