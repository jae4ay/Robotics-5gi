<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

// Cube 1, 2, 3, 4, 5를 순서대로 1초 간격으로 출발하여
// CylinderA -> B -> C -> D 순으로 이동
// 속성 : 큐브의 속도, 타겟들
=======
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

// Cube1, 2, 3, 4, 5를 순서대로 1초 간격으로 출발하여
// CylinderA -> B -> C -> D 순으로 이동한다.
// 속성: Cube의 속도, 타겟들
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc

public class CubeManager : MonoBehaviour
{
    public float speed;
    public GameObject cube;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public List<GameObject> targets;

<<<<<<< HEAD

=======
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CoStart());
    }

    // Update is called once per frame
    void Update()
    {
        print("update");
    }

<<<<<<< HEAD
    // 코루틴 메서드 : 프로세스 내에서 잠깐 기다릴 수 있는 기능
    IEnumerator CoStart() 
    {
        print("시작!"); // 반복문 시작, Cube 운행
=======
    // 코루틴 메서드: 프로세스 내에서 잠깐 기다릴 수 있는 기능
    IEnumerator CoStart()
    {
        print("cube 시작"); // 반복문 사용 Cube 운행
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
        yield return MoveCubeToTargets(cube, targets);

        yield return new WaitForSeconds(1);

<<<<<<< HEAD
        print("1초 지남"); // Cube1 운행
=======
        print("cube2 시작"); // Cube1 운행
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
        yield return MoveCubeToTargets(cube1, targets);

        yield return new WaitForSeconds(1);

<<<<<<< HEAD
        print("또 1초 지남"); // Cube2 운행
=======
        print("cube3 시작"); // Cube2 운행
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
        yield return MoveCubeToTargets(cube2, targets);

        yield return new WaitForSeconds(1);

<<<<<<< HEAD
        print("또 1초 지남"); // Cube3 운행
=======
        print("cube4 시작"); // Cube3 운행
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
        yield return MoveCubeToTargets(cube3, targets);

        yield return new WaitForSeconds(1);

<<<<<<< HEAD
        print("또 1초 지남"); // Cube4 운행
        yield return MoveCubeToTargets(cube4, targets);
=======
        print("cube5 시작"); // Cube4 운행
        yield return MoveCubeToTargets(cube4, targets);

>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
    }

    IEnumerator MoveCubeToTargets(GameObject cube, List<GameObject> targets)
    {
<<<<<<< HEAD
        int index  = 0;
        print(cube.gameObject.name + "출발!");
        while (true)
        {
            // A에서 B를 향하는 벡터 -> 단위벡터(크기가 1인 벡터) -> Player에게 단위벡터를 더해준다
            Vector3 direction = targets[index].transform.position - cube.transform.position;
            Vector3 normalizedDir = direction.normalized; // 단위벡터(크기가 1인 벡터)

            // 어디까지 갈 것인가 ? cylinder B까지의 거리
            float distance = Vector3.Magnitude(direction); // magnitude : 
                                                           //print(distance);
=======
        int index = 0;

        print(cube.gameObject.name + "출발!");

        while(true)
        {
            // 1. A에서 B를 향하는 벡터 -> 단위벡터(크기가 1인 벡터) -> 플레이어에게 단위벡터를 더해줌
            Vector3 direction = targets[index].transform.position - cube.transform.position;
            // 2. 단위벡터(크기가 1인 벡터)
            Vector3 normalizedDir = direction.normalized;

            // 3. 거리계산
            float distance = Vector3.Magnitude(direction);
            // 어디까지 갈 것인가? cylinderB 까지 -> 거리
            print(distance);
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc

            if (distance < 0.1f)
            {
                index++;
<<<<<<< HEAD
                if(index == targets.Count)
                {
                    break;
                }
                // Cyl1 -> Cyl2 -> Cyl3 -> Cyl4
            }
            // 4. 플레이어에게 단위벡터를 더해줌
            cube.transform.position += normalizedDir * speed * Time.deltaTime;

            yield return null;
=======

                if (index == targets.Count)
                {
                    break;
                }
                // CylA -> CylB -> CylC -> Cyl4
            }

            // 4. 플레이어에게 단위벡터를 더해줌
            cube.transform.position += normalizedDir * speed * Time.deltaTime;

            yield return new WaitForEndOfFrame();
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
        }

        yield return null;
    }
}
