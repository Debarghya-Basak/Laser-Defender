using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RocketController : MonoBehaviour
{
    Vector2 moveAxis;
    float moveSpeed;
    Rigidbody2D rocketRigidBody;
    SpriteRenderer burnEffectRenderer;

    [SerializeField] GameObject burnEffect;
    [SerializeField] Sprite rocketBurnEffectLowPower;
    [SerializeField] Sprite rocketBurnEffectHighPower;

    void Start(){
        moveAxis = new Vector2(0,0);
        rocketRigidBody = GetComponent<Rigidbody2D>();
        moveSpeed = 2f;
        
        burnEffectRenderer = burnEffect.GetComponent<SpriteRenderer>();
        burnEffectRenderer.sprite = rocketBurnEffectLowPower;
    }

    void Update(){
        move();
    }

    void OnMove(InputValue move){

        moveAxis = move.Get<Vector2>();

        Debug.Log(moveAxis);

    }

    void move(){

        if(moveAxis.x != 0f || moveAxis.y != 0f){
            rocketRigidBody.drag = 0f;
            rocketRigidBody.velocity = new Vector2((moveAxis.x * moveSpeed), (moveAxis.y * moveSpeed));
            burnEffectRenderer.sprite = rocketBurnEffectHighPower;
        }
        else{
            rocketRigidBody.drag = 5f;  
            burnEffectRenderer.sprite = rocketBurnEffectLowPower;
        }

    }
}
