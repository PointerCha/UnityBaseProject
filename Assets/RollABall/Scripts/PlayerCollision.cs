using UnityEngine;

//Home / end
// Ctrl + Shift
// Ctrl + 방향키

namespace RollABall
{
    public class PlayerCollision : MonoBehaviour
    {
        [SerializeField]
        private GameManager gameManager;


        //충돌에 비교할 태그 문자열 값.
        private string ItemTag = "Item";

        //충돌이 시작할 때(이벤트가 발생했을 때) Unity가 실행해주는 메소드.

        //other이라는 콜라이더와 충돌을 했다는 것을 알려준다.
        private void OnTriggerEnter(Collider other)
        {
            //충돌한 대상의 이름을 출력.
            //string? 값 ? / 참조 ?
            //string-> char[]
            //Debug.Log($"충돌한 대상 : {other.name}");

            //부딪친 물체의 이름이 아이템인지 확인.
            //if(other.name.Equals("Item") == true)

            //태크가 아이템이라면이라는 조건을 성립.
            //if (other.tag.Equals("Item"))
            //위의 것과 같으나 아래 코드가 성능이 좀 더 좋음.
            if(other.CompareTag("Item"))
            {
                //other.gameObject는 other 컴포넌트가 속한 게임 오브젝트 값을 가져올 때 사용.
                Destroy(other.gameObject);

                //게임 관리자에 점수 획득을 알림
                //아이템 스크립트를 사용해야 할 경우를 생각하여 아래 코드는 잠시 제외.
                //gameManager.AddScore();
            }
        }

        //충돌 중일 때 실행해주는 메소드

        //private void OnTriggerStay(Collider other)
        //{
        //    Debug.Log($"OnTriggerStay 충돌한 대상 : {other.name}");
        //}
        ////충돌이 끝날 때 실행해주는 메소드.
        //private void OnTriggerExit(Collider other)
        //{
        //    Debug.Log($"OnTriggerExit 충돌한 대상 : {other.name}");
        //}
    }
}


