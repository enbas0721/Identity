using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarSetting : MonoBehaviour
{
    public GameObject myLocationObj;
    public Transform handAnchorR = null;
    public Transform handAnchorL = null;
    public float heightofAvater = 0.7f;
    public float speed = 0.07f;
    public Text debugUI;

    public MusicPlaySystem musicPlaySystem;

    private Transform me;
    private Vector3 dist;
    private Vector3 distR;
    private Vector3 distL;
    private Vector3 handposR;
    private Vector3 handposL;
    private Vector3 footposR;
    private Vector3 footposL;
    private Vector3 Avaterpos;
    private Vector3 Avaterpos2;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        me = myLocationObj.transform;
        Avaterpos2 = this.transform.position;
        dist = Avaterpos2 - me.position;
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
        footposR = new Vector3(handposR.x, 0, handposR.z);
        footposL = new Vector3(handposL.x, 0, handposL.z);

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

        //右足首のゴール地点設定
        animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1);
        animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, 1);
        animator.SetIKPosition(AvatarIKGoal.RightFoot, footposR);
        animator.SetIKRotation(AvatarIKGoal.RightFoot, Quaternion.identity);

        //左足首のゴール地点設定
        animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1);
        animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 1);
        animator.SetIKPosition(AvatarIKGoal.LeftFoot, footposL);
        animator.SetIKRotation(AvatarIKGoal.LeftFoot, Quaternion.identity);

    }

    void Update()
    {
        //アバターの進行

        if (musicPlaySystem.handsup)
        {
            this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }

    }
}

