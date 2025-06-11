using System;
using UnityEngine;

// Cube를 CylinderA에서 CylinderB로 이동시킨다
// 속성 : 물체의 속도, 시작점, 목적지
public class MovementEX : MonoBehaviour
{
    [SerializeField] private float speed;
    //public float Speed { get; set; }
    public GameObject cylinderA; // Cylinder는 게임 오브젝트 속성으로 get, set 사용 X
    public GameObject cylinderB;
    public bool isCylinderA = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (!isCylinderA)
        MoveAtoB(transform.gameObject, cylinderB);
        else
            MoveAtoB(transform.gameObject, cylinderA);
    }

    private void MoveAtoB(GameObject start, GameObject end)
    {
        // A에서 B를 향하는 벡터 -> 단위벡터(크기가 1인 벡터) -> Player에게 단위벡터를 더해준다
        Vector3 direction = end.transform.position - start.transform.position;
        Vector3 normalizedDir = direction.normalized; // 단위벡터(크기가 1인 벡터)

        // 어디까지 갈 것인가 ? cylinder B까지의 거리
        float distance = Vector3.Magnitude(direction); // magnitude : 
        print(distance);

        if (distance < 0.1f)
        {
            isCylinderA = !isCylinderA; // false -> true, true -> false
            return;
        }

        transform.position += normalizedDir * speed * Time.deltaTime;
    }
}
