using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]   //클래스 타입의 변수를 인스펙터에 노출(객체 직렬화)
public class PlayerAnim
{
    public AnimationClip idle;
    public AnimationClip runForward;
    public AnimationClip runBackward;
    public AnimationClip runLeft;
    public AnimationClip runRight;
}


public class PlayerCtrl : MonoBehaviour
{
    public float moveSpeed = 8.0f;
    public float turnSpeed = 80.0f;
    public PlayerAnim playerAnim;

    private Animation anim;

    //public float m_age = 10;

    // 1번 호출되는 함수 (자동 호출)
    void Start()
    {
        anim = this.gameObject.GetComponent<Animation>();
        anim.Play(playerAnim.idle.name);
    }

    void Update()
    {
        float v = Input.GetAxis("Vertical");//up, down, w, s  // -1.0f ~ 0.0f ~ +1.0f
        float h = Input.GetAxis("Horizontal");//Left, Right, A, D // -1.0f ~ 0.0f ~ +1.0f
        float r = Input.GetAxis("Mouse X");

        Debug.Log($"v={v}/ h={h}"); /// Debug.Log("v="+v+"/ "+"h="+h);

        //이동로직
        Vector3 dir = (Vector3.forward * v) + (Vector3.right * h);
        transform.Translate(dir.normalized * Time.deltaTime * moveSpeed);
        //회전로직
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * r);
    }

    void PlayAnimation(float v, float h)
    {
        if (v >= 0.1f)
        {
            //전진 애니메이션 클립
            anim.CrossFade(playerAnim.runForward.name, 0.25f);
        }
        else if (v <= -0.1f)
        {
            
        }
    }

    /* 정규화 벡터, 단위 벡터, Normalized Vector, Unit Vector (크기가 1인 벡터)
        Vector3.forward = Vector3(0, 0, 1)
        Vector3.up      = Vector3(0, 1, 0)
        Vector3.right   = Vector3(1, 0, 0)

        Vector3.zero    = Vector3(0, 0, 0)
        Vector3.one     = Vector3(1, 1, 1)
    */

 





}
