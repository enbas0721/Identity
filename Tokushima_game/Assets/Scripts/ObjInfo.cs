using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInfo : MonoBehaviour
{
    public bool isTanuki=true;
    public GameObject particleObj;
    public AudioClip sound1;
    public AudioSource audioSource;

    void Start()
    {
        //ランダム配置
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        pos.x = Random.Range(-7.0f, 7.0f);    
        pos.z = Random.Range(-12.0f, 1.0f);   
        myTransform.position = pos;

        //SE
        //audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void Grabbed()
    {
        if (isTanuki)
        {
            Destroy(gameObject);
            Instantiate(particleObj, this.transform.position, Quaternion.identity);
            audioSource.PlayOneShot(sound1);
        }
    }
}
