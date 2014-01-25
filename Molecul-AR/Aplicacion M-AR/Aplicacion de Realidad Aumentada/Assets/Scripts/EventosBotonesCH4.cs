using UnityEngine;

public class EventosBotonesCH4 :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    
    private GameObject CH4;
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
        CH4 =GameObject.Find("CH4(A)");
		
		flag=0;
    }


    // Called when the virtual button has just been pressed:
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed");

        
        // Apply the new texture:
        switch (vb.VirtualButtonName)
        {
            case "rotar":
				if(flag==0){
                CH4.animation.PlayQueued("girar");
			}else{
				CH4.animation.PlayQueued("girarPlano");
				CH4.animation.PlayQueued("quieto");
				flag=0;
			}
                break;

            case "planos":
				if(flag==0){
                CH4.animation.PlayQueued("plano");
				flag=1;
			}
                break;
        }
    }


    // Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
      

       
    }


   
}