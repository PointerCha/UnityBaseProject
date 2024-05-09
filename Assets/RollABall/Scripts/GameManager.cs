using UnityEngine;

namespace RollABall
{
    public class GameManager : MonoBehaviour
    {
        //점수
        [SerializeField]
        private int score = 0;

        //목표 점수
        //씬에 배치된 Item의 개수
        [SerializeField]
        private int targetScore = 0;

        //점수를 보여줄 TextUI
        [SerializeField]
        private TMPro.TextMeshProUGUI scoreText;

        //게임 승리시
        [SerializeField]
        private GameObject ClearText;

        //스크립트를 시작할 때 한 번 실행(호출)되는 메소드.
        // Start // Awake -> 초기화.
        // Awake가 초기화 메소드가 좀 더 확실함.
        public void Awake()
        {
            //검색 -> 아이템이 몇 개인지?
            //게임 오브젝트를 검색하는데 태그를 조건으로 할 수 있나?
            //만일 위의 상황이 아니라면 [1] 일단 모든 게임오브젝트를 다 가져온다.
            //[2]루프를 돌리면서 하나씩 태그를 검사해서 확인한다.

            //var items => var은 배열을 뜻함. VS가 알고 있음.
            //지금은 아이템을 사용하는 것이 아니기에 int형 변수인 targetScore에 배열의 길이, 아이템의 갯수를 저장해준다.
            targetScore = GameObject.FindGameObjectsWithTag("Item").Length;

        }

        // 점수 획득 메소드
        public void AddScore()
        {
            //1점 획득 처리
            score++;

            //점수를 화면에 보여주기.
            scoreText.text = $"Score : {score}";

            //게임 클리어 확인.
            if(IsGameClear())
            {
                Debug.Log("Game Clear!");
                ClearText.SetActive(true);
            }
        }
        
        //게임 클리어 확인.
        private bool IsGameClear()
        {
            //게임 클리어 조건.
            return score == targetScore;
        }
    }
}
