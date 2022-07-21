using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterRotator : MonoBehaviour
{
    private enum RotateSate
    {
        Idle, Vertical, Horizontal, Ready
    }

    private RotateSate state= RotateSate.Idle;

    public float verticalRotateSpeed = 360f;
    public float horizontalRotateSpeed = 360f;

    void Update()
    {
        switch (state)
        {

            case RotateSate.Idle:
                if (Input.GetButtonDown("Fire1"))
                {
                    state = RotateSate.Horizontal;
                }
                break;
               

            case RotateSate.Horizontal:
                if(Input.GetButton("Fire1")) // ���콺�� ������ ������
                {
                    // ȸ���Ѵ�
                    transform.Rotate(new Vector3(0, horizontalRotateSpeed * Time.deltaTime, 0));
                }
                else if (Input.GetButtonUp("Fire1")) // ���콺���� ���� ����
                {
                    state = RotateSate.Vertical; // Horizontal���� Vertical�� �ٲ��ش�.
                }
                break;


            case RotateSate.Vertical:
                if (Input.GetButton("Fire1")) // ���콺�� ������ ������
                {
                    // x�࿡ ���� ȸ��
                    transform.Rotate(new Vector3(-verticalRotateSpeed * Time.deltaTime, 0, 0));
                }
                else if (Input.GetButtonUp("Fire1")) // ���콺���� ���� ����
                {
                    state = RotateSate.Ready; // ���缭 ���
                }
                break;


            case RotateSate.Ready:
                break;

        }
        
    }
}
