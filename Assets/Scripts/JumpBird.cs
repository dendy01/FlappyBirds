using UnityEngine;

public class JumpBird : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bird;
    [SerializeField] private float jump = 5f;

    // если работаем со вводом с клавиатуры/мыши, то обязательно надо использовать Update

    void Update()
    {
        // GetKeyDown - момент нажатия
        // GetKey - во время зажатия
        // GetKeyUp - момент отпускания
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bird.linearVelocityY = jump;
        }        
    }
}
