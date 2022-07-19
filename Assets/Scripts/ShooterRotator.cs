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
        if (state == RotateSate.Idle) 

        {
            if (Input.GetButtonDown("Fire1")) // ���콺�� ������ ����
            {
                state = RotateSate.Horizontal; // Horizontal�� ����
            }
        }
        else if (state == RotateSate.Horizontal) 
        {
            if (Input.GetButton("Fire1")) // ���콺�� ������ ������
            {
                // ȸ���Ѵ�
                transform.Rotate(new Vector3(0, horizontalRotateSpeed * Time.deltaTime, 0));
            }
            else if (Input.GetButtonUp("Fire1")) // ���콺���� ���� ����
            {
                state = RotateSate.Vertical; // Horizontal���� Vertical�� �ٲ��ش�.
            }
            else if (state == RotateSate.Vertical)
            {
                if (Input.GetButton("Fire1")) // ���콺�� ������ ������
                {
                    // x�࿡ ���� ȸ��
                    transform.Rotate(new Vector3(-verticalRotateSpeed * Time.deltaTime, 0, 0));
                }
                else if (Input.GetButtonUp("Fire1")) // ���콺���� ���� ����
                {
                    state = RotateSate.Ready; // ���缭 ���
                }
            }
        }
    }




}
