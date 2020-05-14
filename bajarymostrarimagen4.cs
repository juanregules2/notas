/*
1-descarga la imagen de un URL
2-la muestra en IMAGE UI
3-la muestra en SPRITE RENDERER 
4-la del sprite renderer lo pone a la medida

*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class bajarymostrarimagen4 : MonoBehaviour
{

    public Sprite spritex;
    public Image imagen;
    public Text texto;
    float progress=0;
    public SpriteRenderer spriteR;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void cargaimagen4(){
        StartCoroutine(RealLoadImage());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*SI JALO PARA MOSTRARSE EN LA IMAGE UI DE ANDROID */
     /*SI JALO PARA MOSTRARSE EN LA IMAGE UI DE ANDROID */
     //https://answers.unity.com/questions/933765/problem-dipsplaying-an-image-from-url-to-uiimage-c.html?childToView=1730559#answer-1730559
         private IEnumerator RealLoadImage () {

        float widthimage=0;
        float heightimage=0;

         string url = "https://blackdish.mx/blackdish-beta-v3/backend/model/img_admin/WhatsApp_Image_2020-03-19_at_21-removebg-preview.png";
         WWW imageURLWWW = new WWW(url);  
         texto.text+=url+"|";
         yield return imageURLWWW;        
         
         if(imageURLWWW.texture != null)
         {
             Debug.Log("texture bien"+url);
                texto.text+="url valida";
             spritex = Sprite.Create(imageURLWWW.texture, new Rect(0, 0, imageURLWWW.texture.width, imageURLWWW.texture.height), Vector2.zero);  
             imagen.sprite=spritex;
             texto.text+="ya debio cargarse";
             float progress=imageURLWWW.progress;
             widthimage=imageURLWWW.texture.width;
             heightimage=imageURLWWW.texture.height;

              if(progress==1){
             spriteM(widthimage,heightimage,spritex);
         }
           
         }else{
             Debug.Log("texture null");
             texto.text+="null";
         }


        

         yield return null;
     }
     public void spriteM(float w, float h,Sprite spritex){

         int w_int=(int)w;
         int h_int=(int)h;
         Texture2D texture2d = new Texture2D(w_int,h_int);
         texture2d=spritex.texture;

       //  byte[] byteArray2 = File.ReadAllBytes(spritex);
         //   texture2d.LoadImage(byteArray2);

            spriteR.sprite=Sprite.Create(texture2d,new Rect(0,0,w,h),Vector2.zero,50);

     }
}
