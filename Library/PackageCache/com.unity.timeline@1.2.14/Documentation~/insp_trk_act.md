e the Control clip control the Particle system on the child GameObject.|
                                                                                                                                                                                                                                                                                                                                                                                                                                                       # Activation track properties

Use the Inspector window to change the name of an Activation track and set the state of its bound GameObject when the Timeline Asset finishes playing.

![Inspector window when selecting an Activation track in the Timeline window](images/timeline_inspector_activation_track.png)

_Inspector window when selecting an Activation track in the Timeline window_

|**Property**||**Description**|
|:---|:---|:---|
|**Display Name**||The name of the Activation track shown in the Timeline window and Playable Director component. The Display Name applies to the Timeline Asset and all of its Timeline instances.|
|**Post-playback state**||Sets the activation state for the bound GameObject when the Timeline Asset stops playing. The Post-playback state applies to the Timeline Asset and all of its Timeline instances.|
||Active|Activates the bound GameObject when the Timeline Asset finishes playing.|
||Inactive|Deactivates the bound GameObject when the Timeline Asset finishes playing.|
||Revert|Reverts the bound GameObject to its activation state be