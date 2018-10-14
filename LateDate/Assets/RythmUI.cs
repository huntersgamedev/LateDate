using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RythmUI : MonoBehaviour {
    //angryMeterControlls
    public Image AngryIndicator;
    private float FullMeterX= 259f;
    private float EmptyMeterX= 788.3f;
    private float CurrentPosition;
    private float MoveAmount=5.293f;  
       

	// Use this for initialization
	void Start () {
       // AngryIndicator.transform.position = new Vector3(CurrentPosition,AngryIndicator.transform.position.y,AngryIndicator.transform.position.z));
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            angryMeterControl(-5);
        }
	}

    private void angryMeterControl(float amountChanged)
    {
        
        
        if(AngryIndicator.transform.position.x <FullMeterX&&
        AngryIndicator.transform.position.x > EmptyMeterX)
        {
            
            MoveAmount = amountChanged * 5.293f;

            AngryIndicator.transform.position = new Vector3(AngryIndicator.transform.position.x + MoveAmount, AngryIndicator.transform.position.y, AngryIndicator.transform.position.z);
        }
     
    }



}
