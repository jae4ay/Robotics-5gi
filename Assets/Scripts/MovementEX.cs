using System;
using UnityEngine;

// Cube�� CylinderA���� CylinderB�� �̵���Ų��
// �Ӽ� : ��ü�� �ӵ�, ������, ������
public class MovementEX : MonoBehaviour
{
    [SerializeField] private float speed;
    //public float Speed { get; set; }
    public GameObject cylinderA; // Cylinder�� ���� ������Ʈ �Ӽ����� get, set ��� X
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
        // A���� B�� ���ϴ� ���� -> ��������(ũ�Ⱑ 1�� ����) -> Player���� �������͸� �����ش�
        Vector3 direction = end.transform.position - start.transform.position;
        Vector3 normalizedDir = direction.normalized; // ��������(ũ�Ⱑ 1�� ����)

        // ������ �� ���ΰ� ? cylinder B������ �Ÿ�
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
