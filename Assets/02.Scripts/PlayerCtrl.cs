﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{


    // 1번 호출되는 함수 (자동 호출)
    void Start()
    {
        
    }

    // 화면을 렌더링하는 주기 (60fps)
    // 최적화 
    // 60fps , 1/60 sec, 불규칙하다.
    /*
        Vector3 a = (x, y, z)
    */
    void Update()
    {
        //transform.position += new Vector3(0, 0, 0.1f);
        transform.Translate(Vector3.forward * 0.1f);
    }

    /* 정규화 벡터, 단위 벡터, Normalized Vector, Unit Vector (크기가 1인 벡터)
        Vector3.forward = Vector3(0, 0, 1)
        Vector3.up      = Vector3(0, 1, 0)
        Vector3.right   = Vector3(1, 0, 0)

        Vector3.zero    = Vector3(0, 0, 0)
        Vector3.one     = Vector3(1, 1, 1)
    */

 





}
