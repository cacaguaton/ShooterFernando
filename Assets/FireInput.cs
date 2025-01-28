using UnityEngine;

public class FireImput : MonoBehaviour
{

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<GetWeapon>().Weapon?.shoot();
        }
    }
}
