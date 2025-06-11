using System.Reflection;
using UnityEngine;

// Cube�� CylA -> CylB -> CylC -> CylD �� ���������� �̵� 
// �Ӽ�: ��ü�� �ӵ�, �Ǹ��� �迭
public class MovementEx2 : MonoBehaviour
{
    [SerializeField] private float speed;
    public GameObject[] targets;
    private int index;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // targets[0] -> targets[1] -> targets[2] -> targets[3] 
        MoveAtoB(transform.gameObject, targets[index]);
    }

    private void MoveAtoB(GameObject start, GameObject end)
    {
        // 1. A���� B�� ���ϴ� ���� -> ��������(ũ�Ⱑ 1�� ����) -> �÷��̾�� �������͸� ������
        Vector3 direction = end.transform.position - start.transform.position;
        // 2. ��������(ũ�Ⱑ 1�� ����)
        Vector3 normalizedDir = direction.normalized;

        // 3. �Ÿ����
        float distance = Vector3.Magnitude(direction);
        // ������ �� ���ΰ�? cylinderB ���� -> �Ÿ�
        // print(distance);

        if (distance < 0.1f)
        {
            index++;

            if (index == targets.Length)
            {
                index = 0;
                return;
            }

            return;
        }

        // 4. �÷��̾�� �������͸� ������
        transform.position += normalizedDir * speed * Time.deltaTime;
    }
}
