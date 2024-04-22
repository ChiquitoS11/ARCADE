using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstudianteMovement : MonoBehaviour
{
    [SerializeField] private int speed;
    private Rigidbody2D estudiante;
    private Vector2 moveInput;
    private Animator estudianteAnimator;

    void Start()
    {
        estudiante = GetComponent<Rigidbody2D>();
        estudianteAnimator = GetComponent<Animator>();

        //transform.Rotate(new Vector3(0, 0, 3 * Time.deltaTime));
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;

        estudianteAnimator.SetFloat("Horizontal", moveX);
        estudianteAnimator.SetFloat("Vertical", moveY);
        estudianteAnimator.SetFloat("Speed", moveInput.sqrMagnitude);

    }

    private void FixedUpdate()
    {
        estudiante.MovePosition(estudiante.position + moveInput * speed * Time.fixedDeltaTime);
    }
}
