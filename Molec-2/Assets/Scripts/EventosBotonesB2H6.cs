using UnityEngine;
using System.Collections;

public class EventosBotonesB2H6 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{
    private GameObject B2H6;
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
        B2H6 =GameObject.Find("B2H6");
		//teoriaAudio.audio.Stop();
		B2H6.SetActiveRecursively(true);
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
		Debug.Log(EventosBotonesB2H6.activo);
		if(EventosBotonesB2H6.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Eje C2(a)")){
					B2H6.animation.PlayQueued("eje_C2a");
					B2H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Eje C2(b)")){
					B2H6.animation.PlayQueued("eje_C2b");
					B2H6.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Eje C2(c)")){
					B2H6.animation.PlayQueued("eje_C2c");
					B2H6.animation.PlayQueued("quieto");
				}
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Plano O(a)")){
						B2H6.animation.PlayQueued("plano_Oa");
					
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Plano O(b)")){
						B2H6.animation.PlayQueued("plano_Ob");
						
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Plano O(c)")){
						B2H6.animation.PlayQueued("plano_Oc");
						
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Todos los Planos")){
						B2H6.animation.PlayQueued("plano_todos");
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Quitar Planos")){
						B2H6.animation.PlayQueued("quieto");
				}
			}
			
		}	
	}
}
