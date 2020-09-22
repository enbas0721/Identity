using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAvaters : MonoBehaviour
{

    public GameObject me;
    public GameObject originAvater;
    public float spaceBetweenAvaters = 1.5f;
    public int numberOfAvaters = 5;
    public float heightofAvater = 0.7f;


    // Start is called before the first frame update
    void Start()
    {
        Transform myTransform = me.transform;
        Transform createTransform = myTransform;
        Vector3 pos = myTransform.position;

        for (int i = 0; i < numberOfAvaters; ++i)
        {
            for (int j = 0; j < numberOfAvaters; ++j)
            {
                if((i != (int)(numberOfAvaters/2)) || (j != (int)(numberOfAvaters / 2)))
                {
                    Instantiate(originAvater, new Vector3((pos.x + ((int)(numberOfAvaters / 2) - j)) * spaceBetweenAvaters, heightofAvater, (pos.z + ((int)(numberOfAvaters / 2) - i)) * spaceBetweenAvaters), Quaternion.identity);
                }

            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
