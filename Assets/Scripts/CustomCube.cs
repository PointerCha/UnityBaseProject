using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCube : MonoBehaviour
{
    // Start is called before the first frame update
    //변수 설정 / public으로 하는 것보단 private로 하는 편이 좋음
    //public -> 외부공개 + 인스펙터에 노출.
    //public 보다는 private로 많이 진행함.
    [SerializeField] //-> 다른 변수는 접금은 못하나 인스펙터에 노출 가능.
    private Transform refTransform;

    //x축의 이동 속도
    [SerializeField]
    private float moveSpeed = 0.01f;
    void Start()
    {
        Debug.Log("Start");
        //컴포넌트 검색
        //refTransform = GetComponent<Transform>(); //1순위
        refTransform = transform; //2순위

        //x,y,z로 설정한 값만큼 이동
        refTransform.Translate(1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //입력처리(방향키)
        //좌우 방향키 입력 (A키, D키 / 왼쪽, 오른쪽 방향키)
        //-1, 1, 0 중 하나를 받음.
        float horizontal = Input.GetAxis("Horizontal");

        //상하 방향키 입력(w키, s키 / 위쪽, 아래쪽)
        float vertical = Input.GetAxis("Vertical");

        // 입력은 방향 -> 오른쪽 입력 -> 오른쪽으로 이동.
        // 입력은 방향 -> 왼쪽 입력 -> 왼쪽으로 이동.

        //Debug.Log(horizontal);

        //등속도 운동.
        // s = 속도(빠르기);
  
        //프레임마다 이동
        refTransform.Translate(moveSpeed * horizontal * Time.deltaTime, moveSpeed * vertical * Time.deltaTime, 0f);
    }
}
