using UnityEngine;
using System.Collections;

public class EventosBotonesCH4 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject CH4;
	public static bool activo=false;
	int menu=0;
    void Start()
    {
        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }

        // Get handle to the teapot object
        CH4 =GameObject.Find("CH4");
		CH4.SetActiveRecursively(true);
		menu=0;
		Debug.Log("termino de Iniciar");
    }


    // Called when the virtual button has just been pressed:
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed");

        
        // Apply the new texture:
        switch (vb.VirtualButtonName)
        {
           case "ejes":
				Debug.Log("Presiono eje_c2");
				if(menu==1){
					menu=0;
				}else{
					menu=1;
				}			
				break;
			case "planos":
				Debug.Log("Presiono plano_sigma1");
				if(menu==2){
					menu=0;
				}else{
					menu=2;
				}	
				break;			
			case "play":
				Debug.Log("Presiono Play");
				audio.Play();
				break;
			
			case "pause":
				Debug.Log("Presiono pause");
				audio.Pause();
				break;
			
			case "stop":
				Debug.Log("Presiono stop");
				audio.Stop();
				break;
        }
    }


    // Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    { 
    }

	 public void OnMouseEnter() {
        //if (!H2O.animation.IsPlaying("plano"))
        	//txtZ.SetActiveRecursively(true);
		
    }
	
	private void OnGUI(){
		Debug.Log(EventosBotonesCH4.activo);
		if(EventosBotonesCH4.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Eje C3 a")){
					CH4.animation.PlayQueued("eje_C3a");
					CH4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Eje C3(2) a")){
					CH4.animation.PlayQueued("eje_C3(2)a");
					CH4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Eje C3 b")){
					CH4.animation.PlayQueued("eje_C3b");
					CH4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Eje C3(2) b")){
					CH4.animation.PlayQueued("eje_C3(2)b");
					CH4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Eje C3 c")){
					CH4.animation.PlayQueued("eje_C3c");
					CH4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Eje C3(2) c")){
					CH4.animation.PlayQueued("eje_C3(2)c");
					CH4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 180, 150, 50), "Eje C3 d")){
					CH4.animation.PlayQueued("eje_C3d");
					CH4.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 180, 150, 50), "Eje C3(2) d")){
					CH4.animation.PlayQueued("eje_C3(2)d");
					CH4.animation.PlayQueued("quieto");
				}
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Plano Od(a)")){
						CH4.animation.PlayQueued("plano_sd(a)");
						
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Plano Od(b)")){
						CH4.animation.PlayQueued("plano_sd(b)");
						
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Plano Od(c)")){
						CH4.animation.PlayQueued("plano_sd(c)");
						
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Plano Od(d)")){
						CH4.animation.PlayQueued("plano_sd(d)");
						
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Plano Od(e)")){
						CH4.animation.PlayQueued("plano_sd(e)");
						
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Plano Od(f)")){
						CH4.animation.PlayQueued("plano_sd(f)");
						
				}		
				
				if(GUI.Button(new Rect(15, 180, 150, 50), "Todos los Planos")){
						CH4.animation.PlayQueued("plano_todos");
						
				}
				if(GUI.Button(new Rect(170, 180, 150, 50), "Quitar Planos")){
						
						CH4.animation.PlayQueued("quieto");
				}
			}
			
		}	
	}
}
