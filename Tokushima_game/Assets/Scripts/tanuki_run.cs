using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanuki_run : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < 20)
        {
            this.transform.position += new Vector3(0, 0, 0.1f);

        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
