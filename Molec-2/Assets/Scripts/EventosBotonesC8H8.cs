using UnityEngine;
using System.Collections;

public class EventosBotonesC8H8 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject C8H8;
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
        C8H8 =GameObject.Find("C8H8");
		C8H8.SetActiveRecursively(true);
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
				Debug.Log("Presiono ejes");
				if(menu==1){
					menu=0;
				}else{
					menu=1;
				}			
				break;
			case "planos":
				Debug.Log("Presiono planos");
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
		Debug.Log(EventosBotonesC8H8.activo);
		if(EventosBotonesC8H8.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Eje C4")){
					C8H8.animation.PlayQueued("eje_C4");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Eje C4-3")){
					C8H8.animation.PlayQueued("eje_C4");
					C8H8.animation.PlayQueued("eje_C4");
					C8H8.animation.PlayQueued("eje_C4");
					C8H8.animation.PlayQueued("quieto");
				}
				
				
				if(GUI.Button(new Rect(15, 70, 150, 50), "Eje C2")){
					C8H8.animation.PlayQueued("eje_C2a");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Eje C2'(a)")){
					C8H8.animation.PlayQueued("eje_C2b");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Eje C2'(b)")){
					C8H8.animation.PlayQueued("eje_C2e");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Eje C2''(a)")){
					C8H8.animation.PlayQueued("eje_C2d");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 180, 150, 50), "Eje C2''(b)")){
					C8H8.animation.PlayQueued("eje_C2c");
					C8H8.animation.PlayQueued("quieto");
				}
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Plano O")){
						C8H8.animation.PlayQueued("plano_Oa");
					
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Plano Ov(a)")){
						C8H8.animation.PlayQueued("plano_Ob");
						
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Plano Ov(b)")){
						C8H8.animation.PlayQueued("plano_Od");
						
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Plano Od(a)")){
						C8H8.animation.PlayQueued("plano_Oc");
						
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Plano Od(b)")){
						C8H8.animation.PlayQueued("plano_Oe");
						
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Todos los Planos")){
						C8H8.animation.PlayQueued("plano_todos");
				}
				if(GUI.Button(new Rect(15, 180, 150, 50), "Quitar Planos")){
						C8H8.animation.PlayQueued("quieto");
				}
			}
			
		}	
	}
}