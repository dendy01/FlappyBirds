using UnityEngine;

public class MovementTubes : MonoBehaviour
{
    // Awake - работает перед Start в момент включения скрипта (до первого кадра)
    // Start - первый кадр, в котором включился скрипт (один раз)
    // Update - вызывается unity каждый кадр
    // FixedUpdate - вызывается каждые 20 мс (50 раз в секунду)
    // LateUpdate - вызывается в промежутке между кадрами

    // задача: заставить трубы двигаться налево

    // сериализация - перевод класса в строку (как json)

    [Header("Description")] [SerializeField] private Transform tubes;
    [SerializeField] private float speed = 1f;

    private void FixedUpdate()
    {
        Vector2 pos = tubes.position;
        pos.x -= speed;
        tubes.position = pos;
    }
}
