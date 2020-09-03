using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Generate : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        // プレハブを取得
        GameObject prefab = (GameObject)Resources.Load("Kuwa_tanuki");
        // プレハブからインスタンスを生成
        Instantiate(prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
