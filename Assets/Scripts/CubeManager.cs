<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

// Cube 1, 2, 3, 4, 5�� ������� 1�� �������� ����Ͽ�
// CylinderA -> B -> C -> D ������ �̵�
// �Ӽ� : ť���� �ӵ�, Ÿ�ٵ�
=======
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

// Cube1, 2, 3, 4, 5�� ������� 1�� �������� ����Ͽ�
// CylinderA -> B -> C -> D ������ �̵��Ѵ�.
// �Ӽ�: Cube�� �ӵ�, Ÿ�ٵ�
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
    // �ڷ�ƾ �޼��� : ���μ��� ������ ��� ��ٸ� �� �ִ� ���
    IEnumerator CoStart() 
    {
        print("����!"); // �ݺ��� ����, Cube ����
=======
    // �ڷ�ƾ �޼���: ���μ��� ������ ��� ��ٸ� �� �ִ� ���
    IEnumerator CoStart()
    {
        print("cube ����"); // �ݺ��� ��� Cube ����
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
        yield return MoveCubeToTargets(cube, targets);

        yield return new WaitForSeconds(1);

<<<<<<< HEAD
        print("1�� ����"); // Cube1 ����
=======
        print("cube2 ����"); // Cube1 ����
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
        yield return MoveCubeToTargets(cube1, targets);

        yield return new WaitForSeconds(1);

<<<<<<< HEAD
        print("�� 1�� ����"); // Cube2 ����
=======
        print("cube3 ����"); // Cube2 ����
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
        yield return MoveCubeToTargets(cube2, targets);

        yield return new WaitForSeconds(1);

<<<<<<< HEAD
        print("�� 1�� ����"); // Cube3 ����
=======
        print("cube4 ����"); // Cube3 ����
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
        yield return MoveCubeToTargets(cube3, targets);

        yield return new WaitForSeconds(1);

<<<<<<< HEAD
        print("�� 1�� ����"); // Cube4 ����
        yield return MoveCubeToTargets(cube4, targets);
=======
        print("cube5 ����"); // Cube4 ����
        yield return MoveCubeToTargets(cube4, targets);

>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
    }

    IEnumerator MoveCubeToTargets(GameObject cube, List<GameObject> targets)
    {
<<<<<<< HEAD
        int index  = 0;
        print(cube.gameObject.name + "���!");
        while (true)
        {
            // A���� B�� ���ϴ� ���� -> ��������(ũ�Ⱑ 1�� ����) -> Player���� �������͸� �����ش�
            Vector3 direction = targets[index].transform.position - cube.transform.position;
            Vector3 normalizedDir = direction.normalized; // ��������(ũ�Ⱑ 1�� ����)

            // ������ �� ���ΰ� ? cylinder B������ �Ÿ�
            float distance = Vector3.Magnitude(direction); // magnitude : 
                                                           //print(distance);
=======
        int index = 0;

        print(cube.gameObject.name + "���!");

        while(true)
        {
            // 1. A���� B�� ���ϴ� ���� -> ��������(ũ�Ⱑ 1�� ����) -> �÷��̾�� �������͸� ������
            Vector3 direction = targets[index].transform.position - cube.transform.position;
            // 2. ��������(ũ�Ⱑ 1�� ����)
            Vector3 normalizedDir = direction.normalized;

            // 3. �Ÿ����
            float distance = Vector3.Magnitude(direction);
            // ������ �� ���ΰ�? cylinderB ���� -> �Ÿ�
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
            // 4. �÷��̾�� �������͸� ������
            cube.transform.position += normalizedDir * speed * Time.deltaTime;

            yield return null;
=======

                if (index == targets.Count)
                {
                    break;
                }
                // CylA -> CylB -> CylC -> Cyl4
            }

            // 4. �÷��̾�� �������͸� ������
            cube.transform.position += normalizedDir * speed * Time.deltaTime;

            yield return new WaitForEndOfFrame();
>>>>>>> 164c70c5c0df57e743896c2bd96e2781490c59dc
        }

        yield return null;
    }
}
