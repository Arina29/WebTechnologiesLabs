# *Report*
## Laboratory work nr.2

#### Objectives ####
* Get familiar with MVC pattern;
#### Framework: #### ASP.NET
ASP.NET MVC is a framework for building web application that uses the general Model-View-Controller pattern.
*MVC(model-view-controller)* pattern separates the modeling of the domain, the presentation, and the actions based on user input into three separate classes
* Model - manages the behavior and data of the application domain, responds to requests for information about its state and responds to instructions to change state  
* View - manages the display of information  
* Controller - controller interprets the mouse and keyboard inputs from the user, informing the model and/or the view to change as appropriate.

In this laboratory work, I integrated my first laboratory work into my application, in order to accomplish this task, I loaded all my .css 
files into Content folder and all .js into Scripts folder, then I added BundleConfig.cs(a tehnique used to improve the request load time, by reducing the number of request to the server). Next step was configuring the layouts, I have a _Layout.cshtml file,
that contains the pages common elemments(navbar and footer) and also a layout for each other pages(Index, About, Contacts etc)
