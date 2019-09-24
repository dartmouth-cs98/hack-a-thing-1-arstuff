using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSelection : MonoBehaviour {
    private GameObject[] carList;
    private int currentCar = 0;

	// Use this for initialization
	void Start () {
        carList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; ++i){
            carList[i] = transform.GetChild(i).gameObject;
        }

        foreach(GameObject gameobj in carList){
            gameobj.SetActive(false);
        }

        if (carList[0]){
            carList[0].SetActive(true);
        } 
	}
	
    public void toggleCars(string direction){
        carList[currentCar].SetActive(false);

        if(direction == "Right"){
            currentCar++;
            if (currentCar > carList.Length - 1){
                currentCar = 0;
            }
        } else if (direction == "Left"){
            currentCar--;
            if (currentCar < 0){
                currentCar = carList.Length - 1;
            }
        }

        carList[currentCar].SetActive(true);
        gameController.currentSelectedCar = carList[currentCar].name;
        // GameObject cloudSystem = Instantiate(Resources.Load("cloudParticle"));

    }
}
