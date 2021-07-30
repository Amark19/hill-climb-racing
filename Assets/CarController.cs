using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public Rigidbody2D car;
    public Rigidbody2D lefttire;
    public Rigidbody2D Righttire;
    public staic float movement;
    public float speed=20;
    public float cartorque=10;
    public static float fuelamount=1;
    private float fuelreduce=0.1f;
    public UnityEngine.UI.Image fuelImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // movement=Input.GetAxis("Horizontal");//return float -1 to 1 where 0 is to come back to gravity
        fuelImage.fillAmount=fuelamount;
    }
    private void FixedUpdate() {
        if(fuelamount>0){
        lefttire.AddTorque(-movement*speed*Time.fixedDeltaTime);
        Righttire.AddTorque(-movement*speed*Time.fixedDeltaTime);
        car.AddTorque(-movement*cartorque*Time.fixedDeltaTime);
        fuelamount-=fuelreduce*Mathf.Abs(movement)*Time.fixedDeltaTime;
        }
        
    }
}
