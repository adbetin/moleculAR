using UnityEngine;
using System.Collections;

public class EventosBotonesHOCH2CH2OH :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject HOCH2CH2OH;
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
        HOCH2CH2OH =GameObject.Find("HOCH2CH2OH");
		HOCH2CH2OH.SetActiveRecursively(true);
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
		Debug.Log(EventosBotonesHOCH2CH2OH.activo);
		if(EventosBotonesHOCH2CH2OH.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Eje C4")){
					HOCH2CH2OH.animation.PlayQueued("eje_C4");
					HOCH2CH2OH.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Eje C4-3")){
					HOCH2CH2OH.animation.PlayQueued("eje_C4");
					HOCH2CH2OH.animation.PlayQueued("eje_C4");
					HOCH2CH2OH.animation.PlayQueued("eje_C4");
					HOCH2CH2OH.animation.PlayQueued("quieto");
				}
				
				
				if(GUI.Button(new Rect(15, 70, 150, 50), "Eje C2")){
					HOCH2CH2OH.animation.PlayQueued("eje_C2a");
					HOCH2CH2OH.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Eje C2'(a)")){
					HOCH2CH2OH.animation.PlayQueued("eje_C2b");
					HOCH2CH2OH.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Eje C2'(b)")){
					HOCH2CH2OH.animation.PlayQueued("eje_C2e");
					HOCH2CH2OH.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Eje C2''(a)")){
					HOCH2CH2OH.animation.PlayQueued("eje_C2d");
					HOCH2CH2OH.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 180, 150, 50), "Eje C2''(b)")){
					HOCH2CH2OH.animation.PlayQueued("eje_C2c");
					HOCH2CH2OH.animation.PlayQueued("quieto");
				}
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Plano O")){
						HOCH2CH2OH.animation.PlayQueued("plano_Oa");
					
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Plano Ov(a)")){
						HOCH2CH2OH.animation.PlayQueued("plano_Ob");
						
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Plano Ov(b)")){
						HOCH2CH2OH.animation.PlayQueued("plano_Od");
						
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Plano Od(a)")){
						HOCH2CH2OH.animation.PlayQueued("plano_Oc");
						
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Plano Od(b)")){
						HOCH2CH2OH.animation.PlayQueued("plano_Oe");
						
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Todos los Planos")){
						HOCH2CH2OH.animation.PlayQueued("plano_todos");
				}
				if(GUI.Button(new Rect(15, 180, 150, 50), "Quitar Planos")){
						HOCH2CH2OH.animation.PlayQueued("quieto");
				}
			}
			
		}	
	}
}
