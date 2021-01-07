using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInfo : MonoBehaviour
{
    public bool isTanuki;
    GameObject ruleObj;
    public GameObject particleObj;
    public AudioClip sound1;
    public AudioSource audioSource;
    public GameObject tanuki;
    RuleManager ruleScript;
    Transform myTransform;
    Vector3 pos;
    float seconds;

    void Start()
    {
        //ランダム配置
        myTransform = this.transform;
        pos = myTransform.position;
        pos.x = Random.Range(-4.0f, 4.0f);    
        pos.z = Random.Range(-5.5f, -11.0f);
        //pos.x = Random.Range(1.0f, 1.0f);
        //pos.z = Random.Range(0f, 0f);
        pos.y = 0.22f;
        myTransform.position = pos;
        ruleObj = GameObject.Find("Rule");
        //SE
        //audioSource = GetComponent<AudioSource>();
        Debug.Log(myTransform.position);

    }

    // Update is called once per frame
    void Update()
    {
   
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Hand")
        {
            Vector3 tmp = gameObject.transform.position;
            Debug.Log("tmp" + tmp);
            Destroy(this.gameObject);
            Instantiate(particleObj, tmp, Quaternion.identity);
            audioSource.PlayOneShot(sound1);
            ruleScript = ruleObj.GetComponent<RuleManager>();
            ruleScript.remaining_tanuki = 0;
            Instantiate(tanuki, tmp, Quaternion.identity);
        }
    }
}
