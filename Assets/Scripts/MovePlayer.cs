using System;
using UnityEngine;
using UnityEngine.UIElements;

// Unity�� Lifecycle �޼���
// ��ü�� ����Ű�� �Է��� �޾� �̵���Ų��.
public class MovePlayer : MonoBehaviour
{
    public float speed = 2;
    public float rotSpeed = 2;
    float xRot;
    float yRot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("��Ƴ�");

        // ȸ�� �ʱ�ȭ
        transform.rotation = Quaternion.identity; // ȸ���� ���� ����
        //transform.rotation = Quaternion.Euler(30, 45, 60);
    }

    // 100FPS: 1�ʿ� 100�� ������Ʈ �Լ��� �۵�
    // 30FPS ~ 400FPS
    // Update is called once per frame
    void Update()
    {
        // MoveWithoutTime();

        MoveWithTime();

        RotatePlayer();
    }

    private void RotatePlayer()
    {
        // ���Ϸ�ȸ��: 0~360 �����ϱ� ���� ������ ���� �־ ȸ��(������)
        // ���ʹϾ�ȸ��: 4����(x,y,z,w), ���Ϸ�ȸ���� ������ ������(gimbal lock)�� ����
        // ������: ������ ȸ���� �ܺο� ȸ���� ���� �������� �Ҿ������ ����

        // transform.eulerAngles = new Vector3(30, 45, 60);

        // ���Ϸ� ȸ�� �������� ����
        // transform.eulerAngles += new Vector3(1 * 0.1f, 1 * 0.1f, 0);

        // ���ʹϾ� ȸ�� ����
        // transform.Rotate(transform.up, 0.1f); // �� �ڽ��� Up ���� ���� ȸ��
        // transform.Rotate(transform.right, 0.1f); // �� �ڽ��� Right ���� ���� ȸ��

        // transform.rotation = Quaternion.identity; // ȸ���� ���� ����

        // Rotate�� ���� ���
        // Quaternion rotY90 = Quaternion.AngleAxis(0.1f, Vector3.up); // ���ʹϾ� ����
        // transform.rotation *= rotY90; // Quaternion�� ���Ѵ�.(Vector3���� ����)

        //Vector3 rotDir = Input.mousePosition;
        //print(rotDir);

        float mouseX = Input.GetAxis("Mouse X"); // ���� -1 ~ 1
        float mouseY = Input.GetAxis("Mouse Y"); // ������ -1 ~ 1

        print($"mouseX: {mouseX}, mouseY: {mouseY}");

        xRot += mouseX * rotSpeed * Time.deltaTime;
        yRot += mouseY * rotSpeed * Time.deltaTime;

        // -90 ~ 90�� ���� ����
        yRot = Mathf.Clamp( yRot, -90, 90 );

        transform.rotation = Quaternion.Euler(-yRot, xRot, 0);
    }

    private void MoveWithTime()
    {
        // ���̽�ƽ�� ��ǲ�� ����� -1 ~ 1�� ǥ���ϴ� �Լ�
        float horizontalInput = Input.GetAxis("Horizontal"); // ����Ű �¿�
        float verticalInput = Input.GetAxis("Vertical");     // ����Ű ����

        // �Ϲ����� ���� ���ǹ��
        //Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        // ������Ʈ ������ ���� ���� ���
        Vector3 direction = transform.forward * verticalInput + transform.right * horizontalInput;
        transform.position += direction * speed * Time.deltaTime; // 0.03s 
    }


    // �ð��� ���� ��� ���� Move�޼���
    private void MoveWithoutTime()
    {
        bool isWKeyDown = Input.GetKey(KeyCode.W);
        bool isAKeyDown = Input.GetKey(KeyCode.A);
        bool isSKeyDown = Input.GetKey(KeyCode.S);
        bool isDKeyDown = Input.GetKey(KeyCode.D);

        if (isWKeyDown)
        {
            // ���� ���ϱ�
            Vector3 direction = Vector3.forward * speed;        // ���� ��ǥ�� ����
            Vector3 localDirection = transform.forward * speed; // ���� ��ǥ�� ����

            // ������ǥ�� �� ������ġ + ���⺤��
            transform.position += localDirection;
        }

        if (isSKeyDown)
        {
            // ���� ���ϱ�
            Vector3 direction = Vector3.back * speed;
            Vector3 localDirection = -transform.forward * speed;

            // ������ǥ�� �� ������ġ + ���⺤��
            transform.position += localDirection;
        }

        if (isAKeyDown)
        {
            // ���� ���ϱ�
            Vector3 direction = Vector3.left * speed;
            Vector3 localDirection = -transform.right * speed;

            // ������ǥ�� �� ������ġ + ���⺤��
            transform.position += localDirection;
        }

        if (isDKeyDown)
        {
            // ���� ���ϱ�
            Vector3 direction = Vector3.right * speed;
            Vector3 localDirection = transform.right * speed;

            // ������ǥ�� �� ������ġ + ���⺤��
            transform.position += localDirection;
        }
    }
}
