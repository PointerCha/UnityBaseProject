using UnityEngine;

namespace CustomMesh
{
    [ExecuteInEditMode]

    public class CustomMesh : MonoBehaviour
    {
        // MeshFilter 컴포넌트.
        // Mesh 데이터를 관리함.
        [SerializeField]
        private MeshFilter meshFilter;

        // MeshRenderer 컴포넌트.
        // Material을 사용해 Mesh를 그리고 칠함.
        [SerializeField]
        private MeshRenderer meshRenderer;

        private void Awake()
        {
            // 일단 있는지 검색 후 설정.
            meshFilter = GetComponent<MeshFilter>();
            if (meshFilter == null)
            {
                // 검색했는데 없으면, 추가.
                meshFilter = gameObject.AddComponent<MeshFilter>();
            }

            meshRenderer = GetComponent<MeshRenderer>();
            if (meshRenderer == null)
            {
                meshRenderer = gameObject.AddComponent<MeshRenderer>();
            }

            // 메시 생성.
            Mesh mesh = new Mesh();

            // 정점 위치 배열 생성.
            Vector3[] vertices = new Vector3[]
            {
                // 첫번째 정점 위치.
                new Vector3(-0.5f, 0.5f, 0f),
                // 두번째 정점 위치.
                new Vector3(0.5f, 0.5f, 0f),
                // 세번째 정점 위치
                new Vector3(-0.5f, -0.5f, 0f),
                // 네번째 정점 위치
                new Vector3(0.5f, -0.5f, 0f),
            };

            // 메시에 정점 설정.
            mesh.SetVertices(vertices);

            // 인덱스.
            int[] indices = new int[]
            {
                0, 1, 2, 2, 1, 3
            };

            // 메시에 인덱스 설정.
            // 인덱스 배열, 만들 면의 모양, 서브 메시 인덱스.
            mesh.SetIndices(indices, MeshTopology.Triangles, 0);

            //노멀 (법선) 추가.
            Vector3[] normals = new Vector3[]
            {
                new Vector3(0f, 0f, -1f),
                new Vector3(0f, 0f, -1f),
                new Vector3(0f, 0f, -1f),
                new Vector3(0f, 0f, -1f),
            };

            //메시에 노멀 설정.
            mesh.SetNormals(normals);

            //uv 생성.
            Vector2[] uvs = new Vector2[]
            {
                new Vector2(0f, 1f),
                new Vector2(1f, 1f),
                new Vector2(0f, 0f),
                new Vector2(1f, 0f),
            };

            mesh.SetUVs(0, uvs);

            meshFilter.mesh = mesh;
        }
    }
}