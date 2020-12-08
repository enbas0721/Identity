using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public TextMesh textMesh;
    GameObject ruleObj;
    RuleManager ruleScript;
    public int minute;
    public float seconds;
    public float oldSeconds;
    Text timerText;

    void Start()
    {
        ruleObj = GameObject.Find("Rule"); 
        ruleScript = ruleObj.GetComponent<RuleManager>();
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ruleScript.remaining_tanuki == 0)
        {
            textMesh.text = "Finish\n経過時間："
                + minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        } else
        {
            seconds += Time.deltaTime;
            if (seconds >= 60f)
            {
                minute++;
                seconds = seconds - 60;
            }
            if ((int)seconds != (int)oldSeconds)
            {
                textMesh.text = "残りの狸は" + ruleScript.remaining_tanuki.ToString() + "匹\n経過時間："
                + minute.ToString("00") + ":" + ((int)seconds).ToString("00");
                oldSeconds = seconds;
            }
        }
    }
}
