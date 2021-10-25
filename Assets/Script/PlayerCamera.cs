using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private Transform cameraTransform { get; set; } = null;

    public float _borderSize = 10;
    private float borderSize { get { return _borderSize; } }


    public float _cameraSpeed = 2;
    private float cameraSpeed { get { return _cameraSpeed; } }

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 direction = Vector3.zero;

        if (mousePosition.x <= borderSize || Input.GetAxis("Horizontal") < 0)
        {
            direction += Vector3.left;
        }
        else if (mousePosition.x >= Screen.width - borderSize || Input.GetAxis("Horizontal") > 0)
        {
            direction += Vector3.right;
        }

        if (mousePosition.y <= borderSize || Input.GetAxis("Vertical") < 0)
        {
            direction += Vector3.back;
        }
        else if (mousePosition.y >= Screen.height - borderSize || Input.GetAxis("Vertical") > 0)
        {
            direction += Vector3.forward;
        }

        cameraTransform.position += direction.normalized * Time.deltaTime * cameraSpeed;
    }
}
