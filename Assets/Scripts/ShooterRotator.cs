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
                if(Input.GetButton("Fire1")) // 마우스를 누르고 있으면
                {
                    // 회전한다
                    transform.Rotate(new Vector3(0, horizontalRotateSpeed * Time.deltaTime, 0));
                }
                else if (Input.GetButtonUp("Fire1")) // 마우스에서 손을 떼면
                {
                    state = RotateSate.Vertical; // Horizontal에서 Vertical로 바꿔준다.
                }
                break;


            case RotateSate.Vertical:
                if (Input.GetButton("Fire1")) // 마우스를 누르고 있으면
                {
                    // x축에 대한 회전
                    transform.Rotate(new Vector3(-verticalRotateSpeed * Time.deltaTime, 0, 0));
                }
                else if (Input.GetButtonUp("Fire1")) // 마우스에서 손을 떼면
                {
                    state = RotateSate.Ready; // 멈춰서 대기
                }
                break;


            case RotateSate.Ready:
                break;

        }
        
    }
}
