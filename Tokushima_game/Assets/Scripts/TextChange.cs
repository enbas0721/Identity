using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    Text targetText;
    GameObject ruleObj;
    RuleManager ruleScript;
    public int minute;
    public float seconds;
    public float oldSeconds;

    void Start()
    {
        ruleObj = GameObject.Find("Rule"); 
        ruleScript = ruleObj.GetComponent<RuleManager>();
        targetText = this.GetComponent<Text>();
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
        //timerText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ruleScript.remaining_tanuki == 0)
        {
            this.targetText.text = "クリア！";
            //\n経過時間："
               // + minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        } 
    }
}
