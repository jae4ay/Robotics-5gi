using System;
using UnityEngine;

// Cube�� CylinderA -> CylinderB �� �̵���Ų��.
// �Ӽ�: ��ü�� �ӵ�, ������, ������
public class MovementEx : MonoBehaviour
{
    [SerializeField] private float speed;
    // public float Speed { get; set; }
    public GameObject cylinderA;
    public GameObject cylinderB;
    public bool isCylinderA = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isCylinderA)
            MoveAtoB(transform.gameObject, cylinderB);
        else
            MoveAtoB(transform.gameObject, cylinderA);
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
            isCylinderA = !isCylinderA; // false -> true, true -> false
            return;
        }

        // 4. �÷��̾�� �������͸� ������
        transform.position += normalizedDir * speed * Time.deltaTime; 
    }
}
