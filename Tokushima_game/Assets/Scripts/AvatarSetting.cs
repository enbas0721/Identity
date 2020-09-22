using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarSetting : MonoBehaviour
{
    public GameObject myLocationObj;
    public Transform handAnchorR = null;
    public Transform handAnchorL = null;
    public float heightofAvater = 0.7f;

    private Transform me;
    private Vector3 dist;
    private Vector3 distR;
    private Vector3 distL;
    private Vector3 handposR;
    private Vector3 handposL;
    private Vector3 Avaterpos;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        me = myLocationObj.transform;
    }

    // Update is called once per frame
    void OnAnimatorIK()
    {
        Transform mylocation = myLocationObj.transform;
        distR = new Vector3(handAnchorR.position.x - mylocation.position.x, handAnchorR.position.y - mylocation.position.y, handAnchorR.position.z - mylocation.position.z);  
        distL = new Vector3(handAnchorL.position.x - mylocation.position.x, handAnchorL.position.y - mylocation.position.y, handAnchorL.position.z - mylocation.position.z);
        Avaterpos = this.transform.position;
        handposR = new Vector3(Avaterpos.x + distR.x, Avaterpos.y + distR.y + heightofAvater, Avaterpos.z + distR.z);
        handposL = new Vector3(Avaterpos.x + distL.x, Avaterpos.y + distL.y + heightofAvater, Avaterpos.z + distL.z);

        //右手首のゴール地点設定
        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
        animator.SetIKPosition(AvatarIKGoal.RightHand, handposR);
        animator.SetIKRotation(AvatarIKGoal.RightHand, handAnchorR.rotation);

        //左手首のゴール地点設定
        animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
        animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
        animator.SetIKPosition(AvatarIKGoal.LeftHand, handposL);
        animator.SetIKRotation(AvatarIKGoal.LeftHand, handAnchorL.rotation);
    }

    void Update()
    {

        /*Transform mylocation = myLocationObj.transform;
        dist = new Vector3(mylocation.position.x - me.position.x, mylocation.position.y - me.position.y, mylocation.position.z - me.position.z);
        me.position = mylocation.position;
        this.transform.Translate(new Vector3(me.position.x+dist.x,me.position.y,me.position.z + dist.z));*/
        Debug.Log("this is test");
    }
}

