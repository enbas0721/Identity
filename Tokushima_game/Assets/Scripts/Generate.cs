using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Generate : MonoBehaviour
{
    public GameObject prefab;
    int objNum=3;

    public List<TanukiData> TanukiDataList = new List<TanukiData>(){
        new TanukiData( "Kuwa_tanuki", true),
        new TanukiData( "Shirotokkuri_for_unity", true),
        new TanukiData( "Cube", false)
    };

    void Start()
    {
        float x = Random.Range(-6f, 6f);
        float z = Random.Range(-12f, 1.5f);
        Vector3 pos = new Vector3(x, 1f, z); 
        //prefab = (GameObject)Resources.Load(TanukiDataList[i].path);
        var parent = this.transform;
        Instantiate(prefab, pos, Quaternion.identity,parent);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
