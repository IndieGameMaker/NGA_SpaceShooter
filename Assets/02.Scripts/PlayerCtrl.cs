using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // 가장 먼저 호출되는 함수, 1번 호출, 다른 스크립트의 Start함수보다 먼저 호출
    // 게임내 사용하는 데이터의 초기화 또는 초기데이터를 로드
    void Awake()
    {

    }

    // 해당 스크립트가 활성화 될때마다 호출
    void OnEnable()
    {

    }

    // 1번 호출되는 함수 (자동 호출)
    void Start()
    {
        
    }

    // 화면을 렌더링하는 주기 (60fps)
    // 최적화 
    // 60fps , 1/60 sec, 불규칙하다.
    void Update()
    {
        
    }

    // 호출간격이 규칙적 (0.02 sec)
    // 물리엔진의 계산주기
    void FixedUpdate()
    {

    }

    // Update 함수가 실행 후 한번씩 호출
    // Update 함수내에서 계산된 결괏값을 기반으로 후처리 작업(계산)
    void LateUpdate()
    {

    }

    // 충돌발생시 1번 호출 - 콜백함수(Callback function, Event Function)
    void OnCollisionEnter(Collision coll)
    {

    }

    // n번 호출
    void OnCollisionStay(Collision coll)
    {

    }

    //1번
    void OnCollisionExit(Collision coll)
    {

    }

}
