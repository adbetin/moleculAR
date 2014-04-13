using UnityEngine;
using System.Collections;

public class EventosBotonesC5H5 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject C5H5;
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
        C5H5 =GameObject.Find("C5H5");
		C5H5.SetActiveRecursively(true);
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
		Debug.Log(EventosBotonesC5H5.activo);
		if(EventosBotonesC5H5.activo){
			if(menu==1){
				Debug.Log("Esta mostrando el boton ejes");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Eje C5")){
					C5H5.animation.PlayQueued("eje_C5");
					C5H5.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Eje C5-2")){
					C5H5.animation.PlayQueued("eje_C5-2");
					C5H5.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 15, 150, 50), "Eje C5-3")){
					C5H5.animation.PlayQueued("eje_C5-3");
					C5H5.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Eje C5-4")){
					C5H5.animation.PlayQueued("eje_C5-4");
					C5H5.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Eje C2(a)")){
					C5H5.animation.PlayQueued("eje_C2a");
					C5H5.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 70, 150, 50), "Eje C2(b)")){
					C5H5.animation.PlayQueued("eje_C2b");
					C5H5.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Eje C2(c)")){
					C5H5.animation.PlayQueued("eje_C2c");
					C5H5.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Eje C2(d)")){
					C5H5.animation.PlayQueued("eje_C2d");
					C5H5.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 125, 150, 50), "Eje C2(e)")){
					C5H5.animation.PlayQueued("eje_C2e");
					C5H5.animation.PlayQueued("quieto");
				}
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Plano Oh")){
						C5H5.animation.PlayQueued("plano_Oh");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Plano Ov(a)")){
						C5H5.animation.PlayQueued("plano_Ova");						
				}
				if(GUI.Button(new Rect(325, 15, 150, 50), "Plano Ov(b)")){
						C5H5.animation.PlayQueued("plano_Ovb");						
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Plano Ov(c)")){
						C5H5.animation.PlayQueued("plano_Ovc");						
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Plano Ov(d)")){
						C5H5.animation.PlayQueued("plano_Ovd");						
				}
				if(GUI.Button(new Rect(325, 70, 150, 50), "Plano Ov(e)")){
						C5H5.animation.PlayQueued("plano_Ove");						
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Todos los Planos")){
						C5H5.animation.PlayQueued("plano_todos");
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Quitar Planos")){
						C5H5.animation.PlayQueued("quieto");
				}
			}
		}	
	}
}
