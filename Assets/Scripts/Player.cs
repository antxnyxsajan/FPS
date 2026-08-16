using System;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Player : MonoBehaviour
{
    [SerializeField] float speed=5f;
    CharacterController controller;
    PlayerControls pc;

    void Awake()
    {
       controller=GetComponent<CharacterController>(); 
       pc=new PlayerControls();
       pc.Enable();
    }

    void Start()
    {       }

    void Update()
    {
        Vector2 input=pc.Player.Move.ReadValue<Vector2>();
        Vector3 move=transform.right*input.x + transform.forward*input.y;
        controller.Move(move*Time.deltaTime*speed);
    }
}
