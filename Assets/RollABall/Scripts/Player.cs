using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public class Player : MonoBehaviour
    {
        //�̵� �ӵ� ����
        [SerializeField]
        private float moveSpeed = 5f;

        //Ʈ������ ������Ʈ ���� ����
        [SerializeField]
        private Transform refTransform;

        //Start�� ����� ������ �� �� �� ȣ���ϴ� �޼ҵ� 
        private void Awake()
        {
            //Ʈ������ ���� ���� �ʱ�ȭ(����)
            refTransform = transform;   
        }

        void Update()
        {
            //�Է� �ޱ�.
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            //�̵� ����.
            //�Է� �� / �̵� �ӵ� / ������ �ð�
            //�̵� = ��ġ + ����
            //�̵� ���� �����
            //�Ʒ��� ���� ������ ��� �밢������ �̵��� �� �� ����.
            Vector3 direction = new Vector3(horizontal, 0f, vertical);
            //���� ���� ����� / ����ȭ (�밢�� ���̸� ����)
            direction.Normalize();
            refTransform.position = refTransform.position
                + direction * moveSpeed * Time.deltaTime;


        }
    }
}


