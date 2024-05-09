using Unity.VisualScripting;
using UnityEngine;

namespace RollABall
{
    // 아이템 스크립트
    public class Item : MonoBehaviour
    {
        [SerializeField]
        private GameManager gameManager;

        private void Awake()
        {
            // GameManager 컴포넌트를 가진 게임 오브젝트를 검색
            // FindFirst 류의 메소드는 검색을 하고 첫번째로 찾았으면 거기서 멈춤.
            gameManager = GameObject.FindFirstObjectByType<GameManager>();
        }

        // 파괴될 때 실행되는 메소드.
        private void OnDestroy()
        {
            gameManager.AddScore();    
        }
    }
}
