using UnityEngine;

//Home / end
// Ctrl + Shift
// Ctrl + ����Ű

namespace RollABall
{
    public class PlayerCollision : MonoBehaviour
    {
        [SerializeField]
        private GameManager gameManager;


        //�浹�� ���� �±� ���ڿ� ��.
        private string ItemTag = "Item";

        //�浹�� ������ ��(�̺�Ʈ�� �߻����� ��) Unity�� �������ִ� �޼ҵ�.

        //other�̶�� �ݶ��̴��� �浹�� �ߴٴ� ���� �˷��ش�.
        private void OnTriggerEnter(Collider other)
        {
            //�浹�� ����� �̸��� ���.
            //string? �� ? / ���� ?
            //string-> char[]
            //Debug.Log($"�浹�� ��� : {other.name}");

            //�ε�ģ ��ü�� �̸��� ���������� Ȯ��.
            //if(other.name.Equals("Item") == true)

            //��ũ�� �������̶���̶�� ������ ����.
            //if (other.tag.Equals("Item"))
            //���� �Ͱ� ������ �Ʒ� �ڵ尡 ������ �� �� ����.
            if(other.CompareTag("Item"))
            {
                //other.gameObject�� other ������Ʈ�� ���� ���� ������Ʈ ���� ������ �� ���.
                Destroy(other.gameObject);

                //���� �����ڿ� ���� ȹ���� �˸�
                //������ ��ũ��Ʈ�� ����ؾ� �� ��츦 �����Ͽ� �Ʒ� �ڵ�� ��� ����.
                //gameManager.AddScore();
            }
        }

        //�浹 ���� �� �������ִ� �޼ҵ�

        //private void OnTriggerStay(Collider other)
        //{
        //    Debug.Log($"OnTriggerStay �浹�� ��� : {other.name}");
        //}
        ////�浹�� ���� �� �������ִ� �޼ҵ�.
        //private void OnTriggerExit(Collider other)
        //{
        //    Debug.Log($"OnTriggerExit �浹�� ��� : {other.name}");
        //}
    }
}


