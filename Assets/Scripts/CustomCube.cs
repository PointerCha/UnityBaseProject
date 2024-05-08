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
    [SerializeField]
    private float rotationSpeed = 360f;
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
        //refTransform.Translate(moveSpeed * horizontal * Time.deltaTime, moveSpeed * vertical * Time.deltaTime, 0f);

        //이동 z축 -> 물체 기준 앞뒤 이동.
        //refTransform.position = refTransform.position+ new Vector3(0f, 0f, vertical * moveSpeed * Time.deltaTime);
        //위에 코드로 실행 시 방향만 바꾸지 이동은 제대로 하지 않는다.
        //고정 값을 이용해 앞 방향이 어디인지 알려준다. 
        //forward = 물체 기준 앞 방향을 알려준다.
        //회전 하지 않았을 때의 forward는 0, 0, 1
        //위치에 방향을 더한 상황
        //방향을 1이라 생각하고 vertical 즉 크기를 곱하여 크기를 늘린 것.
        //그곳에 -1, 1을 곱한 상황에 따라 뒤집어져서 즉 오른쪽과 왼쪽을 제어할 수 있도록 된다.
        //게임 상에서는 forward, 즉 vector를 무조건 1로 한다.
        refTransform.position = refTransform.position 
            + refTransform.forward * vertical * moveSpeed * Time.deltaTime;

        //회전
        refTransform.rotation = refTransform.rotation
            * Quaternion.Euler(0f, horizontal * rotationSpeed * Time.deltaTime, 0f);

        //회전 축 -> 현재의 Rotate 값에 돌린 양의 값을 더한다.
        refTransform.Rotate(new Vector3(0f, horizontal * rotationSpeed * Time.deltaTime, 0f));
    }
}
