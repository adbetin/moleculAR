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
				if(GUI.Button(new Rect(15, 15, 150, 50), "Eje C3(a)")){
					C8H8.animation.PlayQueued("eje_C3a");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Eje C3(a)-2")){
					C8H8.animation.PlayQueued("eje_C3-2a");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 15, 150, 50), "Eje C3(b)")){
					C8H8.animation.PlayQueued("eje_C3b");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Eje C3(b)-2")){
					C8H8.animation.PlayQueued("eje_C3-2b");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Eje C3(c)")){
					C8H8.animation.PlayQueued("eje_C3c");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 70, 150, 50), "Eje C3(c)-2")){
					C8H8.animation.PlayQueued("eje_C3-2c");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Eje C3(d)")){
					C8H8.animation.PlayQueued("eje_C3d");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Eje C3(d)-2")){
					C8H8.animation.PlayQueued("eje_C3-2d");
					C8H8.animation.PlayQueued("quieto");
				}
				//Se deben separar para mostrar en bloques de 3
				if(GUI.Button(new Rect(15, 180, 150, 50), "Eje C4(a)")){
					C8H8.animation.PlayQueued("eje_C4a");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 180, 150, 50), "Eje C2(a)")){
					C8H8.animation.PlayQueued("eje_C4a");
					C8H8.animation.PlayQueued("eje_C4a");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 180, 150, 50), "Eje C4(a)-3")){
					C8H8.animation.PlayQueued("eje_C4a");
					C8H8.animation.PlayQueued("eje_C4a");
					C8H8.animation.PlayQueued("eje_C4a");
					C8H8.animation.PlayQueued("quieto");
				}
				//Se deben separar para mostrar en bloques de 3
				if(GUI.Button(new Rect(15, 235, 150, 50), "Eje C4(b)")){
					C8H8.animation.PlayQueued("eje_C4b");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 235, 150, 50), "Eje C2(b)")){
					C8H8.animation.PlayQueued("eje_C4b");
					C8H8.animation.PlayQueued("eje_C4b");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 235, 150, 50), "Eje C4(b)-3")){
					C8H8.animation.PlayQueued("eje_C4b");
					C8H8.animation.PlayQueued("eje_C4b");
					C8H8.animation.PlayQueued("eje_C4b");
					C8H8.animation.PlayQueued("quieto");
				}
				//Se deben separar para mostrar en bloques de 3
				if(GUI.Button(new Rect(15, 290, 150, 50), "Eje C4(c)")){
					C8H8.animation.PlayQueued("eje_C4c");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 290, 150, 50), "Eje C2(c)")){
					C8H8.animation.PlayQueued("eje_C4c");
					C8H8.animation.PlayQueued("eje_C4c");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 290, 150, 50), "Eje C4(c)-3")){
					C8H8.animation.PlayQueued("eje_C4c");
					C8H8.animation.PlayQueued("eje_C4c");
					C8H8.animation.PlayQueued("eje_C4c");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 345, 150, 50), "Eje C2'(a)")){
					C8H8.animation.PlayQueued("eje_C2pa");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 345, 150, 50), "Eje C2'(b)")){
					C8H8.animation.PlayQueued("eje_C2pb");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 345, 150, 50), "Eje C2'(c)")){
					C8H8.animation.PlayQueued("eje_C2pc");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(15, 400, 150, 50), "Eje C2'(d)")){
					C8H8.animation.PlayQueued("eje_C2pd");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(170, 400, 150, 50), "Eje C2'(e)")){
					C8H8.animation.PlayQueued("eje_C2pe");
					C8H8.animation.PlayQueued("quieto");
				}
				if(GUI.Button(new Rect(325, 400, 150, 50), "Eje C2'(f)")){
					C8H8.animation.PlayQueued("eje_C2pf");
					C8H8.animation.PlayQueued("quieto");
				}
				
			}
			else if(menu==2){
				Debug.Log("esta mostrando el boton planos");
				if(GUI.Button(new Rect(15, 15, 150, 50), "Plano Oh(a)")){
						C8H8.animation.PlayQueued("plano_Oha");					
				}
				if(GUI.Button(new Rect(170, 15, 150, 50), "Plano Oh(b)")){
						C8H8.animation.PlayQueued("plano_Ohb");					
				}
				if(GUI.Button(new Rect(325, 15, 150, 50), "Plano Oh(c)")){
						C8H8.animation.PlayQueued("plano_Ohc");					
				}
				if(GUI.Button(new Rect(15, 70, 150, 50), "Plano Od(a)")){
						C8H8.animation.PlayQueued("plano_Oda");					
				}
				if(GUI.Button(new Rect(170, 70, 150, 50), "Plano Od(b)")){
						C8H8.animation.PlayQueued("plano_Odb");					
				}
				if(GUI.Button(new Rect(325, 70, 150, 50), "Plano Od(c)")){
						C8H8.animation.PlayQueued("plano_Odc");					
				}
				if(GUI.Button(new Rect(15, 125, 150, 50), "Plano Od(d)")){
						C8H8.animation.PlayQueued("plano_Odd");					
				}
				if(GUI.Button(new Rect(170, 125, 150, 50), "Plano Od(e)")){
						C8H8.animation.PlayQueued("plano_Ode");					
				}
				if(GUI.Button(new Rect(325, 125, 150, 50), "Plano Od(f)")){
						C8H8.animation.PlayQueued("plano_Odf");					
				}
				if(GUI.Button(new Rect(15, 180, 150, 50), "Todos los Planos")){
						C8H8.animation.PlayQueued("plano_todos");
				}
				if(GUI.Button(new Rect(170, 180, 150, 50), "Quitar Planos")){
						C8H8.animation.PlayQueued("quieto");
				}
			}
		}	
	}
}
