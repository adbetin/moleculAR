using UnityEngine;
using System.Collections;

public class EventosBotonesB2H6 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject B2H6;
	private GameObject teoriaAudio;
	private GameObject txtX;
	private GameObject txtY;
	private GameObject txtZ;
	int flag;
    void Start()
    {
        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }

        // Get handle to the teapot object
        B2H6 =GameObject.Find("B2H6(A)");
		teoriaAudio = GameObject.Find("Teoria");
		txtX =GameObject.Find("RotarX");
		txtY =GameObject.Find("RotarY");
		txtZ =GameObject.Find("RotarZ");
		teoriaAudio.audio.Stop();
		B2H6.SetActiveRecursively(true);
		txtX.SetActiveRecursively(false);
		txtY.SetActiveRecursively(false);
		txtZ.SetActiveRecursively(false);
		flag=0;
    }


    // Called when the virtual button has just been pressed:
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed");

        
        // Apply the new texture:
        switch (vb.VirtualButtonName)
        {
           case "ejex":
				if(flag==0){
				txtY.SetActiveRecursively(false);
				txtZ.SetActiveRecursively(false);
				txtX.SetActiveRecursively(true);
				B2H6.animation.PlayQueued("ejex");
				}else
				B2H6.animation.PlayQueued("rotarx");
				break;
			
			case "ejey":
				if(flag==0){
				txtX.SetActiveRecursively(false);
				txtZ.SetActiveRecursively(false);
				txtY.SetActiveRecursively(true);
				B2H6.animation.PlayQueued("ejey");
			
			}else
				B2H6.animation.PlayQueued("rotary");
                break;
			
			case "ejez":
				if(flag==0){
				txtX.SetActiveRecursively(false);
				txtY.SetActiveRecursively(false);
				txtZ.SetActiveRecursively(true);
				B2H6.animation.PlayQueued("ejez");
			}else
				B2H6.animation.PlayQueued("rotarz");
                break;

            case "planos":
				if(flag==0){
				txtX.SetActiveRecursively(false);
				txtY.SetActiveRecursively(false);
				txtZ.SetActiveRecursively(false);
                B2H6.animation.PlayQueued("plano");
				//OnMouseEnter();
				flag=1;
			}else{
				B2H6.animation.PlayQueued("quieto");
             	flag=0;   
			}
				break;
			
			case "play":
				teoriaAudio.audio.Play();
				break;
			
			case "pause":
				teoriaAudio.audio.Pause();
				break;
			
			case "stop":
				teoriaAudio.audio.Stop();
				break;
        }
    }


    // Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
      

       
    }

	 public void OnMouseEnter() {
        if (!B2H6.animation.IsPlaying("plano"))
        	txtZ.SetActiveRecursively(true);
		
    }
}
