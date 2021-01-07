using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarwarsSystem : MonoBehaviour
{

    [SerializeField]
    private float speed;

    [SerializeField]
    private int endpoint = 230;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, speed * Time.deltaTime,0);
        if(this.transform.position.y > endpoint)
        {
            SceneManager.LoadScene(0);
        }
    }
}
