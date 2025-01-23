using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float _rotateSpeed = 5;
    [SerializeField]
    private float _translate=1;

    
    void Update()
    {
        gameObject.transform.Rotate(0f,_rotateSpeed * Time.deltaTime,0f);
        gameObject.transform.Translate(0f, _translate,0f);
            if(_translate<= 5)
            {
                _translate++;
            }
        
    }
}
