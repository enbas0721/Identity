using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoveSystem : MonoBehaviour
{
    public MusicPlaySystem musicPlaySystem;
    public float speed = 0.07f;
    public GameObject me = null;
    public Text debugUI;

    private Vector3 diff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (musicPlaySystem.handsup)
        {
            Vector3 mePos = me.transform.localPosition;
            this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            //me.transform.localPosition = localPos;
            if(debugUI != null)
            {
                debugUI.text = this.transform.position.ToString("0.00m");
            }
        }
        else
        {
            debugUI.text = ("No");
        }
    }
}
