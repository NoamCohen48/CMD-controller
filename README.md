# CMD-controller
use remote CMD over the network
this program has controller and controled programs. 
the controller connects to a pc running the controled program, which enables him to run cmd commands remotely. 

##### Controlled
a python script that run's and waits for connection, when connected receives command, run it, answer and repeat till desconnecting. 

##### Controller
a C# + WinForm program with GUI from which you can connect and communicate with the Controlled program on other machine. 
![pic of program](https://i.ibb.co/7rSK8S6/download.png)
* a python terminal version is also available
