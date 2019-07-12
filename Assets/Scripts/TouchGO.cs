using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TouchGO : MonoBehaviour {
    private Ray rayo;
  
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            
            rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit golpe;            
            if (Physics.Raycast(rayo, out golpe))
            {
                if (golpe.collider.gameObject.GetComponent<TouchableObject>())
                {
                    golpe.collider.gameObject.GetComponent<TouchableObject>().Touch();
                }
            }
        }
    }

   
}
