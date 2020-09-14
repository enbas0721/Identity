using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public TextMesh textMesh;
    GameObject ruleObj;
    RuleManager ruleScript;

    void Start()
    {
        ruleObj = GameObject.Find("Rule"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        ruleScript = ruleObj.GetComponent<RuleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = "残りの狸は" + ruleScript.remaining_tanuki.ToString() + "匹";
    }
}
