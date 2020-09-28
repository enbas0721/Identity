using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveSystem : MonoBehaviour
{
    public MusicPlaySystem musicPlaySystem;
    public float speed = 0.07f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (musicPlaySystem.handsup)
        {
            this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }        
    }
}
