# CMD-controller
Use remote CMD over the network.  
This program has controller and controlled programs.  
The controller connects to a pc running the controlled program, which enables him to run cmd commands remotely.  

##### Controlled
A python script that waits for connection, when connected receives command, run it, answer and repeat till disconnecting. 

##### Controller
A C# + WinForm program with GUI from which you can connect and communicate with the Controlled program on a different machine. 
![pic of program](https://i.ibb.co/7rSK8S6/download.png)  
* A python terminal version is also available. 
