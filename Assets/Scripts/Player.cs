using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb; // Публичный RB для игрока
    [SerializeField] private float speed; // Скорость движения
    [SerializeField] private float directionInputX; // Переменная передвижения по оси X
    [SerializeField] private float directionInputY; // Переменная передвижения по оси Y

    private void Update()
    {
        rb.velocity = new Vector2(speed * directionInputX, rb.velocity.y); // Запуск движения по оси X
        rb.velocity = new Vector2(rb.velocity.x, speed * directionInputY); // Запуск движения по оси Y
    }

    public void MoveX(float InputAxis)
    {
        directionInputX = InputAxis; // Значение перемещения по оси Х 
    }

    public void MoveY(float InputAxis)
    {
        directionInputY = InputAxis; // Значение перемещения по оси Y
    }

}
