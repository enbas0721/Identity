using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionUpdate : MonoBehaviour
{
    [SerializeField]
    private Transform target, move;

    [SerializeField]
    private float adjustHeight = 0.5f;

    private Vector3 t;

    private void Start()
    {
        t = target.position;
    }

    private void Update()
    {
        //moveの座標を常時targetで上書きするやつ
        //子オブジェクトにできないときに使う
        t = target.position;
        t.y = t.y + adjustHeight;
        move.position = t;
    }
}
