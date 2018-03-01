using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{

    [SerializeField]
    private GameObject PopUpGameObject;
    [SerializeField]
    private GameObject PopUpPrefab;
    void Start () {
		
	}


	void Update () {
		
	}

    public void CloseWindow()
    {
       Destroy(PopUpGameObject);
    
    }
    public void MalusFunction()
    {
        int nbWindow = Random.Range(1, 5);

        for (int i = 0; i < nbWindow; ++i)
        {
            int X = Random.Range(-150, 150);
            int Y = Random.Range(-150, 150);
            Instantiate(PopUpPrefab, new Vector3(X, Y, 0), new Quaternion());
        }
        
    }
}
