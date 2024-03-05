using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBalloons : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject Smoke;
    public BalloonsFly balloonsFlyManager;

    public int point=0;
      void Start()
    {
        ScoreCounter.score = 0;
        balloonsFlyManager = GetComponent<BalloonsFly>();
    }
    public void Shoot(){

        RaycastHit hit;
        if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward,out hit)){
            if(hit.collider.gameObject.tag == "Balloon"){
                Destroy(hit.transform.gameObject);
                Instantiate(Smoke,hit.point,Quaternion.LookRotation(hit.normal));
                point++;
                ScoreCounter.score = point;

                if (balloonsFlyManager != null)
                {
                    balloonsFlyManager.IncreaseSpeed(0.05f);
                }
            }
        }
    }
}
