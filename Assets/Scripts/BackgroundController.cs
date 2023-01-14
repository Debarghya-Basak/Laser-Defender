using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] float cloudMoveSpeed = 0.6f; // 0.002f
    [SerializeField] float earthMoveSpeed = 0.5f; // 0.001f

    float defaultCloudUpPosition;
    float defaultCloudDownPosition;
    float defaultEarthUpPosition;
    float defaultEarthDownPosition;


    [SerializeField] GameObject cloudBackground;
    [SerializeField] GameObject cloudBackgroundUp;
    [SerializeField] GameObject cloudBackgroundDown;
    [SerializeField] GameObject earthBackground;
    [SerializeField] GameObject earthBackgroundUp;
    [SerializeField] GameObject earthBackgroundDown;

    void Start() {
        
        defaultCloudUpPosition = cloudBackgroundUp.transform.position.y;
        defaultCloudDownPosition = cloudBackgroundDown.transform.position.y;
        defaultEarthUpPosition = earthBackgroundUp.transform.position.y;
        defaultEarthDownPosition = earthBackgroundDown.transform.position.y;

    }

    void Update()
    {
        moveCloudBackground();
        moveEarthBackground();
    }

    void moveCloudBackground(){

        if(cloudBackground.transform.position.y <= -31.03f){
            cloudBackground.transform.position = new Vector3(0,0,0);
            cloudBackgroundUp.transform.position = new Vector3(0,defaultCloudUpPosition,0);
            cloudBackgroundDown.transform.position = new Vector3(0,defaultCloudDownPosition,0);
        }
            
        cloudBackground.transform.position -= new Vector3(0,cloudMoveSpeed * Time.deltaTime,0);
        cloudBackgroundUp.transform.position -= new Vector3(0,cloudMoveSpeed * Time.deltaTime,0);
        cloudBackgroundDown.transform.position -= new Vector3(0,cloudMoveSpeed * Time.deltaTime,0);

    }

    void moveEarthBackground(){

        if(earthBackground.transform.position.y <= -19.2f){
            earthBackground.transform.position = new Vector3(0,0,0);
            earthBackgroundUp.transform.position = new Vector3(0,defaultEarthUpPosition,0);
            earthBackgroundDown.transform.position = new Vector3(0,defaultEarthDownPosition,0);
        }
            
        earthBackground.transform.position -= new Vector3(0,earthMoveSpeed * Time.deltaTime,0);
        earthBackgroundUp.transform.position -= new Vector3(0,earthMoveSpeed * Time.deltaTime,0);
        earthBackgroundDown.transform.position -= new Vector3(0,earthMoveSpeed * Time.deltaTime,0);

    }
}
