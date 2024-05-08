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
    private float xSpeed = 0.01f;
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
        Debug.Log("Update");

        refTransform.Translate(xSpeed, 0f, 0f);
    }
}
