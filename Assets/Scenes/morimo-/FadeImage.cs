using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeImage : MonoBehaviour {
    float alfa;
    float speed = 0.01f;
    float red, green, blue;
		public Image Slide;

    void Start () {
      red = Slide.color.r;
      green = Slide.color.g;
      blue = Slide.color.b;
			alfa = Slide.color.a;

			Slide.color = new Color(red, green, blue, alfa);
    }

    void Update () {
      	alfa += speed;
				// if(Input.GetMouseButton(0)){
      	//   alfa -= speed * 2;
				// }

    }

}