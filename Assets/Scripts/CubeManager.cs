using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

// Cube 1, 2, 3, 4, 5�� ������� 1�� �������� ����Ͽ�
// CylinderA -> B -> C -> D ������ �̵�
// �Ӽ� : ť���� �ӵ�, Ÿ�ٵ�

public class CubeManager : MonoBehaviour
{
    public float speed;
    public GameObject cube;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public List<GameObject> targets;


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

    // �ڷ�ƾ �޼��� : ���μ��� ������ ��� ��ٸ� �� �ִ� ���
    IEnumerator CoStart() 
    {
        print("����!"); // �ݺ��� ����, Cube ����
        yield return MoveCubeToTargets(cube, targets);

        yield return new WaitForSeconds(1);

        print("1�� ����"); // Cube1 ����
        yield return MoveCubeToTargets(cube1, targets);

        yield return new WaitForSeconds(1);

        print("�� 1�� ����"); // Cube2 ����
        yield return MoveCubeToTargets(cube2, targets);

        yield return new WaitForSeconds(1);

        print("�� 1�� ����"); // Cube3 ����
        yield return MoveCubeToTargets(cube3, targets);

        yield return new WaitForSeconds(1);

        print("�� 1�� ����"); // Cube4 ����
        yield return MoveCubeToTargets(cube4, targets);
    }

    IEnumerator MoveCubeToTargets(GameObject cube, List<GameObject> targets)
    {
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

            if (distance < 0.1f)
            {
                index++;
                if(index == targets.Count)
                {
                    break;
                }
                // Cyl1 -> Cyl2 -> Cyl3 -> Cyl4
            }
            // 4. �÷��̾�� �������͸� ������
            cube.transform.position += normalizedDir * speed * Time.deltaTime;

            yield return null;
        }

        yield return null;
    }
}
