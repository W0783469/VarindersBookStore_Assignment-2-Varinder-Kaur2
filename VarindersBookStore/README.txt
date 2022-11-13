Student Name: Varinder Kaur
2022-11-28-1243
built the initial default application in the visual studio code
Using HTTPS, i choose C#, all platforms, and web.
I prepended the project with my name 'VarindersBookStore'
-I added Individual Account authenticaion
- I also added Razor Runtime- just for fun

Application project is called'VarindersBookStore'
-Then I Hit create and then reviewed the default app what is in the folders in which I am going to work.
1040

0115-I created the github repository for my project, named it and then create and push.

Now watched the slides given by the professor. 
 
I was in doubt so double check the files.
815- update the startup.cs by removing some content from there.
Checked the whole file that it need smore chnages or no.

Try to build the project and successful.
-checkeed the Homecontroller by tweaked it ...
checked the error I action .....to set up errorless code.
As followe the slies review the models folder as well.

Feeling tired but trying to do whereever I can do .
I saw the after footer credentials in _layout.cshtml file
Now come to the _loginPartial.cshtml file to check the inject cerdentials.

Same thing done with the _validationScriptsPartial.cshtml
To check the layout I visit the _viewStart.cshtml file.
Stated Dedugging....
After that build the project...working.
TRy to do that by clicking the privacy page.

Take a short break to have coffee...because feeling sleepy at this time.
1156-
Starting the Bootstrap.....
Go the google and search the bootswatch theme...
I tried by opening every theme which looks nice.
So finally I decided to use the 'Journal' theme in my project.
Then I download the bootstrap.css for that project to insert.
Then I go to the wwwroot folder then lib>bootstap>dist>css...
but the bootswatch.css file was already there. so I rename that file...
and insert the new bootstrap.css in that folder.

Then added the script and some css in the layout file.
Then go the _Layout.cshtml to the css file  name from bootstrap.min.css to bootstrap.css.
changed that...
Then do changes in the layout according to the css like bg-white to bg-primary and so on....
Added some properties that I missed in previous part.
Removes the refrence from the layout...

Now its time to run the project...
Try...hope so it will execute...finger cross...please please...
After loading of 1 min its working..
Happy to see the building project....
previously the script that added i removed because at that time that do no need...
0315-
Now starting the next part....
Added scripts and css in the layput file.
Then added a new content as 'content Management' in the navigation list.
Then linked the script to it for the slide toggle for the Dropdown menu bar.
added at 0350...
Rebuilt the project...dropdown is working...hard work...
too much headache...intresting but takes time to do.

Now move to the biggest part...it can be easy..but seems dificult for me.
Add projects and modify.....starting
I added three projects form the original projects those are:-
VarindersBook.DataAccess
VarindersBook.models
VarindersBook.Utility
0438-

Then I install the packages Microsoft.EntityFrameworkCore.Relational ...
But it was not intalling the version that I was looking for ..so I tried all the versions.
then it gave the version that was compatible for my project.
it took the time to insatll...0530-
Added the Data folder in the .DataAccess and deleted the oroiginal one....
Even deleted the migrations from the folder.

Then checkd the another packages as well whethet that is installled or not.
That was installed but I delete those and install again.
Changed the namespace from the project....to reference..

Added refernce from the original project for the other three new build projects.

build the project..but errors...
Feeling disappointed...but have to do
Same thing tried with the .Models and .Utility...same probelms

That was give the eeorrs in Dbcontect and startup because I think that was of the identity EntityFrameworkCore
And even it was not able to find the refrence and access the files from the folder but not possible.
Trying a lot...but seems difficult..
Feeling tired and irritated because spending all the time on the project..
1019-
So decided to create the project again ..
Now sleeping....1230.....

Mornog...0916-starting again ....
so delete the previos repository and create again after creating the project
-prepend with my name -
Doing the steps again-------
Followe all the stepas that is mentioned in ny readme from line 1 to 90
But now no words to say...Because its giving the same errors again so not able to fix the errors.
 but except that my project is building...
 Then deciding to stop the project here....
 Checking again the files what I can do now.
 Finished.
in stratup.cs deleted the content and added a comment as delete the connection from the configuration....
------------------------------------------------------------------------------------------------------------------
------------------09-11-2022----------------
---------------------02:45pm----------------
Part-1 is not working properly so decided to create the project again
3000- created and build the project ---repeat the steps 1 t0 111 again .......
After completing all the steps when I try to build the project
Giving me the error of exception handling ..according to me it was overtiding the other files.
Solution--------04:15pm-------------
I deleted all the other folder that has any mach this project files..
Afterwards, build project ....working perfect at this points.

.............07:00pm-----------------
Moving to the next part-2
Part-2.1---------07:15pm ------Review the assignment slides-----------
First of all I reviewed all the files 
- build the application to  check it is working properly
Review the file appsetting.json as said in the slides....
Then i added the migration in the class library VarindersBook.DataAccess in the Data folder 
Then modifify the database and saved all the changes in the project........
---------------------------------------------------------------------------------
---------------------------07:45pm-----------------------------
With the help of PM console with the specific name according to the project added the migarations. The names of migarattion are:-
-20221112120112_AddmigartionChangeDatabasename.cs
-20221112123321-AddCategoryToDb.cs
-20221112125332_AddCategoryToDb.cs
-ApplicationDbContextModelSnapshot.cs
-------------------9:08pm----------------
Review the sql server like columns, syntax, statements and primary keys as well according to the instructions.
The thing to be notes here that identity should relate with the ASP.next
...............09:30---------------
Time to update the database
Open the PM console in the project then update the database ...
Then checked the updated database on the sql server object explorer as well check the error if any then try to clear those
Unfortunately it was giving  me the error, it was the error of namespace because I put the wrong name of the filr
So I correct that Then build the application ...working good..

Now...feeling tired......did lots of work........
need a little break.......
------------------11:30------------------------------------------------------

-Added category table to the database and then push it to the database 
-Added a class file in the .Models project amd modified it
Actually the new migration is shown to me empty.........why???
 I got the reason when I see the slide...the Application DBContext has not been added to it .
 Therefore added the migrations ....
 Added the changes to the AddCategoryToDb........Errors.........
it was of database........so remove the errors.......try to debug 
-Updated the database to know about the new categories and saved the content...
Late night now.................feeling sleepy........will continue next day.........
----------------------------------------------------------------------------------------------------

--------------------------------------11-11-2022----------------------------
---------------------------------------08:25am--------------------------------
continue where I leave the project..........
2.2-Repository------------
Created a class called Category.cs and to implement the repository added it to the ApplicationDBContext 
-To access the data in the .DataAccess project
---------------------10:00pm---------------------
Created a new folder Repository for the classes and interfaces then 
-added the folder IRepository for the inetrface in this folder of IRepossitory.
-Modified the CRUD operations to update the category class....for the list and to add or remove the objects
11:55pm------------Did the error fixing that was in the database 
It took a little while to clear -----an instant thought of mind is to craete a new project again....
but spend a little time to clear the error...t
-the error was in ApplicationDbContext........so clear that..then moved ahead.........
Modified the dependencied and the construcors in the project with the help of given files

Write all the code and try to debug the code in between that.
Created the classes called-
-CategoryRepository.cs
-ICategoryRepository.cs....Edited it to the project

-Modified teh ICategoryRepositoryi interface ...reviewd the modified files in the project especially CategkoryRepository.cs
Updated it.............
----------------------------11:48am------------------------------
Build tht project.........but failed .........
Error-Exception handling --------------Overriding the files...............
created sgain all the classes and then debug the code ....................
Hope so working ...as expected.....................
------------------------------------------------------------------------------------------------------
Added a new folder IRepository and class Call.ca to extend the IDisposal 
Install the new packegs through the NUget Package manager for Dapper.
Implement it in the new folder.

-----------------------------01:15pm---------------------------
Irritated at this time---------but still working on the project
Added a class called SP_Call.cs because previosly I added the wronfg one deleted that and added again the class.
Create a connection to the database to select the suitable statement the interface know as ISP_Call interface.
-added a wrapper for the unit of work.
---------------------------2:00pm------------------------------
Upadted the code by aadeed a inteface in the IRepository folder
Implemented the class in this folder
-Modified the code
-register it in the Startup.cs to get or to Configure the SErvices method by addign the using statement.
-------------------------------------------------------------------------------
--------------------------------------Part-2.3-----------------
--------------------------------------------A short break-------------------
----------------------with worry to do the project ..having coffee..................
------------------------------------5:15pm---------------------------
Category-CRUD- Added the units of work in the Startup.cs to get DI by controller 
-Added MVC conroller - areas/admin
-named it as CategoryController.cs
-Modified the code in the project.DataAccess and in the IREpository folder.
-Modifie the code in the index file to adde the category in the list of slide toggle to see the categories we are going
to add or edit.
Added the code by reviewing from the assignmnet 2 folder.
Build the project.
...........................7:30pm--------------------------
in the Layout.cshtml file the category link moved to the content managemnt list on the place of action keyword
in the drop down menu in the navigation
-----------------------------------------------------------------------------------------------------------
Added icons in the index file of the category and noticed how it is looking.......
Added javazcript in the wwwroot folder in the div in the category.js part of the project.
in the index file adde the script file and run the project.
--------------------------------9:35pm------------------------
-added the edit and delete button when we create the new category using the upsert action
Added the code in the Category upsert view file
Added the back to list button as well.
Modified the file Upsert.cshtml
Navigation -create the new category 
Mofify the title- try again and again ...................
Test the application--------------
------------------------------------------------------------------------------------
1045- Modified the CategoryController.cs 
-Checked the errors-----------update the create and create actegory to try it is working or not.
Added delete data feature in the categoryController.cs
-Functionally called API with the help of javascript that added in the Category.js 
On click event added to the catgory.js to delete the data when we click the delete button 
--Added the functionality using url--------------
Run the prpoject..........working perfect............
But not showing the data I am adding in the category list ..........
I check in the sql server It is showing on the sql server but notwhen I run the application
I think due to the browser problem but not sure...otherwise its working................
Finished.---------------------------
-------------------------------------------------------------------------------------------------------------------
